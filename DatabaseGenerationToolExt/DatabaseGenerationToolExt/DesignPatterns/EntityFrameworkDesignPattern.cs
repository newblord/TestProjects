using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;
using DatabaseGenerationToolExt.Helpers;
using DatabaseGenerationToolExt.DatabaseGeneration.Models;

namespace DatabaseGenerationToolExt.DesignPatterns
{
	public class EntityFrameworkDesignPattern : DesignPattern
	{
		public EntityFrameworkDesignPattern(Tables tables, List<StoredProcedure> storedProcs, List<DatabaseGeneration.Models.Enum> enums)
			: base(tables, storedProcs, enums)
		{
		}

		public override void CreateFiles()
		{
			CreateContext();
			CreateModels();
			CreateSpecifications();
			CreateRepositories();
			CreateServices();
			CreateModelConfigurations();
			CreateStoredProcedures();
			CreateEnums();

			EndFile();
			ProcessFiles();
		}

		private void CreateContext()
		{
			#region Unit of work

			if (DatabaseSetting.GenerateUnitOfWorkInterface)
			{
				StartNewFile(DatabaseSetting.DatabaseContextInterfaceName + DatabaseSetting.FileExtension, ProjectSetting.ContextProjectName, ProjectSetting.ContextFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Data.Entity;");
				WriteLine("using System.Data.Entity.Core.Objects;");

				if (Tables.Where(x => x.TableData.TableSelect).Any())
				{
					WriteLine("using {0};", ProjectSetting.ModelNamespace);
				}

				if (StoredProcedures.Any())
				{
					WriteLine("using System.Linq;");
				}
				WriteLine("");

				BeginNamespace(ProjectSetting.UnitOfWorkNamespace);
				BeginInterface(DatabaseSetting.DatabaseContextInterfaceName, DatabaseSetting.MakeContextInterfacePartial, DatabaseSetting.ContextInterfaceBaseClass);

				foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
				{
					WriteLine("DbSet<{0}> {1} {{ get; set; }}{2}", tbl.NameHumanCase, Inflector.MakeSingular(tbl.NameHumanCase), DatabaseSetting.IncludeComments != CommentsStyle.None ? " // " + tbl.Name : "");
				}

				WriteLine("");

				WriteLine("int SaveChanges();");

				if (StoredProcedures.Any())
				{
					WriteLine("");
					WriteLine("// Stored Procedures");
					foreach (StoredProcedure sp in StoredProcedures)
					{
						WriteLine("{0} {1}({2});", sp.ReturnType, sp.NameHumanCase, sp.GetParameterString());
					}

				}

				CloseBrace();
				CloseBrace();
			}

			#endregion

			#region Database context

			if (DatabaseSetting.GenerateContextClass)
			{
				List<string> baseClasses = new List<string>();

				if (!string.IsNullOrEmpty(DatabaseSetting.ContextBaseClass))
					baseClasses.Add(DatabaseSetting.ContextBaseClass);

				if (DatabaseSetting.GenerateUnitOfWorkInterface)
					baseClasses.Add(DatabaseSetting.DatabaseContextInterfaceName);

				StartNewFile(DatabaseSetting.DatabaseContextName + "Context" + DatabaseSetting.FileExtension, ProjectSetting.ContextProjectName, ProjectSetting.ContextFolderName);
				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Data.Entity;");
				WriteLine("using System.Data.Entity.Infrastructure;");
				WriteLine("using System.Data.Common;");
				WriteLine("using System.Data.SqlClient;");
				WriteLine("using System.Data.Entity.Core.Objects;");

				if (StoredProcedures.Any())
				{
					WriteLine("using System.Linq;");
				}

				if (Tables.Where(x => x.TableData.TableSelect).Any())
				{
					WriteLine("using {0};", ProjectSetting.ModelNamespace);
				}

				if (DatabaseSetting.GenerateUnitOfWorkInterface)
				{
					WriteLine("using {0};", ProjectSetting.UnitOfWorkNamespace);
				}

				if (!DatabaseSetting.UseDataAnnotations)
				{
					WriteLine("using {0};", ProjectSetting.ConfigurationNamespace);
				}
				WriteLine("");

				BeginNamespace(ProjectSetting.ContextNamespace);
				BeginClass(DatabaseSetting.DatabaseContextName, DatabaseSetting.MakeClassesPartial, string.Join(", ", baseClasses));

				foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
				{
					WriteLine("public DbSet<{0}> {1} {{ get; set; }}{2}", tbl.NameHumanCase, Inflector.MakeSingular(tbl.NameHumanCase), DatabaseSetting.IncludeComments != CommentsStyle.None ? " // " + tbl.Name : "");
				}

				WriteLine("");
				WriteLine("static {0}()", DatabaseSetting.DatabaseContextName);
				OpenBrace();
				WriteLine("Database.SetInitializer<{0}>(null);", DatabaseSetting.DatabaseContextName);
				CloseBrace();

				WriteLine("public {0}()", DatabaseSetting.DatabaseContextName);
				WriteLine("\t: base({0})", DatabaseSetting.DefaultConstructorArgument);
				OpenBrace();
				CloseBrace();

				WriteLine("public {0}(string connectionString)", DatabaseSetting.DatabaseContextName);
				WriteLine("\t: base(connectionString)");
				OpenBrace();
				CloseBrace();

				WriteLine("public bool IsSqlParameterNull(SqlParameter param)");
				OpenBrace();
				WriteLine("var sqlValue = param.SqlValue;");
				WriteLine("var nullableValue = sqlValue as System.Data.SqlTypes.INullable;");
				WriteLine("if (nullableValue != null)");
				PushIndent("\t");
				WriteLine("return nullableValue.IsNull;");
				PopIndent();
				WriteLine("return (sqlValue == null || sqlValue == DBNull.Value);");
				CloseBrace();

				WriteLine("protected override void OnModelCreating(DbModelBuilder modelBuilder)");
				OpenBrace();
				WriteLine("base.OnModelCreating(modelBuilder);");

				if (!DatabaseSetting.UseDataAnnotations)
				{
					foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
					{
						WriteLine("modelBuilder.Configurations.Add(new {0}());", tbl.NameHumanCase + DatabaseSetting.ConfigurationClassName);
					}
				}

				CloseBrace();

				WriteLine("public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)");
				OpenBrace();

				if (!DatabaseSetting.UseDataAnnotations)
				{
					foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
					{
						WriteLine("modelBuilder.Configurations.Add(new {0}(schema));", tbl.NameHumanCase + DatabaseSetting.ConfigurationClassName);
					}
				}

				WriteLine("return modelBuilder;");
				CloseBrace();

				if (StoredProcedures.Any())
				{
					foreach (StoredProcedure sp in StoredProcedures.OrderBy(x => x.NameHumanCase).AsEnumerable())
					{
						string spReturnClassName = sp.ReturnModelName;
						string spExecName = sp.NameHumanCase;
						int returnModelsCount = sp.ReturnModels.Count;
						if (returnModelsCount > 0)
						{
							WriteLine("public {0} {1}({2})", sp.ReturnType, spExecName, sp.GetParameterString());
						}
						else
						{
							WriteLine("public int {0}({1})", spExecName, sp.GetParameterString());
						}

						OpenBrace();

						foreach (StoredProcedureParameter p in sp.Parameters)
						{
							bool isNullable = !PropertyTypeHelper.NotNullable.Contains(p.PropertyType.ToLower());
							var getValueOrDefault = isNullable ? ".GetValueOrDefault()" : string.Empty;

							if (returnModelsCount <= 1)
							{
								if (isNullable)
								{
									WriteLine($"var {p.ParameterName}Param = {p.ParameterName}.HasValue ?");
								}
								else
								{
									WriteLine($"var {p.ParameterName}Param = {p.ParameterName} != null ?");
								}

								WriteLine($"new ObjectParameter(\"{p.ParameterName}\", {p.ParameterName}) :");
								WriteLine($"new ObjectParameter(\"{p.ParameterName}\", typeof({p.PropertyType}));");
								WriteLine("");
							}
							else
							{
								WriteLine("var {0} = new System.Data.SqlClient.SqlParameter {{ ParameterName = \"{1}\", SqlDbType = System.Data.SqlDbType.{2}, Direction = System.Data.ParameterDirection.{3}{4}{5}{6} }};",
												 p.NameHumanCase + "Param",
												 p.Name,
												 p.SqlPropertyType,
												 p.Mode == StoredProcedureParameterMode.In ? "Input" : "Output",
												 p.Mode == StoredProcedureParameterMode.In ? ", Value = " + p.NameHumanCase + getValueOrDefault : string.Empty,
												 p.MaxLength != 0 ? ", Size = " + p.MaxLength : string.Empty,
												 (p.Precision > 0 || p.Scale > 0) ? ", Precision = " + p.Precision + ", Scale = " + p.Scale : string.Empty);

								if (p.Mode == StoredProcedureParameterMode.In)
								{
									if (isNullable)
									{
										WriteLine("if (!{0}.HasValue)", p.NameHumanCase);
										WriteLine("{0}Param.Value = System.DBNull.Value;", p.NameHumanCase);
										WriteLine("");
									}
									else
									{
										WriteLine("if ({0}Param.Value == null)", p.NameHumanCase);
										WriteLine("{0}Param.Value = System.DBNull.Value;", p.NameHumanCase);
										WriteLine("");
									}
								}
							}
						}

						if (returnModelsCount == 0)
						{
							WriteLine("return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction(\"{0}\"{1}{2});", sp.Name, sp.Parameters.Any() ? ", " : string.Empty, string.Join(", ", sp.Parameters.Select(x => x.ParameterName + "Param")));
						}
						else if (returnModelsCount == 1)
						{
							WriteLine("return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<{0}>(\"{1}\"{2}{3});", sp.ReturnModelName, sp.Name, sp.Parameters.Any() ? ", " : string.Empty, string.Join(", ", sp.Parameters.Select(x => x.ParameterName + "Param")));
						}
						else
						{
							var exec = string.Format("[{0}].[{1}]", sp.Schema, sp.Name);

							foreach (var p in sp.Parameters.Where(x => x.Mode != StoredProcedureParameterMode.In).OrderBy(x => x.Ordinal))
							{
								string Default = string.Format("default({0})", p.PropertyType);
								bool notNullable = PropertyTypeHelper.NotNullable.Contains(p.PropertyType.ToLower());

								WriteLine("if (IsSqlParameterNull({0}Param))", p.NameHumanCase);
								WriteLine("{0} = {1};", p.NameHumanCase, notNullable ? Default : "null");
								WriteLine("else");
								WriteLine("{0} = ({1}) {2}Param.Value;", p.NameHumanCase, p.PropertyType, p.NameHumanCase);
							}

							WriteLine("var procResultData = new {0}();", spReturnClassName);
							WriteLine("var cmd = Database.Connection.CreateCommand();");
							WriteLine("cmd.CommandType = System.Data.CommandType.StoredProcedure;");
							WriteLine("cmd.CommandText = \"{0}\";", exec);

							foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
							{
								WriteLine("cmd.Parameters.Add({0});", p.NameHumanCase + "Param");
							}

							WriteLine("try");
							OpenBrace();
							WriteLine("Database.Connection.Open();");
							WriteLine("var reader = cmd.ExecuteReader();");
							WriteLine("var objectContext = ((IObjectContextAdapter) this).ObjectContext;");

							int n = 0;
							var returnModelCount = sp.ReturnModels.Count;
							foreach (var returnModel in sp.ReturnModels)
							{
								n++;
								WriteLine("procResultData.ResultSet{0} = objectContext.Translate<{1}.ResultSetModel{0}>(reader).ToList();", n, spReturnClassName);
								if (n < returnModelCount)
								{
									WriteLine("reader.NextResult();");

								}
							}
							CloseBrace();
							WriteLine("finally");
							OpenBrace();
							WriteLine("Database.Connection.Close();");
							CloseBrace();
							WriteLine("return procResultData;");
						}
						CloseBrace();
					}
				}
				CloseBrace();
				CloseBrace();
			}

			#endregion
		}

		private void CreateModels()
		{
			#region Models

			foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping).OrderBy(x => x.NameHumanCase) select t)
			{
				string baseClasses = string.Empty;
				var computedColumns = tbl.Columns.Where(c => c.IsComputed && !c.Hidden);

				StartNewFile(tbl.NameHumanCase + DatabaseSetting.GeneratedFileExtension, ProjectSetting.ModelProjectName, ProjectSetting.ModelFolderName);
				if (!tbl.HasPrimaryKey)
				{
					WriteLine("// The table '{0}' is not usable by entity framework because it", tbl.Name);
					WriteLine("// does not have a primary key. It is listed here for completeness.");
				}

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");

				if (DatabaseSetting.UseDataAnnotations)
				{
					WriteLine("using System.ComponentModel.DataAnnotations;");
					WriteLine("using System.ComponentModel.DataAnnotations.Schema;");
				}

				if (tbl.TableData.GenerateModelInterface)
				{
					WriteLine("using {0};", ProjectSetting.ModelInterfaceNamespace);
					baseClasses = string.Format("{0}I{1}", tbl.GetModelBaseClasses(), tbl.NameHumanCase);
				}

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine("using {0};", ProjectSetting.ModelDtoNamespace);
				}

