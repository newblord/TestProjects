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
		public EntityFrameworkDesignPattern(string targetFrameworkVersion, Tables tables, List<StoredProcedure> storedProcs)
			: base(targetFrameworkVersion, tables, storedProcs)
		{
		}

		//public new string ConfigurationFolderName { get; set; } = "Configurations";
		//public new string ConfigurationProjectName { get; set; }
		//public new string ContextFolderName { get; set; } = "Context";
		//public new string ContextProjectName { get; set; }
		//public new string ModelFolderName { get; set; } = "Models";
		//public new string ModelProjectName { get; set; }
		//public new string ModelInterfaceFolderName { get; set; } = "ModelInterfaces";
		//public new string ModelInterfaceProjectName { get; set; }
		//public new string ModelDtoFolderName { get; set; } = "ModelDTOs";
		//public new string ModelDtoProjectName { get; set; }
		//public new string RepositoryFolderName { get; set; } = "Repositories";
		//public new string RepositoryProjectName { get; set; }
		//public new string RepositoryInterfaceFolderName { get; set; } = "RepositoryInterfaces";
		//public new string RepositoryInterfaceProjectName { get; set; }
		//public new string SpecificationFolderName { get; set; } = "Specifications";
		//public new string SpecificationProjectName { get; set; }
		//public new string ServiceFolderName { get; set; } = "Services";
		//public new string ServiceProjectName { get; set; }
		//public new string ServiceInterfaceFolderName { get; set; } = "ServiceInterfaces";
		//public new string ServiceInterfaceProjectName { get; set; }

		//public new string ContextNamespace { get; set; } = "Context";
		//public new string ModelInterfaceNamespace { get; set; } = "Models.Interface";
		//public new string ModelDtoNamespace { get; set; } = "Models.DTO";
		//public new string ModelNamespace { get; set; } = "Models";
		//public new string ModelConfigurationNamespace { get; set; } = "Models.Configuration";
		//public new string RepositoryInterfaceNamespace { get; set; } = "Repositories.Interface";
		//public new string RepositoryNamespace { get; set; } = "Repositories";
		//public new string SpecificationNamespace { get; set; } = "Specification";
		//public new string ServiceInterfaceNamespace { get; set; } = "Services.Interface";
		//public new string ServiceNamespace { get; set; } = "Services";
		//public new string UnitOfWorkNamespace { get; set; } = "Context.UnitOfWork";

		public override void CreateFiles()
		{
			CreateContext();
			CreateModels();
			CreateSpecifications();
			CreateRepositories();
			CreateServices();
			CreateModelConfigurations();
			CreateStoredProcedures();

			EndFile();
			ProcessFiles();
		}

		private void CreateContext()
		{
			#region Unit of work

			if (Setting.GenerateUnitOfWorkInterface)
			{
				StartNewFile(Setting.DatabaseContextInterfaceName + Setting.FileExtension, ContextProjectName, ContextFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Data.Entity;");

				if (Tables.Where(x => x.TableData.TableSelect).Any())
				{
					WriteLine("using {0};", ModelNamespace);
				}

				if (IsSupportedFrameworkVersion("4.5"))
				{
					WriteLine("using System.Threading;");
					WriteLine("using System.Threading.Tasks;");
				}

				if (StoredProcedures.Any())
				{
					WriteLine("using System.Linq;");
				}
				WriteLine("");

				BeginNamespace(UnitOfWorkNamespace);
				BeginInterface(Setting.DatabaseContextInterfaceName, Setting.MakeContextInterfacePartial, Setting.ContextInterfaceBaseClass);

				foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
				{
					WriteLine("DbSet<{0}> {1} {{ get; set; }}{2}", tbl.NameHumanCase, Inflector.MakeSingular(tbl.NameHumanCase), Setting.IncludeComments != CommentsStyle.None ? " // " + tbl.Name : "");
				}

				WriteLine("");

				foreach (string s in AdditionalContextInterfaceItems.Where(x => !string.IsNullOrEmpty(x)))
				{
					WriteLine(s);
				}

				WriteLine("");
				WriteLine("int SaveChanges();");

				if (IsSupportedFrameworkVersion("4.5"))
				{
					WriteLine("Task<int> SaveChangesAsync();");
					WriteLine("Task<int> SaveChangesAsync(CancellationToken cancellationToken);");
				}

				if (StoredProcedures.Any())
				{
					WriteLine("");
					WriteLine("// Stored Procedures");
					foreach (StoredProcedure sp in StoredProcedures)
					{
						int returnModelsCount = sp.ReturnModels.Count;
						if (returnModelsCount == 1)
						{
							WriteLine("{0} {1}({2});", StoredProcedureHelper.WriteStoredProcReturnType(sp), StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcFunctionParams(sp, false));
							WriteLine("{0} {1}({2});", StoredProcedureHelper.WriteStoredProcReturnType(sp), StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcFunctionParams(sp, true));
						}
						else
						{
							WriteLine("{0} {1}({2});", StoredProcedureHelper.WriteStoredProcReturnType(sp), StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcFunctionParams(sp, false));
						}

						if (IsSupportedFrameworkVersion("4.5"))
						{
							if (StoredProcedureHelper.StoredProcHasOutParams(sp) || sp.ReturnModels.Count == 0)
							{
								WriteLine("// {0}Async cannot be created due to having out parameters, or is relying on the procedure result ({1})", StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcReturnType(sp));
							}
							else
							{
								WriteLine("Task<{0}> {1}Async({2});", StoredProcedureHelper.WriteStoredProcReturnType(sp), StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcFunctionParams(sp, false));
							}
						}
					}

				}

				CloseBrace();
				CloseBrace();
			}

			#endregion

			#region Database context

			if (Setting.GenerateContextClass)
			{
				List<string> baseClasses = new List<string>();

				if (!string.IsNullOrEmpty(Setting.ContextBaseClass))
					baseClasses.Add(Setting.ContextBaseClass);

				if (Setting.GenerateUnitOfWorkInterface)
					baseClasses.Add(Setting.DatabaseContextInterfaceName);

				StartNewFile(Setting.DatabaseContextName + "Context" + Setting.FileExtension, ContextProjectName, ContextFolderName);
				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Data.Entity;");
				WriteLine("using System.Data.Entity.Infrastructure;");
				WriteLine("using System.Data.Common;");
				WriteLine("using System.Data.SqlClient;");
				WriteLine("using {0};", ModelNamespace);

				if (Setting.GenerateUnitOfWorkInterface)
				{
					WriteLine("using {0};", UnitOfWorkNamespace);
				}

				if (IsSupportedFrameworkVersion("4.5"))
				{
					WriteLine("using System.Threading;");
					WriteLine("using System.Threading.Tasks;");
				}

				if (!Setting.UseDataAnnotations)
				{
					WriteLine("using {0};", ModelConfigurationNamespace);
				}
				WriteLine("");

				BeginNamespace(ContextNamespace);
				BeginClass(Setting.DatabaseContextName, Setting.MakeClassesPartial, string.Join(", ", baseClasses));

				foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
				{
					WriteLine("public DbSet<{0}> {1} {{ get; set; }}{2}", tbl.NameHumanCase, Inflector.MakeSingular(tbl.NameHumanCase), Setting.IncludeComments != CommentsStyle.None ? " // " + tbl.Name : "");
				}

				WriteLine("");
				WriteLine("static {0}()", Setting.DatabaseContextName);
				OpenBrace();
				WriteLine("Database.SetInitializer<{0}>(null);", Setting.DatabaseContextName);
				CloseBrace();

				WriteLine("public {0}()", Setting.DatabaseContextName);
				WriteLine("\t: base({0})", Setting.DefaultConstructorArgument);
				OpenBrace();
				CloseBrace();

				WriteLine("public {0}(string connectionString)", Setting.DatabaseContextName);
				WriteLine("\t: base(connectionString)");
				OpenBrace();
				CloseBrace();

				/*
				WriteLine("public {0}(string connectionString, DbCompiledModel model)", Setting.DatabaseContextName);
				WriteLine("\t: base(connectionString, model)");
				OpenMethodBrace();
				CloseMethodBrace();

				WriteLine("public {0}(DbConnection existingConnection, bool contextOwnsConnection)", Setting.DatabaseContextName);
				WriteLine("\t: base(existingConnection, contextOwnsConnection)");
				OpenMethodBrace();
				CloseMethodBrace();

				WriteLine("public {0}(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)", Setting.DatabaseContextName);
				WriteLine("\t: base(existingConnection, model, contextOwnsConnection)");
				OpenMethodBrace();
				CloseMethodBrace();

				WriteLine("protected override void Dispose(bool disposing)");
				OpenMethodBrace();
				WriteLine("base.Dispose(disposing);");
				CloseMethodBrace();
				*/

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

				if (!Setting.UseDataAnnotations)
				{
					foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
					{
						WriteLine("modelBuilder.Configurations.Add(new {0}());", tbl.NameHumanCase + Setting.ConfigurationClassName);
					}
				}

				CloseBrace();

				WriteLine("public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)");
				OpenBrace();

				if (!Setting.UseDataAnnotations)
				{
					foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
					{
						WriteLine("modelBuilder.Configurations.Add(new {0}(schema));", tbl.NameHumanCase + Setting.ConfigurationClassName);
					}
				}

				WriteLine("return modelBuilder;");
				CloseBrace();

				if (StoredProcedures.Any())
				{
					foreach (StoredProcedure sp in StoredProcedures)
					{
						string spReturnClassName = StoredProcedureHelper.WriteStoredProcReturnModelName(sp);
						string spExecName = StoredProcedureHelper.WriteStoredProcFunctionName(sp);
						int returnModelsCount = sp.ReturnModels.Count;
						if (returnModelsCount > 0)
						{
							if (returnModelsCount == 1)
							{
								WriteLine("public {0} {1}({2})", StoredProcedureHelper.WriteStoredProcReturnType(sp), StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcFunctionParams(sp, false));
								OpenBrace();
								WriteLine("int procResult;");
								WriteLine("return {0}({1});", spExecName, StoredProcedureHelper.WriteStoredProcFunctionOverloadCall(sp));
								CloseBrace();

								WriteLine("public {0} {1}({2})", StoredProcedureHelper.WriteStoredProcReturnType(sp), StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcFunctionParams(sp, true));
							}
							else
							{
								WriteLine("public {0} {1}({2})", StoredProcedureHelper.WriteStoredProcReturnType(sp), StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcFunctionParams(sp, false));
							}
							OpenBrace();
							WriteLine(StoredProcedureHelper.WriteStoredProcFunctionDeclareSqlParameter(sp, true));

							if (returnModelsCount == 1)
							{
								var exec = string.Format("EXEC @procResult = [{0}].[{1}] {2}", sp.Schema, sp.Name, StoredProcedureHelper.WriteStoredProcFunctionSqlAtParams(sp));
								WriteLine("var procResultData = Database.SqlQuery<{0}>(\"{1}\", {2}).ToList();", spReturnClassName, exec, StoredProcedureHelper.WriteStoredProcFunctionSqlParameterAnonymousArray(sp, true));
								WriteLine("{0}", StoredProcedureHelper.WriteStoredProcFunctionSetSqlParameters(sp, false));
								WriteLine("procResult = (int) procResultParam.Value;");
							}
							else
							{
								var exec = string.Format("[{0}].[{1}]", sp.Schema, sp.Name);
								WriteLine("{0}", StoredProcedureHelper.WriteStoredProcFunctionSetSqlParameters(sp, false));
								WriteLine("var procResultData = new {0}();", spReturnClassName);
								WriteLine("var cmd = Database.Connection.CreateCommand();");
								WriteLine("cmd.CommandType = System.Data.CommandType.StoredProcedure;");
								WriteLine("cmd.CommandText = \"{0}\";", exec);

								foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
								{
									WriteLine("cmd.Parameters.Add({0});", StoredProcedureHelper.WriteStoredProcSqlParameterName(p));
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
							}
							WriteLine("return procResultData;");
							CloseBrace();

						}
						else
						{
							WriteLine("public int {0}({1})", spExecName, StoredProcedureHelper.WriteStoredProcFunctionParams(sp, true));
							OpenBrace();
							WriteLine("{0} ", StoredProcedureHelper.WriteStoredProcFunctionDeclareSqlParameter(sp, true));
							WriteLine("Database.ExecuteSqlCommand(\"EXEC @procResult = [{0}].[{1}] {2}\", {3});", sp.Schema, sp.Name, StoredProcedureHelper.WriteStoredProcFunctionSqlAtParams(sp), StoredProcedureHelper.WriteStoredProcFunctionSqlParameterAnonymousArray(sp, true));
							WriteLine("{0} ", StoredProcedureHelper.WriteStoredProcFunctionSetSqlParameters(sp, false));
							WriteLine("return (int) procResultParam.Value;");
							CloseBrace();

						}

						// Async
						if (IsSupportedFrameworkVersion("4.5") && !StoredProcedureHelper.StoredProcHasOutParams(sp) && returnModelsCount > 0)
						{
							WriteLine("public async Task<{0}> {1}Async({2})", StoredProcedureHelper.WriteStoredProcReturnType(sp), StoredProcedureHelper.WriteStoredProcFunctionName(sp), StoredProcedureHelper.WriteStoredProcFunctionParams(sp, false));
							OpenBrace();
							WriteLine("{0}", StoredProcedureHelper.WriteStoredProcFunctionDeclareSqlParameter(sp, false));
							if (returnModelsCount == 1)
							{
								var parameters = StoredProcedureHelper.WriteStoredProcFunctionSqlParameterAnonymousArray(sp, false);
								if (!string.IsNullOrWhiteSpace(parameters))
									parameters = ", " + parameters;
								var exec = string.Format("EXEC [{0}].[{1}] {2}", sp.Schema, sp.Name, StoredProcedureHelper.WriteStoredProcFunctionSqlAtParams(sp));
								WriteLine("var procResultData = await Database.SqlQuery<{0}>(\"{1}\"{2}).ToListAsync();", spReturnClassName, exec, parameters);
								WriteLine("{0}", StoredProcedureHelper.WriteStoredProcFunctionSetSqlParameters(sp, false));
							}
							else
							{
								var exec = string.Format("[{0}].[{1}]", sp.Schema, sp.Name);
								WriteLine("{0}", StoredProcedureHelper.WriteStoredProcFunctionSetSqlParameters(sp, false));
								WriteLine("var procResultData = new {0}();", spReturnClassName);
								WriteLine("var cmd = Database.Connection.CreateCommand();");
								WriteLine("cmd.CommandType = System.Data.CommandType.StoredProcedure;");
								WriteLine("cmd.CommandText = \"{0}\";", exec);
								foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
								{
									WriteLine("cmd.Parameters.Add({0});", StoredProcedureHelper.WriteStoredProcSqlParameterName(p));
								}

								WriteLine("try");
								OpenBrace();
								WriteLine("Database.Connection.Open();");
								WriteLine("var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false);");
								WriteLine("var objectContext = ((IObjectContextAdapter) this).ObjectContext;");

								int n = 0;
								var returnModelCount = sp.ReturnModels.Count;
								foreach (var returnModel in sp.ReturnModels)
								{
									n++;
									WriteLine("procResultData.ResultSet{0} = objectContext.Translate<{1}.ResultSetModel{0}>(reader).ToList();", n, spReturnClassName);
									if (n < returnModelCount)
									{
										WriteLine("await reader.NextResultAsync().ConfigureAwait(false);");
									}
								}

								CloseBrace();
								WriteLine("finally");
								OpenBrace();
								WriteLine("Database.Connection.Close();");
								CloseBrace();
							}

							WriteLine("return procResultData;");
							CloseBrace();
						}
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

				StartNewFile(tbl.NameHumanCase + Setting.GeneratedFileExtension, ModelProjectName, ModelFolderName);
				if (!tbl.HasPrimaryKey)
				{
					WriteLine("// The table '{0}' is not usable by entity framework because it", tbl.Name);
					WriteLine("// does not have a primary key. It is listed here for completeness.");
				}

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");

				if (Setting.UseDataAnnotations)
				{
					WriteLine("using System.ComponentModel.DataAnnotations;");
					WriteLine("using System.ComponentModel.DataAnnotations.Schema;");
				}

				if (tbl.TableData.GenerateModelInterface)
				{
					WriteLine("using {0};", ModelInterfaceNamespace);
					baseClasses = string.Format("{0}I{1}", WriteModelBaseClasses(tbl), tbl.NameHumanCase);
				}

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine("using {0};", ModelDtoNamespace);
				}

				WriteLine("");

				BeginNamespace(ModelNamespace);

				WriteLine(WriteModelClassAttributes(tbl));
				BeginClass(tbl.NameHumanCase, Setting.MakeClassesPartial, baseClasses);
				WriteLine(WriteModelBaseClassBody(tbl));

				if (tbl.Columns.Where(c => c.Default != string.Empty && !c.Hidden).Count() > 0 || Setting.MakeClassesPartial)
				{
					WriteLine("[System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Usage\", \"CA2214:DoNotCallOverridableMethodsInConstructors\")]");
					WriteLine("public {0}()", tbl.NameHumanCase);
					OpenBrace();

					foreach (Column col in tbl.Columns.OrderBy(x => x.Ordinal).Where(c => c.Default != string.Empty && !c.Hidden))
					{
						WriteLine("{0} = {1};", col.NameHumanCase, col.Default);
					}

					if (tbl.ReverseNavigationProperties.Count() > 0 && Setting.VirtualReverseNavigationProperties)
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

					foreach (Column col in computedColumns)
					{
						WriteLine("{0} = {1};", col.NameHumanCase, col.ParameterName);
					}

					CloseBrace();
				}

				foreach (Column col in tbl.Columns.OrderBy(x => x.Ordinal).Where(x => !x.Hidden))
				{
					if ((Setting.IncludeComments == CommentsStyle.InSummaryBlock) && !string.IsNullOrEmpty(col.SummaryComments))
					{
						WriteLine("///<summary>");
						WriteLine("/// {0}", col.SummaryComments);
						WriteLine("///</summary>");
					}
					WriteModelColumn(col);
				}

				if (tbl.ReverseNavigationProperties.Count() > 0 && Setting.VirtualReverseNavigationProperties)
				{
					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.OrderBy(x => x.FKPropertyName))
					{
						foreach (var rnpda in AdditionalReverseNavigationsDataAnnotations)
						{
							WriteLine("[{0}]", rnpda);
						}
						WriteLine("[System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Usage\", \"CA2227:CollectionPropertiesShouldBeReadOnly\")]");
						WriteLine("{0}", rn.PropertyString);
					}
				}

				if (tbl.HasForeignKey)
				{

					foreach (var entityFk in tbl.Columns.SelectMany(x => x.EntityForeignKeys).OrderBy(o => o))
					{
						foreach (var fkda in AdditionalForeignKeysDataAnnotations)
						{
							WriteLine("[{0}]", fkda);
						}
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

					foreach (Column col in tbl.Columns.Where(x => !x.IsComputed).OrderBy(x => x.Ordinal))
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
				StartNewFile("I" + tbl.NameHumanCase + Setting.GeneratedFileExtension, ModelInterfaceProjectName, ModelInterfaceFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ModelNamespace);
				WriteLine("");

				BeginNamespace(ModelInterfaceNamespace);
				BeginInterface("I" + tbl.NameHumanCase, Setting.MakeInterfacesPartial, "");

				foreach (Column col in tbl.Columns.OrderBy(x => x.Ordinal).Where(x => !x.Hidden))
				{
					if (!col.IsComputed)
					{
						WriteModelInterfaceColumn(col);
					}
				}

				if (tbl.ReverseNavigationProperties.Count() > 0 && Setting.VirtualReverseNavigationProperties)
				{
					foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.OrderBy(x => x.FKPropertyName))
					{
						foreach (var rnpda in AdditionalReverseNavigationsDataAnnotations)
						{
							WriteLine("  [{0}]", rnpda);
						}
						WriteLine("{0}", rn.PropertyString.Replace("public virtual", ""));
					}
				}

				if (tbl.HasForeignKey)
				{
					foreach (var entityFk in tbl.Columns.SelectMany(x => x.EntityForeignKeys).OrderBy(o => o))
					{
						foreach (var fkda in AdditionalForeignKeysDataAnnotations)
						{
							WriteLine("[{0}]", fkda);
						}
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

				StartNewFile(className + Setting.GeneratedFileExtension, ModelDtoProjectName, ModelDtoFolderName);
				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ModelNamespace);

				WriteLine("");

				BeginNamespace(ModelDtoNamespace);

				BeginClass(className, Setting.MakeClassesPartial, "");

				if (tbl.Columns.Where(c => c.Default != string.Empty && !c.Hidden).Count() > 0 || Setting.MakeClassesPartial)
				{
					WriteLine("public {0}()", className);
					OpenBrace();

					foreach (Column col in tbl.Columns.OrderBy(x => x.Ordinal).Where(c => c.Default != string.Empty && !c.Hidden))
					{
						WriteLine("{0} = {1};", col.NameHumanCase, col.Default);
					}

					if (tbl.ReverseNavigationProperties.Count() > 0 && Setting.VirtualReverseNavigationProperties)
					{
						foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.Where(x => x.HasConstructorString).OrderBy(x => x.FKPropertyName))
						{
							WriteLine("{0}", rn.ConstructorString);
						}
					}

					CloseBrace();
				}

				if(computedColumns.Any())
				{
					var parameters = computedColumns.OrderBy(x => x.Ordinal).Select(x => $"{x.PropertyType} {x.ParameterName}");

					WriteLine("public {0}({1})", className, string.Join(", ", parameters));
					OpenBrace();

					foreach (Column col in computedColumns)
					{
						WriteLine("{0} = {1};", col.NameHumanCase, col.ParameterName);
					}

					CloseBrace();
				}

				foreach (Column col in tbl.Columns.OrderBy(x => x.Ordinal).Where(x => !x.Hidden))
				{
					WriteModelDTOColumn(col);
				}

				if (tbl.ReverseNavigationProperties.Count() > 0 && Setting.VirtualReverseNavigationProperties)
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

				foreach (Column col in tbl.Columns.Where(x => !x.IsComputed).OrderBy(x => x.Ordinal))
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

			if (!Setting.UseDataAnnotations)
			{
				foreach (Table tbl in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase))
				{
					StartNewFile(tbl.NameHumanCase + Setting.ConfigurationClassName + Setting.FileExtension, ConfigurationProjectName, ConfigurationFolderName);

					CreateHeader();

					WriteLine("using System.Data.Entity.ModelConfiguration;");
					WriteLine("using System.ComponentModel.DataAnnotations.Schema;");
					WriteLine("using {0};", ModelNamespace);
					WriteLine("");

					BeginNamespace(ModelConfigurationNamespace);
					BeginClass(tbl.NameHumanCase + Setting.ConfigurationClassName, Setting.MakeClassesPartial, string.Format("EntityTypeConfiguration<{0}>", tbl.NameHumanCase));

					WriteLine("public {0}()", tbl.NameHumanCase + Setting.ConfigurationClassName);
					WriteLine(": this( \"{0}\" )", string.IsNullOrEmpty(tbl.Schema) ? "" : tbl.Schema);
					OpenBrace();
					CloseBrace();

					WriteLine("public {0}(string schema)", tbl.NameHumanCase + Setting.ConfigurationClassName);
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

					foreach (Column col in tbl.Columns.Where(x => !x.Hidden).OrderBy(x => x.Ordinal))
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

				StartNewFile(className + Setting.FileExtension, SpecificationProjectName, SpecificationFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ModelNamespace);
				WriteLine("using Tiger.Validation;");
				WriteLine("");

				BeginNamespace(SpecificationNamespace);
				BeginClass(className, Setting.MakeClassesPartial, $"ModelSpecBase<{tbl.NameHumanCase}>");

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

				StartNewFile(className + Setting.GeneratedFileExtension, RepositoryProjectName, RepositoryFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using System.Data.Entity;");
				WriteLine("using System.Linq;");
				WriteLine("using {0};", ContextNamespace);
				WriteLine("using {0};", ModelNamespace);

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine($"using {ModelDtoNamespace};");
				}

				if (tbl.TableData.GenerateRepositoryInterface)
				{
					WriteLine("using {0};", RepositoryInterfaceNamespace);
				}

				WriteLine("");

				BeginNamespace(RepositoryNamespace);
				BeginClass(className, Setting.MakeClassesPartial, tbl.TableData.GenerateRepositoryInterface ? "I" + tbl.NameHumanCase + "Repository" : "");

				WriteLine("private readonly {0} Context;", Setting.DatabaseContextName);

				WriteLine("public {0}()", className);
				OpenBrace();
				WriteLine("Context = new {0}();", Setting.DatabaseContextName);
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
					foreach (Column pk in tbl.PrimaryKeys)
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
					foreach (Column pk in tbl.PrimaryKeys)
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
					WriteLine("public IEnumerable<{0}> GetBy{1}({2})", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.CreateParameterString());
					OpenBrace();
					WriteLine("return Context.{0}.Where(x => {1}){2};", tbl.NameHumanCase, index.CreateWhereString(), tbl.TableData.GenerateModelDto ? ".Select(x => x.ToDTO())" : ".AsEnumerable()");
					CloseBrace();
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("public {0} FindBy{1}({2})", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.CreateParameterString());
					OpenBrace();

					if (tbl.TableData.GenerateModelDto)
					{
						WriteLine("var data = Context.{0}.Where(x => {1}).FirstOrDefault();", tbl.NameHumanCase, index.CreateWhereString());
						WriteLine("return data != null ? data.ToDTO() : null;");
					}
					else
					{
						WriteLine("return Context.{0}.Where(x => {1}).FirstOrDefault();", tbl.NameHumanCase, index.CreateWhereString());
					}

					CloseBrace();
				}

				if (!Setting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
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

				StartNewFile("I" + tbl.NameHumanCase + "Repository" + Setting.GeneratedFileExtension, RepositoryInterfaceProjectName, RepositoryInterfaceFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ModelNamespace);

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine($"using {ModelDtoNamespace};");
				}

				WriteLine("");

				BeginNamespace(RepositoryInterfaceNamespace);
				BeginInterface("I" + tbl.NameHumanCase + "Repository", Setting.MakeInterfacesPartial, "");

				WriteLine("{0} Insert({1} data);", returnObjectName, tbl.NameHumanCase);
				WriteLine("{0} Update({1} data);", returnObjectName, tbl.NameHumanCase);

				if (tbl.HasPrimaryKey)
				{
					foreach (Column pk in tbl.PrimaryKeys)
					{
						WriteLine("void DeleteBy{0}({1} {2});", pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
					}
				}

				WriteLine("void Delete({0} data);", tbl.NameHumanCase);
				WriteLine("IEnumerable<{0}> GetAll();", returnObjectName);

				if (tbl.HasPrimaryKey)
				{
					foreach (Column pk in tbl.PrimaryKeys)
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
					WriteLine("IEnumerable<{0}> GetBy{1}({2});", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.CreateParameterString());
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("{0} FindBy{1}({2});", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.CreateParameterString());
				}

				if (!Setting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
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

				StartNewFile(className + Setting.GeneratedFileExtension, ServiceProjectName, ServiceFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using System.Linq;");
				WriteLine("using {0};", ContextNamespace);
				WriteLine("using {0};", ModelNamespace);

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine($"using {ModelDtoNamespace};");
				}

				if (tbl.TableData.GenerateServiceInterface)
				{
					WriteLine("using {0};", ServiceInterfaceNamespace);
				}

				if (tbl.TableData.GenerateRepository)
				{
					WriteLine($"using {RepositoryNamespace};");
				}

				if (tbl.TableData.GenerateSpecification)
				{
					WriteLine($"using {SpecificationNamespace};");
				}

				WriteLine("");

				BeginNamespace(ServiceNamespace);
				BeginClass(className, Setting.MakeClassesPartial, tbl.TableData.GenerateServiceInterface ? "I" + className : "");

				WriteLine("private readonly {0} Context;", Setting.DatabaseContextName);
				WriteLine("private {0} {1};", repositoryName, repositoryVariableName);

				WriteLine("public {0}()", className);
				OpenBrace();
				WriteLine("Context = new {0}();", Setting.DatabaseContextName);
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
					foreach (Column pk in tbl.PrimaryKeys)
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
					foreach (Column pk in tbl.PrimaryKeys)
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
					WriteLine("public IEnumerable<{0}> GetBy{1}({2})", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.CreateParameterString());
					OpenBrace();
					WriteLine("return {0}.GetBy{1}({2});", repositoryVariableName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), string.Join(", ", index.Columns.Select(s => s.ParameterName)));
					CloseBrace();
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("public {0} FindBy{1}({2})", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.CreateParameterString());
					OpenBrace();
					WriteLine("return {0}.FindBy{1}({2});", repositoryVariableName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), string.Join(", ", index.Columns.Select(s => s.ParameterName)));
					CloseBrace();
				}

				if (!Setting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
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

				StartNewFile("I" + tbl.NameHumanCase + "Service" + Setting.GeneratedFileExtension, ServiceInterfaceProjectName, ServiceInterfaceFolderName);

				CreateHeader();

				WriteLine("using System;");
				WriteLine("using System.Collections.Generic;");
				WriteLine("using {0};", ModelNamespace);

				if (tbl.TableData.GenerateModelDto)
				{
					WriteLine($"using {ModelDtoNamespace};");
				}

				WriteLine("");

				BeginNamespace(ServiceInterfaceNamespace);
				BeginInterface("I" + tbl.NameHumanCase + "Service", Setting.MakeInterfacesPartial, "");

				WriteLine("{0} Insert({0} data);", returnObjectName);
				WriteLine("{0} Update({0} data);", returnObjectName);

				if (tbl.HasPrimaryKey)
				{
					foreach (Column pk in tbl.PrimaryKeys)
					{
						WriteLine("void DeleteBy{0}({1} {2});", pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
					}
				}

				WriteLine("void Delete({0} data);", returnObjectName);
				WriteLine("IEnumerable<{0}> GetAll();", returnObjectName);

				if (tbl.HasPrimaryKey)
				{
					foreach (Column pk in tbl.PrimaryKeys)
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
					WriteLine("IEnumerable<{0}> GetBy{1}({2});", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.CreateParameterString());
				}

				foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
				{
					WriteLine("{0} FindBy{1}({2});", returnObjectName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), index.CreateParameterString());
				}

				if (!Setting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
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

			if (StoredProcedures.Any())
			{
				foreach (StoredProcedure sp in StoredProcedures.Where(x => x.ReturnModels.Count > 0 && x.ReturnModels.Any(returnColumns => returnColumns.Any()) && !StoredProcedureHelper.StoredProcedureReturnTypes.ContainsKey(x.NameHumanCase) && !StoredProcedureHelper.StoredProcedureReturnTypes.ContainsKey(x.Name)))
				{
					string spReturnClassName = StoredProcedureHelper.WriteStoredProcReturnModelName(sp);

					StartNewFile(spReturnClassName + Setting.FileExtension);

					CreateHeader();

					WriteLine("using System.Collections.Generic;");
					WriteLine("");

					BeginClass(spReturnClassName, false, "");

					var returnModelCount = sp.ReturnModels.Count;

					if (returnModelCount < 2)
					{
						foreach (var returnColumn in sp.ReturnModels.First())
						{
							WriteLine("{0}", StoredProcedureHelper.WriteStoredProcReturnColumn(returnColumn));
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

							foreach (var returnColumn in returnModel)
							{
								WriteLine("{0}", StoredProcedureHelper.WriteStoredProcReturnColumn(returnColumn));
							}
							CloseBrace();

							WriteLine("public List<ResultSetModel{0}> ResultSet{0};", model);

						}
					}
					CloseBrace();
				}
			}

		}
	}
}