				WriteLine("");

				BeginNamespace(ProjectSetting.ModelNamespace);

				foreach (string da in tbl.DataAnnotations)
				{
					WriteLine(da);
				}

				BeginClass(tbl.NameHumanCase, DatabaseSetting.MakeClassesPartial, baseClasses);

				if (tbl.Columns.Where(c => c.DefaultValue != string.Empty && !c.Hidden).Count() > 0 || DatabaseSetting.MakeClassesPartial)
				{
					WriteLine("[System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Usage\", \"CA2214:DoNotCallOverridableMethodsInConstructors\")]");
					WriteLine("public {0}()", tbl.NameHumanCase);
					OpenBrace();

					foreach (TableColumn col in tbl.Columns.OrderBy(x => x.Ordinal).Where(c => c.DefaultValue != string.Empty && !c.Hidden))
					{
						WriteLine("{0} = {1};", col.NameHumanCase, col.DefaultValue);
					}

					if (tbl.ReverseNavigationProperties.Count() > 0 && DatabaseSetting.VirtualReverseNavigationProperties)
					{
						foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.Where(x => x.HasConstructorString).OrderBy(x => x.FKPropertyName))
						{
							WriteLine("{0}", rn.ConstructorString);
						}
					}

					CloseBrace();
				}

				if (computedColumns.Any())
				{
					var parameters = computedColumns.OrderBy(x => x.Ordinal).Select(x => $"{x.PropertyType} {x.ParameterName}");

					WriteLine("public {0}({1})", tbl.NameHumanCase, string.Join(", ", parameters));
					OpenBrace();

					foreach (TableColumn col in computedColumns)
					{
						WriteLine("{0} = {1};", col.NameHumanCase, col.ParameterName);
					}

					CloseBrace();
				}

				foreach (TableColumn col in tbl.Columns.OrderBy(x => x.Ordinal).Where(x => !x.Hidden))
				{
					if ((DatabaseSetting.IncludeComments == CommentsStyle.InSummaryBlock) && !string.IsNullOrEmpty(col.SummaryComments))
					{
						WriteLine("///<summary>");
						WriteLine("/// {0}", col.SummaryComments);
						WriteLine("///</summary>");
					}

					foreach (string da in col.DataAnnotations)
					{
						WriteLine(da);
					}

					WriteLine(col.Entity);
				}

				if (tbl.ReverseNavigationProperties.Count() > 0 && DatabaseSetting.VirtualReverseNavigationProperties)
				{
					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.OrderBy(x => x.FKPropertyName))
					{
						WriteLine("[System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Usage\", \"CA2227:CollectionPropertiesShouldBeReadOnly\")]");
						WriteLine("{0}", rn.PropertyString);
					}
				}

				if (tbl.HasForeignKey)
				{

					foreach (var entityFk in tbl.Columns.SelectMany(x => x.EntityForeignKeys).OrderBy(o => o))
					{
						WriteLine("{0}", entityFk);
					}
				}

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine("public {0} ToDTO()", tbl.NameHumanCase + "DTO");
					OpenBrace();

					if (computedColumns.Any())
					{
						var parameters = computedColumns.OrderBy(x => x.Ordinal).Select(x => x.NameHumanCase);
						WriteLine("{0} dto = new {0}({1});", tbl.NameHumanCase + "DTO", string.Join(", ", parameters));
					}
					else
					{
						WriteLine("{0} dto = new {0}();", tbl.NameHumanCase + "DTO");
					}

					WriteLine("");

					foreach (TableColumn col in tbl.Columns.Where(x => !x.IsComputed).OrderBy(x => x.Ordinal))
					{
						WriteLine("dto.{0} = {0};", col.NameHumanCase);
					}

					WriteLine("");
					WriteLine("return dto;");

					CloseBrace();
				}

				CloseBrace();
				CloseBrace();
			}

			#endregion

			#region Model Interfaces

			foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateModelInterface).OrderBy(x => x.NameHumanCase) select t)
			{
				StartNewFile("I" + tbl.NameHumanCase + DatabaseSetting.GeneratedFileExtension, ProjectSetting.ModelInterfaceProjectName, ProjectSetting.ModelInterfaceFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ProjectSetting.ModelNamespace);
				WriteLine("");

				BeginNamespace(ProjectSetting.ModelInterfaceNamespace);
				BeginInterface("I" + tbl.NameHumanCase, DatabaseSetting.MakeInterfacesPartial, "");

				foreach (TableColumn col in tbl.Columns.OrderBy(x => x.Ordinal).Where(x => !x.Hidden))
				{
					if (!col.IsComputed)
					{
						WriteLine(col.InterfaceEntity);
					}
				}

				if (tbl.ReverseNavigationProperties.Count() > 0 && DatabaseSetting.VirtualReverseNavigationProperties)
				{
					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.OrderBy(x => x.FKPropertyName))
					{
						WriteLine("{0}", rn.PropertyString.Replace("public virtual", ""));
					}
				}

				if (tbl.HasForeignKey)
				{
					foreach (var entityFk in tbl.Columns.SelectMany(x => x.EntityForeignKeys).OrderBy(o => o))
					{
						WriteLine("{0}", entityFk.Replace("public virtual", ""));
					}
				}
				CloseBrace();
				CloseBrace();
			}

			#endregion

			#region Model DTOs

			foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateModelDto).OrderBy(x => x.NameHumanCase) select t)
			{
				string className = tbl.NameHumanCase + "DTO";
				var computedColumns = tbl.Columns.Where(x => x.IsComputed && !x.Hidden);

				StartNewFile(className + DatabaseSetting.GeneratedFileExtension, ProjectSetting.ModelDtoProjectName, ProjectSetting.ModelDtoFolderName);
				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ProjectSetting.ModelNamespace);

				WriteLine("");

				BeginNamespace(ProjectSetting.ModelDtoNamespace);

				BeginClass(className, DatabaseSetting.MakeClassesPartial, "");

				if (tbl.Columns.Where(c => c.DefaultValue != string.Empty && !c.Hidden).Count() > 0 || DatabaseSetting.MakeClassesPartial)
				{
					WriteLine("public {0}()", className);
					OpenBrace();

					foreach (TableColumn col in tbl.Columns.OrderBy(x => x.Ordinal).Where(c => c.DefaultValue != string.Empty && !c.Hidden))
					{
						WriteLine("{0} = {1};", col.NameHumanCase, col.DefaultValue);
					}

					if (tbl.ReverseNavigationProperties.Count() > 0 && DatabaseSetting.VirtualReverseNavigationProperties)
					{
						foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.Where(x => x.HasConstructorString).OrderBy(x => x.FKPropertyName))
						{
							WriteLine("{0}", rn.ConstructorString);
						}
					}

					CloseBrace();
				}

				if (computedColumns.Any())
				{
					var parameters = computedColumns.OrderBy(x => x.Ordinal).Select(x => $"{x.PropertyType} {x.ParameterName}");

					WriteLine("public {0}({1})", className, string.Join(", ", parameters));
					OpenBrace();

					foreach (TableColumn col in computedColumns)
					{
						WriteLine("{0} = {1};", col.NameHumanCase, col.ParameterName);
					}

					CloseBrace();
				}

				foreach (TableColumn col in tbl.Columns.OrderBy(x => x.Ordinal).Where(x => !x.Hidden))
				{
					WriteLine(col.Entity);
				}

				if (tbl.ReverseNavigationProperties.Count() > 0 && DatabaseSetting.VirtualReverseNavigationProperties)
				{
					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.OrderBy(x => x.FKPropertyName))
					{
						WriteLine("{0}", rn.PropertyString);
					}
				}

				if (tbl.HasForeignKey)
				{

					foreach (var entityFk in tbl.Columns.SelectMany(x => x.EntityForeignKeys).OrderBy(o => o))
					{
						WriteLine("{0}", entityFk);
					}
				}

				WriteLine("public {0} ToModel()", tbl.NameHumanCase);
				OpenBrace();

				if (computedColumns.Any())
				{
					var parameters = computedColumns.OrderBy(x => x.Ordinal).Select(x => x.NameHumanCase);
					WriteLine("{0} model = new {0}({1});", tbl.NameHumanCase, string.Join(", ", parameters));
				}
				else
				{
					WriteLine("{0} model = new {0}();", tbl.NameHumanCase);
				}


				WriteLine("");

				foreach (TableColumn col in tbl.Columns.Where(x => !x.IsComputed).OrderBy(x => x.Ordinal))
				{
					WriteLine("model.{0} = {0};", col.NameHumanCase);
				}

				WriteLine("");
				WriteLine("return model;");

				CloseBrace();

				CloseBrace();
				CloseBrace();
			}

			#endregion
		}

		private void CreateModelConfigurations()
		{
			#region Model Configurations

			if (!DatabaseSetting.UseDataAnnotations)
			{
				foreach (Table tbl in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase))
				{
					StartNewFile(tbl.NameHumanCase + DatabaseSetting.ConfigurationClassName + DatabaseSetting.FileExtension, ProjectSetting.ConfigurationProjectName, ProjectSetting.ConfigurationFolderName);

					CreateHeader();

					WriteLine("using System.Data.Entity.ModelConfiguration;");
					WriteLine("using System.ComponentModel.DataAnnotations.Schema;");
					WriteLine("using {0};", ProjectSetting.ModelNamespace);
					WriteLine("");

					BeginNamespace(ProjectSetting.ConfigurationNamespace);
					BeginClass(tbl.NameHumanCase + DatabaseSetting.ConfigurationClassName, DatabaseSetting.MakeClassesPartial, string.Format("EntityTypeConfiguration<{0}>", tbl.NameHumanCase));

					WriteLine("public {0}()", tbl.NameHumanCase + DatabaseSetting.ConfigurationClassName);
					WriteLine(": this( \"{0}\" )", string.IsNullOrEmpty(tbl.Schema) ? "" : tbl.Schema);
					OpenBrace();
					CloseBrace();

					WriteLine("public {0}(string schema)", tbl.NameHumanCase + DatabaseSetting.ConfigurationClassName);
					OpenBrace();
					if (!string.IsNullOrEmpty(tbl.Schema))
					{
						WriteLine("ToTable(\"{0}\", schema);", tbl.Name);
					}
					else
					{
						WriteLine("ToTable(\"{0}\");", tbl.Name);
					}
					WriteLine("HasKey({0});", tbl.PrimaryKeyNameHumanCase());

					foreach (TableColumn col in tbl.Columns.Where(x => !x.Hidden).OrderBy(x => x.Ordinal))
					{
						WriteLine("{0}", col.Config);
					}

					if (tbl.HasForeignKey)
					{
						foreach (var configFk in tbl.Columns.SelectMany(x => x.ConfigForeignKeys).OrderBy(o => o))
						{
							WriteLine("{0}", configFk);
						}
					}

					CloseBrace();
					CloseBrace();
					CloseBrace();
				}
			}

			#endregion
		}

		private void CreateSpecifications()
		{
			#region Specification

			foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateSpecification).OrderBy(x => x.NameHumanCase) select t)
			{
				string className = tbl.NameHumanCase + "Specification";

				StartNewFile(className + DatabaseSetting.FileExtension, ProjectSetting.SpecificationProjectName, ProjectSetting.SpecificationFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ProjectSetting.ModelNamespace);
				WriteLine("using Tiger.Validation;");
				WriteLine("");

				BeginNamespace(ProjectSetting.SpecificationNamespace);
				BeginClass(className, DatabaseSetting.MakeClassesPartial, $"ModelSpecBase<{tbl.NameHumanCase}>");

				WriteLine("public ValidationMethod CurrentValidationMethod { get; private set; }");

				WriteLine($"public {className}()");
				WriteLine(": this(ValidationMethod.Default)");
				OpenBrace();
				CloseBrace();

				WriteLine("[System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Usage\", \"CA1801: ReviewUnusedParameters\", MessageId = \"validationMethod\")]");
				WriteLine($"public {className}(ValidationMethod validationMethod)");
				OpenBrace();
				WriteLine("CurrentValidationMethod = validationMethod;");
				WriteLine("");
				WriteLine("//TODO: Register any custom validation methods.");
				CloseBrace();

				WriteLine("public enum ValidationMethod");
				OpenBrace();
				WriteLine("Default = 0");
				CloseBrace();

				CloseBrace();
				CloseBrace();
			}

			#endregion
		}

		private void CreateRepositories()
		{
			#region Repositories

			foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateRepository).OrderBy(x => x.NameHumanCase) select t)
			{
				string className = tbl.NameHumanCase + "Repository";
				string returnObjectName = tbl.TableData.GenerateModelDto ? tbl.NameHumanCase + "DTO" : tbl.NameHumanCase;
				string convertMethodString = tbl.TableData.GenerateModelDto ? ".ToDTO()" : "";

				StartNewFile(className + DatabaseSetting.GeneratedFileExtension, ProjectSetting.RepositoryProjectName, ProjectSetting.RepositoryFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using System.Data.Entity;");
				WriteLine("using System.Linq;");
				WriteLine("using {0};", ProjectSetting.ContextNamespace);
				WriteLine("using {0};", ProjectSetting.ModelNamespace);

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine($"using {ProjectSetting.ModelDtoNamespace};");
				}

				if (tbl.TableData.GenerateRepositoryInterface)
				{
					WriteLine("using {0};", ProjectSetting.RepositoryInterfaceNamespace);
				}

				WriteLine("");

				BeginNamespace(ProjectSetting.RepositoryNamespace);
				BeginClass(className, DatabaseSetting.MakeClassesPartial, tbl.TableData.GenerateRepositoryInterface ? "I" + tbl.NameHumanCase + "Repository" : "");

				WriteLine("private readonly {0} Context;", DatabaseSetting.DatabaseContextName);

				WriteLine("public {0}()", className);
				OpenBrace();
				WriteLine("Context = new {0}();", DatabaseSetting.DatabaseContextName);
				CloseBrace();

				WriteLine("public {0} Insert({1} data)", returnObjectName, tbl.NameHumanCase);
				OpenBrace();
				WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot insert null value in {0}.Insert\"); }}", className);
				WriteLine("");
				WriteLine("Context.{0}.Add(data);", tbl.NameHumanCase);
				WriteLine("Context.SaveChanges();");
				WriteLine("");
				WriteLine("return data{0};", convertMethodString);
				CloseBrace();

				WriteLine("public {0} Update({1} data)", returnObjectName, tbl.NameHumanCase);
				OpenBrace();
				WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot update null value in {0}.Update\"); }}", className);
				WriteLine("");
				WriteLine("Context.Entry(data).State = EntityState.Modified;");
				WriteLine("Context.SaveChanges();");
				WriteLine("");
				WriteLine("return data{0};", convertMethodString);
				CloseBrace();

				if (tbl.HasPrimaryKey)
				{
					foreach (TableColumn pk in tbl.PrimaryKeys)
					{
						WriteLine("public void DeleteBy{0}({1} {2})", pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
						OpenBrace();
						WriteLine("var data = Context.{0}.Where(x => x.{1} == {2}).FirstOrDefault();", tbl.NameHumanCase, pk.NameHumanCase, pk.ParameterName);
						WriteLine("Delete(data);");
						CloseBrace();
					}
				}

				WriteLine("public void Delete({0} data)", tbl.NameHumanCase);
				OpenBrace();
				WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot delete null value in {0}.Delete\"); }}", className);
				WriteLine("");
				WriteLine("Context.{0}.Remove(data);", tbl.NameHumanCase);
				WriteLine("Context.SaveChanges();");
				CloseBrace();

				WriteLine("public IEnumerable<{0}> GetAll()", returnObjectName);
				OpenBrace();
				WriteLine("return Context.{0}{1}.AsEnumerable();", tbl.NameHumanCase, tbl.TableData.GenerateModelDto ? ".Select(x => x.ToDTO())" : "");
				CloseBrace();

				if (tbl.HasPrimaryKey)
				{
					foreach (TableColumn pk in tbl.PrimaryKeys)
					{
						WriteLine("public {0} FindBy{1}({2} {3})", returnObjectName, pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
						OpenBrace();

						if (tbl.TableData.GenerateModelDto)
						{
							WriteLine("var data = Context.{0}.Where(x => x.{1} == {2}).FirstOrDefault();", tbl.NameHumanCase, pk.NameHumanCase, pk.ParameterName);
							WriteLine("return data != null ? data.ToDTO() : null;");
						}
						else
						{
							WriteLine("return Context.{0}.Where(x => x.{1} == {2}).FirstOrDefault();", tbl.NameHumanCase, pk.NameHumanCase, pk.ParameterName);
						}

						CloseBrace();
					}

					if (tbl.PrimaryKeys.Count() > 1)
					{
						var parameters = tbl.PrimaryKeys.OrderBy(x => x.PrimaryKeyOrdinal).Select(x => $"{x.PropertyType} {x.ParameterName}");
						var whereParameters = tbl.PrimaryKeys.Select(x => $"x.{x.NameHumanCase} == {x.ParameterName}");

						WriteLine("public {0} FindBy{1}({2})", returnObjectName, string.Join(string.Empty, tbl.PrimaryKeys.Select(x => x.NameHumanCase)), string.Join(", ", parameters));
						OpenBrace();

						if (tbl.TableData.GenerateModelDto)
						{
							WriteLine("var data = Context.{0}.Where(x => {1}).FirstOrDefault();", tbl.NameHumanCase, string.Join("&& ", whereParameters));
							WriteLine("return data != null ? data.ToDTO() : null;");
						}
						else
						{
							WriteLine("return Context.{0}.Where(x => {1}).FirstOrDefault();", tbl.NameHumanCase, string.Join("&& ", whereParameters));
						}

						CloseBrace();
					}
				}

				foreach (ForeignKey fk in tbl.GetFilteredForeignKeys())
				{
					WriteLine("public IEnumerable<{0}> FindBy{1}({2} {3})", returnObjectName, fk.FKColumn.NameHumanCase, fk.FKColumn.PropertyType, fk.FKColumn.ParameterName);
					OpenBrace();
					WriteLine("return Context.{0}.Where(x => x.{1} == {2}){3};", tbl.NameHumanCase, fk.FKColumn.NameHumanCase, fk.FKColumn.ParameterName, tbl.TableData.GenerateModelDto ? ".Select(x => x.ToDTO())" : ".AsEnumerable()");
					CloseBrace();
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == false).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("public IEnumerable<{0}> GetBy{1}({2})", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.GetParameterString());
					OpenBrace();
					WriteLine("return Context.{0}.Where(x => {1}){2};", tbl.NameHumanCase, index.GetWhereString(), tbl.TableData.GenerateModelDto ? ".Select(x => x.ToDTO())" : ".AsEnumerable()");
					CloseBrace();
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("public {0} FindBy{1}({2})", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.GetParameterString());
					OpenBrace();

					if (tbl.TableData.GenerateModelDto)
					{
						WriteLine("var data = Context.{0}.Where(x => {1}).FirstOrDefault();", tbl.NameHumanCase, index.GetWhereString());
						WriteLine("return data != null ? data.ToDTO() : null;");
					}
					else
					{
						WriteLine("return Context.{0}.Where(x => {1}).FirstOrDefault();", tbl.NameHumanCase, index.GetWhereString());
					}

					CloseBrace();
				}

				if (!DatabaseSetting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
				{
					WriteLine("// Reverse Navigation Methods");

					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.GroupBy(x => x.FKTable.NameHumanCase).Select(x => x.FirstOrDefault()))
					{
						returnObjectName = rn.FKTable.TableData.GenerateModelDto ? rn.FKTable.NameHumanCase + "DTO" : rn.FKTable.NameHumanCase;

						if (rn.Relationship == Relationship.OneToOne || rn.Relationship == Relationship.OneToMany)
						{
							WriteLine("public {0} Get{1}By{2}({3} {4})", returnObjectName, rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.PropertyType, rn.PKColumn.ParameterName);
							OpenBrace();
							if (tbl.TableData.GenerateModelDto)
							{
								WriteLine("var data = Context.{0}.Where(x => x.{1} == {2}).FirstOrDefault();", rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.ParameterName);
								WriteLine("return data != null ? data.ToDTO() : null;");
							}
							else
							{
								WriteLine("return Context.{0}.Where(x => x.{1} == {2}).FirstOrDefault();", rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.ParameterName);
							}
						}
						else if (rn.Relationship == Relationship.ManyToOne || rn.Relationship == Relationship.ManyToMany)
						{
							WriteLine("public IEnumerable<{0}> Get{1}By{2}({3} {4})", returnObjectName, Inflector.MakePlural(rn.FKTable.NameHumanCase), rn.FKColumn.NameHumanCase, rn.PKColumn.PropertyType, rn.PKColumn.ParameterName);
							OpenBrace();
							WriteLine("return Context.{0}.Where(x => x.{1} == {2}){3}.AsEnumerable();", rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.ParameterName, rn.FKTable.TableData.GenerateModelDto ? ".Select(x => x.ToDTO())" : "");
						}

						CloseBrace();
					}
				}

				CloseBrace();
				CloseBrace();
			}

			#endregion

			#region Repository Interfaces

			foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateRepositoryInterface).OrderBy(x => x.NameHumanCase) select t)
			{
				string returnObjectName = tbl.TableData.GenerateModelDto ? tbl.NameHumanCase + "DTO" : tbl.NameHumanCase;

				StartNewFile("I" + tbl.NameHumanCase + "Repository" + DatabaseSetting.GeneratedFileExtension, ProjectSetting.RepositoryInterfaceProjectName, ProjectSetting.RepositoryInterfaceFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ProjectSetting.ModelNamespace);

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine($"using {ProjectSetting.ModelDtoNamespace};");
				}

				WriteLine("");

				BeginNamespace(ProjectSetting.RepositoryInterfaceNamespace);
				BeginInterface("I" + tbl.NameHumanCase + "Repository", DatabaseSetting.MakeInterfacesPartial, "");

				WriteLine("{0} Insert({1} data);", returnObjectName, tbl.NameHumanCase);
				WriteLine("{0} Update({1} data);", returnObjectName, tbl.NameHumanCase);

				if (tbl.HasPrimaryKey)
				{
					foreach (TableColumn pk in tbl.PrimaryKeys)
					{
						WriteLine("void DeleteBy{0}({1} {2});", pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
					}
				}

				WriteLine("void Delete({0} data);", tbl.NameHumanCase);
				WriteLine("IEnumerable<{0}> GetAll();", returnObjectName);

				if (tbl.HasPrimaryKey)
				{
					foreach (TableColumn pk in tbl.PrimaryKeys)
					{
						WriteLine("{0} FindBy{1}({2} {3});", returnObjectName, pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
					}

					if (tbl.PrimaryKeys.Count() > 1)
					{
						var parameters = tbl.PrimaryKeys.OrderBy(x => x.PrimaryKeyOrdinal).Select(x => $"{x.PropertyType} {x.ParameterName}");

						WriteLine("{0} FindBy{1}({2});", returnObjectName, string.Join(string.Empty, tbl.PrimaryKeys.Select(x => x.NameHumanCase)), string.Join(", ", parameters));
					}
				}

				foreach (ForeignKey fk in tbl.GetFilteredForeignKeys())
				{
					WriteLine("IEnumerable<{0}> FindBy{1}({2} {3});", returnObjectName, fk.FKColumn.NameHumanCase, fk.FKColumn.PropertyType, fk.FKColumn.ParameterName);
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == false).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("IEnumerable<{0}> GetBy{1}({2});", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.GetParameterString());
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("{0} FindBy{1}({2});", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.GetParameterString());
				}

				if (!DatabaseSetting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
				{
					WriteLine("// Reverse Navigation Methods");

					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.GroupBy(x => x.FKTable.NameHumanCase).Select(x => x.FirstOrDefault()))
					{
						returnObjectName = rn.FKTable.TableData.GenerateModelDto ? rn.FKTable.NameHumanCase + "DTO" : rn.FKTable.NameHumanCase;

						if (rn.Relationship == Relationship.OneToOne || rn.Relationship == Relationship.OneToMany)
						{
							WriteLine("{0} Get{1}By{2}({3} {4});", returnObjectName, rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.PropertyType, rn.PKColumn.NameHumanCase);
						}
						else if (rn.Relationship == Relationship.ManyToOne || rn.Relationship == Relationship.ManyToMany)
						{
							WriteLine("IEnumerable<{0}> Get{1}By{2}({3} {4});", returnObjectName, Inflector.MakePlural(rn.FKTable.NameHumanCase), rn.FKColumn.NameHumanCase, rn.PKColumn.PropertyType, rn.PKColumn.NameHumanCase);
						}
					}
				}

				CloseBrace();
				CloseBrace();
			}

			#endregion
		}

		private void CreateServices()
		{
			#region Services

			foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateService).OrderBy(x => x.NameHumanCase) select t)
			{
				string className = tbl.NameHumanCase + "Service";
				string repositoryName = tbl.NameHumanCase + "Repository";
				string repositoryVariableName = "_" + Inflector.MakeInitialLower(tbl.NameHumanCase) + "Repository";
				string returnObjectName = tbl.TableData.GenerateModelDto ? tbl.NameHumanCase + "DTO" : tbl.NameHumanCase;
				string convertMethodString = tbl.TableData.GenerateModelDto ? ".ToModel()" : "";

				StartNewFile(className + DatabaseSetting.GeneratedFileExtension, ProjectSetting.ServiceProjectName, ProjectSetting.ServiceFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using System.Linq;");
				WriteLine("using {0};", ProjectSetting.ContextNamespace);
				WriteLine("using {0};", ProjectSetting.ModelNamespace);

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine($"using {ProjectSetting.ModelDtoNamespace};");
				}

				if (tbl.TableData.GenerateServiceInterface)
				{
					WriteLine("using {0};", ProjectSetting.ServiceInterfaceNamespace);
				}

				if (tbl.TableData.GenerateRepository)
				{
					WriteLine($"using {ProjectSetting.RepositoryNamespace};");
				}

				if (tbl.TableData.GenerateSpecification)
				{
					WriteLine($"using {ProjectSetting.SpecificationNamespace};");
				}

				WriteLine("");

				BeginNamespace(ProjectSetting.ServiceNamespace);
				BeginClass(className, DatabaseSetting.MakeClassesPartial, tbl.TableData.GenerateServiceInterface ? "I" + className : "");

				WriteLine("private readonly {0} Context;", DatabaseSetting.DatabaseContextName);
				WriteLine("private {0} {1};", repositoryName, repositoryVariableName);

				WriteLine("public {0}()", className);
				OpenBrace();
				WriteLine("Context = new {0}();", DatabaseSetting.DatabaseContextName);
				WriteLine("{0} = new {1}();", repositoryVariableName, repositoryName);
				CloseBrace();

				WriteLine("public {0} Insert({0} data)", returnObjectName);
				OpenBrace();
				WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot insert null value in {0}.Insert\"); }}", className);
				WriteLine("");
				WriteLine("return {0}.Insert(data{1});", repositoryVariableName, convertMethodString);
				CloseBrace();

				WriteLine("public {0} Update({0} data)", returnObjectName);
				OpenBrace();
				WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot update null value in {0}.Update\"); }}", className);
				WriteLine("");
				WriteLine("return {0}.Update(data{1});", repositoryVariableName, convertMethodString);
				CloseBrace();

				if (tbl.HasPrimaryKey)
				{
					foreach (TableColumn pk in tbl.PrimaryKeys)
					{
						WriteLine("public void DeleteBy{0}({1} {2})", pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
						OpenBrace();
						WriteLine("{0}.DeleteBy{1}({2});", repositoryVariableName, pk.NameHumanCase, pk.ParameterName);
						CloseBrace();
					}
				}

				WriteLine("public void Delete({0} data)", returnObjectName);
				OpenBrace();
				WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot delete null value in {0}.Delete\"); }}", className);
				WriteLine("");
				WriteLine("{0}.Delete(data{1});", repositoryVariableName, convertMethodString);
				CloseBrace();

				WriteLine("public IEnumerable<{0}> GetAll()", returnObjectName);
				OpenBrace();
				WriteLine("return {0}.GetAll();", repositoryVariableName);
				CloseBrace();

				if (tbl.HasPrimaryKey)
				{
					foreach (TableColumn pk in tbl.PrimaryKeys)
					{
						WriteLine("public {0} FindBy{1}({2} {3})", returnObjectName, pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
						OpenBrace();
						WriteLine("return {0}.FindBy{1}({2});", repositoryVariableName, pk.NameHumanCase, pk.ParameterName);
						CloseBrace();
					}

					if (tbl.PrimaryKeys.Count() > 1)
					{
						var parameters = tbl.PrimaryKeys.OrderBy(x => x.PrimaryKeyOrdinal).Select(x => $"{x.PropertyType} {x.ParameterName}");

						WriteLine("public {0} FindBy{1}({2})", returnObjectName, string.Join(string.Empty, tbl.PrimaryKeys.Select(x => x.NameHumanCase)), string.Join(", ", parameters));
						OpenBrace();
						WriteLine("return {0}.FindBy{1}({2});", repositoryVariableName, string.Join(string.Empty, tbl.PrimaryKeys.Select(x => x.NameHumanCase)), string.Join(", ", tbl.PrimaryKeys.Select(x => x.ParameterName)));
						CloseBrace();
					}
				}

				foreach (ForeignKey fk in tbl.GetFilteredForeignKeys())
				{
					WriteLine("public IEnumerable<{0}> FindBy{1}({2} {3})", returnObjectName, fk.FKColumn.NameHumanCase, fk.FKColumn.PropertyType, fk.FKColumn.ParameterName);
					OpenBrace();
					WriteLine("return {0}.FindBy{1}({2});", repositoryVariableName, fk.FKColumn.NameHumanCase, fk.FKColumn.ParameterName);
					CloseBrace();
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == false).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("public IEnumerable<{0}> GetBy{1}({2})", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.GetParameterString());
					OpenBrace();
					WriteLine("return {0}.GetBy{1}({2});", repositoryVariableName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), string.Join(", ", index.Columns.Select(s => s.ParameterName)));
					CloseBrace();
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("public {0} FindBy{1}({2})", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.GetParameterString());
					OpenBrace();
					WriteLine("return {0}.FindBy{1}({2});", repositoryVariableName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), string.Join(", ", index.Columns.Select(s => s.ParameterName)));
					CloseBrace();
				}

				if (!DatabaseSetting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
				{
					WriteLine("// Reverse Navigation Methods");

					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.GroupBy(x => x.FKTable.NameHumanCase).Select(x => x.FirstOrDefault()))
					{
						returnObjectName = tbl.TableData.GenerateModelDto ? rn.FKTable.NameHumanCase + "DTO" : rn.FKTable.NameHumanCase;

						if (rn.Relationship == Relationship.OneToOne || rn.Relationship == Relationship.OneToMany)
						{
							WriteLine("public {0} Get{1}By{2}({3} {4})", returnObjectName, rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.PropertyType, rn.PKColumn.ParameterName);
							OpenBrace();
							WriteLine("return {0}.Get{1}By{2}({3});", repositoryVariableName, rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.ParameterName);
						}
						else if (rn.Relationship == Relationship.ManyToOne || rn.Relationship == Relationship.ManyToMany)
						{
							WriteLine("public IEnumerable<{0}> Get{1}By{2}({3} {4})", returnObjectName, Inflector.MakePlural(rn.FKTable.NameHumanCase), rn.FKColumn.NameHumanCase, rn.PKColumn.PropertyType, rn.PKColumn.ParameterName);
							OpenBrace();
							WriteLine("return {0}.Get{1}By{2}({3});", repositoryVariableName, Inflector.MakePlural(rn.FKTable.NameHumanCase), rn.FKColumn.NameHumanCase, rn.PKColumn.ParameterName);
						}

						CloseBrace();
					}
				}

				if (tbl.TableData.GenerateSpecification)
				{
					string parameterName = Inflector.MakeInitialLower(tbl.NameHumanCase);
					WriteLine($"private static void Validate({tbl.NameHumanCase} {parameterName})");
					OpenBrace();
					WriteLine("//Validate with Specification");
					WriteLine("");
					WriteLine($"var {parameterName + "Specification"} = new {tbl.NameHumanCase + "Specification"}();");
					WriteLine("");
					WriteLine($"var errors = {parameterName + "Specification"}.ValidateAll({parameterName});");
					WriteLine("if (errors.Count() > 0)");
					OpenBrace();
					WriteLine($"var valException = new Tiger.Validation.ModelValidationException(\"The given {parameterName} is not valid\", errors);");
					WriteLine("throw valException;");
					CloseBrace();
					CloseBrace();
				}

				CloseBrace();
				CloseBrace();
			}

			#endregion

			#region Service Interfaces

			foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateServiceInterface).OrderBy(x => x.NameHumanCase) select t)
			{
				string returnObjectName = tbl.TableData.GenerateModelDto ? tbl.NameHumanCase + "DTO" : tbl.NameHumanCase;

				StartNewFile("I" + tbl.NameHumanCase + "Service" + DatabaseSetting.GeneratedFileExtension, ProjectSetting.ServiceInterfaceProjectName, ProjectSetting.ServiceInterfaceFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ProjectSetting.ModelNamespace);

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine($"using {ProjectSetting.ModelDtoNamespace};");
				}

				WriteLine("");

				BeginNamespace(ProjectSetting.ServiceInterfaceNamespace);
				BeginInterface("I" + tbl.NameHumanCase + "Service", DatabaseSetting.MakeInterfacesPartial, "");

				WriteLine("{0} Insert({0} data);", returnObjectName);
				WriteLine("{0} Update({0} data);", returnObjectName);

				if (tbl.HasPrimaryKey)
				{
					foreach (TableColumn pk in tbl.PrimaryKeys)
					{
						WriteLine("void DeleteBy{0}({1} {2});", pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
					}
				}

				WriteLine("void Delete({0} data);", returnObjectName);
				WriteLine("IEnumerable<{0}> GetAll();", returnObjectName);

				if (tbl.HasPrimaryKey)
				{
					foreach (TableColumn pk in tbl.PrimaryKeys)
					{
						WriteLine("{0} FindBy{1}({2} {3});", returnObjectName, pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
					}

					if (tbl.PrimaryKeys.Count() > 1)
					{
						var parameters = tbl.PrimaryKeys.OrderBy(x => x.PrimaryKeyOrdinal).Select(x => $"{x.PropertyType} {x.ParameterName}");

						WriteLine("{0} FindBy{1}({2});", returnObjectName, string.Join(string.Empty, tbl.PrimaryKeys.Select(x => x.NameHumanCase)), string.Join(", ", parameters));
					}
				}

				foreach (ForeignKey fk in tbl.GetFilteredForeignKeys())
				{
					WriteLine("IEnumerable<{0}> FindBy{1}({2} {3});", returnObjectName, fk.FKColumn.NameHumanCase, fk.FKColumn.PropertyType, fk.FKColumn.ParameterName);
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == false).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("IEnumerable<{0}> GetBy{1}({2});", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.GetParameterString());
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("{0} FindBy{1}({2});", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.GetParameterString());
				}

				if (!DatabaseSetting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
				{
					WriteLine("// Reverse Navigation Methods");

					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.GroupBy(x => x.FKTable.NameHumanCase).Select(x => x.FirstOrDefault()))
					{
						returnObjectName = tbl.TableData.GenerateModelDto ? rn.FKTable.NameHumanCase + "DTO" : rn.FKTable.NameHumanCase;

						if (rn.Relationship == Relationship.OneToOne || rn.Relationship == Relationship.OneToMany)
						{
							WriteLine("{0} Get{1}By{2}({3} {4});", returnObjectName, rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.PropertyType, rn.PKColumn.NameHumanCase);
						}
						else if (rn.Relationship == Relationship.ManyToOne || rn.Relationship == Relationship.ManyToMany)
						{
							WriteLine("IEnumerable<{0}> Get{1}By{2}({3} {4});", returnObjectName, Inflector.MakePlural(rn.FKTable.NameHumanCase), rn.FKColumn.NameHumanCase, rn.PKColumn.PropertyType, rn.PKColumn.NameHumanCase);
						}
					}
				}

				CloseBrace();
				CloseBrace();
			}

			#endregion
		}

		private void CreateStoredProcedures()
		{
			foreach (StoredProcedure sp in StoredProcedures.Where(x => x.ReturnModels.Count > 0 && x.ReturnModels.Any(returnColumns => returnColumns.Any())))
			{
				StartNewFile(sp.ReturnModelName + DatabaseSetting.FileExtension);

				CreateHeader();

				WriteLine("using System.Collections.Generic;");
				WriteLine("");

				BeginClass(sp.ReturnModelName, false, "");

				var returnModelCount = sp.ReturnModels.Count;

				if (returnModelCount < 2)
				{
					foreach (var col in sp.ReturnModels.First())
					{
						WriteLine($"public {col.PropertyType} {col.NameHumanCase} {{ get; set; }}");
					}
				}
				else
				{
					int model = 0;
					foreach (var returnModel in sp.ReturnModels)
					{
						model++;
						WriteLine("public class ResultSetModel{0}", model);
						OpenBrace();

						foreach (var col in returnModel)
						{
							WriteLine($"public {col.PropertyType} {col.NameHumanCase} {{ get; set; }}");
						}
						CloseBrace();

						WriteLine("public List<ResultSetModel{0}> ResultSet{0};", model);

					}
				}
				CloseBrace();
			}
		}

		private void CreateEnums()
		{
			foreach (DatabaseGeneration.Models.Enum @enum in from t in Enums.OrderBy(x => x.Name) select t)
			{
				StartNewFile(@enum.Name + DatabaseSetting.GeneratedFileExtension);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("");

				BeginNamespace("Enums");
				WriteLine("public enum {0}", @enum.Name);
				WriteLine("{");
				PushIndent("\t");

				int count = 1;
				foreach (var entry in @enum.Entries)
				{
					if (!string.IsNullOrEmpty(entry.Description))
					{
						this.WriteLine("[Description(\"{0}\")]", entry.Description);
					}

					if (!entry.ValueIsNumeric && !string.IsNullOrEmpty(entry.Code))
					{
						this.WriteLine("[EnumCode(\"{0}\")]", entry.Code);
					}

					this.WriteLine("{0} = {1}{2}", entry.Name, entry.ValueIsNumeric ? entry.Value : count.ToString(), count < @enum.Entries.Count ? "," : string.Empty);
					this.WriteLine("");
					count++;
				}

				CloseBrace();
				CloseBrace();
			}
		}

	}
}

