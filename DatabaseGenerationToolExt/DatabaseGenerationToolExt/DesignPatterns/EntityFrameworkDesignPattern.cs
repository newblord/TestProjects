using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseGenerationToolExt.DatabaseObjects;
using Microsoft.VisualStudio.Shell;

namespace DatabaseGenerationToolExt.DesignPatterns
{
	public class EntityFrameworkDesignPattern : DesignPattern
	{
		public EntityFrameworkDesignPattern(string targetFrameworkVersion, DatabaseGenerationSetting setting, Package package, Tables tables, List<StoredProcedure> storedProcs) 
			: base(targetFrameworkVersion, setting, package, tables, storedProcs)
		{
		}

		//public string ConfigurationFolderName { get; set; } = "Configurations";
		//public string ConfigurationProjectName { get; set; }
		//public string ContextFolderName { get; set; } = "Context";
		//public string ContextProjectName { get; set; }
		//public string ModelFolderName { get; set; } = "Models";
		//public string ModelProjectName { get; set; }
		//public string ModelInterfaceFolderName { get; set; } = "ModelInterfaces";
		//public string ModelInterfaceProjectName { get; set; }
		//public string RepositoryFolderName { get; set; } = "Repositories";
		//public string RepositoryProjectName { get; set; }
		//public string RepositoryInterfaceFolderName { get; set; } = "RepositoryInterfaces";
		//public string RepositoryInterfaceProjectName { get; set; }
		//public string ServiceFolderName { get; set; } = "Services";
		//public string ServiceProjectName { get; set; }
		//public string ServiceInterfaceFolderName { get; set; } = "ServiceInterfaces";
		//public string ServiceInterfaceProjectName { get; set; }

		//public string ContextNamespace { get; set; } = "Context";
		//public string PocoInterfaceNamespace { get; set; } = "Poco.Interface";
		//public string PocoNamespace { get; set; } = "Poco";
		//public string PocoConfigurationNamespace { get; set; } = "Poco.Configuration";
		//public string RepositoryInterfaceNamespace { get; set; } = "Repository.Interface";
		//public string RepositoryNamespace { get; set; } = "Repository";
		//public string ServiceInterfaceNamespace { get; set; } = "Service.Interface";
		//public string ServiceNamespace { get; set; } = "Service";
		//public string UnitOfWorkNamespace { get; set; } = "Context.UnitOfWork";

		public override void CreateFiles()
		{
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
                WriteLine("using {0};", PocoNamespace);

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
                    WriteLine("DbSet<{0}> {1}s {{ get; set; }}{2}", tbl.NameHumanCase, Inflector.MakeSingular(tbl.NameHumanCase), Setting.IncludeComments != CommentsStyle.None ? " // " + tbl.Name : "");
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
                            WriteLine("{0} {1}({2});", StoredProcedure.WriteStoredProcReturnType(sp), StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcFunctionParams(sp, false));
                            WriteLine("{0} {1}({2});", StoredProcedure.WriteStoredProcReturnType(sp), StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcFunctionParams(sp, true));
                        }
                        else
                        {
                            WriteLine("{0} {1}({2});", StoredProcedure.WriteStoredProcReturnType(sp), StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcFunctionParams(sp, false));
                        }

                        if (IsSupportedFrameworkVersion("4.5"))
                        {
                            if (StoredProcedure.StoredProcHasOutParams(sp) || sp.ReturnModels.Count == 0)
                            {
                                WriteLine("// {0}Async cannot be created due to having out parameters, or is relying on the procedure result ({1})", StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcReturnType(sp));
                            }
                            else
                            {
                                WriteLine("Task<{0}> {1}Async({2});", StoredProcedure.WriteStoredProcReturnType(sp), StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcFunctionParams(sp, false));
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
                StartNewFile(Setting.DatabaseContextName + Setting.FileExtension, ContextProjectName, ContextFolderName);

                CreateHeader();

                WriteLine("using System;");
                WriteLine("using System.Data.Entity;");
                WriteLine("using System.Data.Entity.Infrastructure;");
                WriteLine("using System.Data.Common;");
                WriteLine("using System.Data.SqlClient;");
                WriteLine("using {0};", PocoNamespace);

                if (IsSupportedFrameworkVersion("4.5"))
                {
                    WriteLine("using System.Threading;");
                    WriteLine("using System.Threading.Tasks;");
                }

                if (!Setting.UseDataAnnotations)
                {
                    WriteLine("using {0};", PocoConfigurationNamespace);
                }
                WriteLine("");

                BeginNamespace(ContextNamespace);
                BeginClass(Setting.DatabaseContextName, Setting.MakeClassesPartial, string.Format("{0}, {1}", Setting.ContextBaseClass, Setting.DatabaseContextInterfaceName));

                foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
                {
                    WriteLine("public DbSet<{0}> {1}s {{ get; set; }}{2}", tbl.NameHumanCase, Inflector.MakeSingular(tbl.NameHumanCase), Setting.IncludeComments != CommentsStyle.None ? " // " + tbl.Name : "");
                }

                WriteLine("");
                WriteLine("static {0}()", Setting.DatabaseContextName);
                OpenMethodBrace();
                WriteLine("Database.SetInitializer<{0}>(null);", Setting.DatabaseContextName);
                CloseMethodBrace();

                WriteLine("public {0}()", Setting.DatabaseContextName);
                WriteLine("\t: base({0})", Setting.DefaultConstructorArgument);
                OpenMethodBrace();
                CloseMethodBrace();

                WriteLine("public {0}(string connectionString)", Setting.DatabaseContextName);
                WriteLine("\t: base(connectionString)");
                OpenMethodBrace();
                CloseMethodBrace();

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
                OpenMethodBrace();
                WriteLine("var sqlValue = param.SqlValue;");
                WriteLine("var nullableValue = sqlValue as System.Data.SqlTypes.INullable;");
                WriteLine("if (nullableValue != null)");
                PushIndent("\t");
                WriteLine("return nullableValue.IsNull;");
                PopIndent();
                WriteLine("return (sqlValue == null || sqlValue == DBNull.Value);");
                CloseMethodBrace();

                WriteLine("protected override void OnModelCreating(DbModelBuilder modelBuilder)");
                OpenMethodBrace();
                WriteLine("base.OnModelCreating(modelBuilder);");

                if (!Setting.UseDataAnnotations)
                {
                    foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
                    {
                        WriteLine("modelBuilder.Configurations.Add(new {0}());", tbl.NameHumanCase + Setting.ConfigurationClassName);
                    }
                }

                CloseMethodBrace();

                WriteLine("public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)");
                OpenMethodBrace();

                if (!Setting.UseDataAnnotations)
                {
                    foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey).OrderBy(x => x.NameHumanCase) select t)
                    {
                        WriteLine("modelBuilder.Configurations.Add(new {0}(schema));", tbl.NameHumanCase + Setting.ConfigurationClassName);
                    }
                }

                WriteLine("return modelBuilder;");
                CloseMethodBrace();

                if (StoredProcedures.Any())
                {
                    foreach (StoredProcedure sp in StoredProcedures)
                    {
                        string spReturnClassName = StoredProcedure.WriteStoredProcReturnModelName(sp);
                        string spExecName = StoredProcedure.WriteStoredProcFunctionName(sp);
                        int returnModelsCount = sp.ReturnModels.Count;
                        if (returnModelsCount > 0)
                        {
                            if (returnModelsCount == 1)
                            {
                                WriteLine("public {0} {1}({2})", StoredProcedure.WriteStoredProcReturnType(sp), StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcFunctionParams(sp, false));
                                OpenMethodBrace();
                                WriteLine("int procResult;");
                                WriteLine("return {0}({1});", spExecName, StoredProcedure.WriteStoredProcFunctionOverloadCall(sp));
                                CloseMethodBrace();

                                WriteLine("public {0} {1}({2})", StoredProcedure.WriteStoredProcReturnType(sp), StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcFunctionParams(sp, true));
                            }
                            else
                            {
                                WriteLine("public {0} {1}({2})", StoredProcedure.WriteStoredProcReturnType(sp), StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcFunctionParams(sp, false));
                            }
                            OpenMethodBrace();
                            WriteLine(StoredProcedure.WriteStoredProcFunctionDeclareSqlParameter(sp, true));

                            if (returnModelsCount == 1)
                            {
                                var exec = string.Format("EXEC @procResult = [{0}].[{1}] {2}", sp.Schema, sp.Name, StoredProcedure.WriteStoredProcFunctionSqlAtParams(sp));
                                WriteLine("var procResultData = Database.SqlQuery<{0}>(\"{1}\", {2}).ToList();", spReturnClassName, exec, StoredProcedure.WriteStoredProcFunctionSqlParameterAnonymousArray(sp, true));
                                WriteLine("{0}", StoredProcedure.WriteStoredProcFunctionSetSqlParameters(sp, false));
                                WriteLine("procResult = (int) procResultParam.Value;");
                            }
                            else
                            {
                                var exec = string.Format("[{0}].[{1}]", sp.Schema, sp.Name);
                                WriteLine("{0}", StoredProcedure.WriteStoredProcFunctionSetSqlParameters(sp, false));
                                WriteLine("var procResultData = new {0}();", spReturnClassName);
                                WriteLine("var cmd = Database.Connection.CreateCommand();");
                                WriteLine("cmd.CommandType = System.Data.CommandType.StoredProcedure;");
                                WriteLine("cmd.CommandText = \"{0}\";", exec);

                                foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
                                {
                                    WriteLine("cmd.Parameters.Add({0});", StoredProcedure.WriteStoredProcSqlParameterName(p));
                                }

                                WriteLine("try");
                                OpenMethodBrace();
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
                                CloseMethodBrace();
                                WriteLine("finally");
                                OpenMethodBrace();
                                WriteLine("Database.Connection.Close();");
                                CloseMethodBrace();
                            }
                            WriteLine("return procResultData;");
                            CloseMethodBrace();

                        }
                        else
                        {
                            WriteLine("public int {0}({1})", spExecName, StoredProcedure.WriteStoredProcFunctionParams(sp, true));
                            OpenMethodBrace();
                            WriteLine("{0} ", StoredProcedure.WriteStoredProcFunctionDeclareSqlParameter(sp, true));
                            WriteLine("Database.ExecuteSqlCommand(\"EXEC @procResult = [{0}].[{1}] {2}\", {3});", sp.Schema, sp.Name, StoredProcedure.WriteStoredProcFunctionSqlAtParams(sp), StoredProcedure.WriteStoredProcFunctionSqlParameterAnonymousArray(sp, true));
                            WriteLine("{0} ", StoredProcedure.WriteStoredProcFunctionSetSqlParameters(sp, false));
                            WriteLine("return (int) procResultParam.Value;");
                            CloseMethodBrace();

                        }

                        // Async
                        if (IsSupportedFrameworkVersion("4.5") && !StoredProcedure.StoredProcHasOutParams(sp) && returnModelsCount > 0)
                        {
                            WriteLine("public async Task<{0}> {1}Async({2})", StoredProcedure.WriteStoredProcReturnType(sp), StoredProcedure.WriteStoredProcFunctionName(sp), StoredProcedure.WriteStoredProcFunctionParams(sp, false));
                            OpenMethodBrace();
                            WriteLine("{0}", StoredProcedure.WriteStoredProcFunctionDeclareSqlParameter(sp, false));
                            if (returnModelsCount == 1)
                            {
                                var parameters = StoredProcedure.WriteStoredProcFunctionSqlParameterAnonymousArray(sp, false);
                                if (!string.IsNullOrWhiteSpace(parameters))
                                    parameters = ", " + parameters;
                                var exec = string.Format("EXEC [{0}].[{1}] {2}", sp.Schema, sp.Name, StoredProcedure.WriteStoredProcFunctionSqlAtParams(sp));
                                WriteLine("var procResultData = await Database.SqlQuery<{0}>(\"{1}\"{2}).ToListAsync();", spReturnClassName, exec, parameters);
                                WriteLine("{0}", StoredProcedure.WriteStoredProcFunctionSetSqlParameters(sp, false));
                            }
                            else
                            {
                                var exec = string.Format("[{0}].[{1}]", sp.Schema, sp.Name);
                                WriteLine("{0}", StoredProcedure.WriteStoredProcFunctionSetSqlParameters(sp, false));
                                WriteLine("var procResultData = new {0}();", spReturnClassName);
                                WriteLine("var cmd = Database.Connection.CreateCommand();");
                                WriteLine("cmd.CommandType = System.Data.CommandType.StoredProcedure;");
                                WriteLine("cmd.CommandText = \"{0}\";", exec);
                                foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
                                {
                                    WriteLine("cmd.Parameters.Add({0});", StoredProcedure.WriteStoredProcSqlParameterName(p));
                                }

                                WriteLine("try");
                                OpenMethodBrace();
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

                                CloseMethodBrace();
                                WriteLine("finally");
                                OpenMethodBrace();
                                WriteLine("Database.Connection.Close();");
                                CloseMethodBrace();
                            }

                            WriteLine("return procResultData;");
                            CloseMethodBrace();
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
            #region POCO classes

            foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GeneratePoco).OrderBy(x => x.NameHumanCase) select t)
            {
                string baseClasses = string.Empty;

                StartNewFile(tbl.NameHumanCase + Setting.GeneratedFileExtension, ModelProjectName, ModelFolderName);
                if (!tbl.HasPrimaryKey)
                {
                    WriteLine("// The table '{0}' is not usable by entity framework because it", tbl.Name);
                    WriteLine("// does not have a primary key. It is listed here for completeness.");
                }

                CreateHeader();

                WriteLine("using System;");
                WriteLine("using System.Collections.Generic;");
                WriteLine("using System.ComponentModel.DataAnnotations;");
                WriteLine("using System.ComponentModel.DataAnnotations.Schema;");

                if (tbl.TableData.GeneratePocoInterface)
                {
                    WriteLine("using {0};", PocoInterfaceNamespace);
                    baseClasses = string.Format("{0}I{1}", WritePocoBaseClasses(tbl) , tbl.NameHumanCase);
                }

                WriteLine("");

                BeginNamespace(PocoNamespace);

                WritePocoClassAttributes(tbl);
                BeginClass(tbl.NameHumanCase, Setting.MakeClassesPartial, baseClasses);
                WritePocoBaseClassBody(tbl);

                if (tbl.Columns.Where(c => c.Default != string.Empty && !c.Hidden).Count() > 0 || Setting.MakeClassesPartial)
                {
                    WriteLine("[System.Diagnostics.CodeAnalysis.SuppressMessage(\"Microsoft.Usage\", \"CA2214:DoNotCallOverridableMethodsInConstructors\")]");
                    WriteLine("public {0}()", tbl.NameHumanCase);
                    OpenMethodBrace();

                    foreach (Column col in tbl.Columns.OrderBy(x => x.Ordinal).Where(c => c.Default != string.Empty && !c.Hidden))
                    {
                        WriteLine("{0} = {1};", col.NameHumanCase, col.Default);
                    }

                    if (tbl.ReverseNavigationProperties.Count() > 0 && Setting.VirtualReverseNavigationProperties)
                    {
                        foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.Where(x => x.HasConstructorString).OrderBy(x => x.PropertyString))
                        {
                            WriteLine("{0}", rn.ConstructorString);
                        }
                    }

                    CloseMethodBrace();
                }

                foreach (Column col in tbl.Columns.OrderBy(x => x.Ordinal).Where(x => !x.Hidden))
                {
                    if ((Setting.IncludeComments == CommentsStyle.InSummaryBlock) && !string.IsNullOrEmpty(col.SummaryComments))
                    {
                        WriteLine("///<summary>");
                        WriteLine("/// {0}", col.SummaryComments);
                        WriteLine("///</summary>");
                    }
                    WriteLine("{0}", WritePocoColumn(col));
                }

                if (tbl.ReverseNavigationProperties.Count() > 0 && Setting.VirtualReverseNavigationProperties)
                {
                    foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.OrderBy(x => x.PropertyString))
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

                CloseBrace();
                CloseBrace();
            }

            #endregion

            #region POCO Interfaces

            foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GeneratePocoInterface).OrderBy(x => x.NameHumanCase) select t)
            {
                StartNewFile("I" + tbl.NameHumanCase + Setting.GeneratedFileExtension, ModelInterfaceProjectName, ModelInterfaceFolderName);

                CreateHeader();

                WriteLine("using System;");
                WriteLine("using System.Collections.Generic;");
                WriteLine("using {0};", PocoNamespace);
                WriteLine("");

                BeginNamespace(PocoInterfaceNamespace);
                BeginInterface("I" + tbl.NameHumanCase, Setting.MakeInterfacesPartial, "");

                foreach (Column col in tbl.Columns.OrderBy(x => x.Ordinal).Where(x => !x.Hidden))
                {
                    if (!col.IsComputed)
                    {
                        WriteLine("{0}", WritePocoInterfaceColumn(col));
                    }
                }

                if (tbl.ReverseNavigationProperties.Count() > 0 && Setting.VirtualReverseNavigationProperties)
                {
                    foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties.OrderBy(x => x.PropertyString))
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
        }

        private void CreateRepositories()
        {
            #region Repositories

            foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateRepository).OrderBy(x => x.NameHumanCase) select t)
            {
                string className = tbl.NameHumanCase + "Repository";

                StartNewFile(className + Setting.GeneratedFileExtension, RepositoryProjectName, RepositoryFolderName);

                CreateHeader();

                WriteLine("using System;");
                WriteLine("using System.Collections.Generic;");
                WriteLine("using System.Data.Entity;");
                WriteLine("using System.Linq;");
                WriteLine("using {0};", ContextNamespace);
                WriteLine("using {0};", PocoNamespace);

                if (tbl.TableData.GenerateRepositoryInterface)
                {
                    WriteLine("using {0};", RepositoryInterfaceNamespace);
                }

                WriteLine("");

                BeginNamespace(RepositoryNamespace);
                BeginClass(className, Setting.MakeClassesPartial, tbl.TableData.GenerateRepositoryInterface ? "I" + tbl.NameHumanCase + "Repository" : "");

                WriteLine("private readonly {0} Context;", Setting.DatabaseContextName);

                WriteLine("public {0}()", className);
                OpenMethodBrace();
                WriteLine("Context = new {0}();", Setting.DatabaseContextName);
                CloseMethodBrace();

                WriteLine("public {0} Insert({0} data)", tbl.NameHumanCase);
                OpenMethodBrace();
                WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot insert null value in {0}.Insert\"); }}", className);
                WriteLine("");
                WriteLine("Context.{0}s.Add(data);", tbl.NameHumanCase);
                WriteLine("Context.SaveChanges();");
                WriteLine("");
                WriteLine("return data;");
                CloseMethodBrace();

                WriteLine("public {0} Update({0} data)", tbl.NameHumanCase);
                OpenMethodBrace();
                WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot update null value in {0}.Update\"); }}", className);
                WriteLine("");
                WriteLine("Context.Entry(data).State = EntityState.Modified;");
                WriteLine("Context.SaveChanges();");
                WriteLine("");
                WriteLine("return data;");
                CloseMethodBrace();

                WriteLine("public void Delete(int id)");
                OpenMethodBrace();
                WriteLine("{0} data = FindById(id);", tbl.NameHumanCase);
                WriteLine("Delete(data);");
                CloseMethodBrace();

                WriteLine("public void Delete({0} data)", tbl.NameHumanCase);
                OpenMethodBrace();
                WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot delete null value in {0}.Delete\"); }}", className);
                WriteLine("");
                WriteLine("Context.{0}s.Remove(data);", tbl.NameHumanCase);
                WriteLine("Context.SaveChanges();");
                CloseMethodBrace();

                WriteLine("public IEnumerable<{0}> GetAll()", tbl.NameHumanCase);
                OpenMethodBrace();
                WriteLine("return Context.{0}s.AsEnumerable();", tbl.NameHumanCase);
                CloseMethodBrace();

                if (tbl.HasPrimaryKey)
                {
                    foreach (Column pk in tbl.PrimaryKeys)
                    {
                        WriteLine("public {0} FindBy{1}({2} {3})", tbl.NameHumanCase, pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
                        OpenMethodBrace();
                        WriteLine("return Context.{0}s.Where(x => x.{1} == {2}).FirstOrDefault();", tbl.NameHumanCase, pk.NameHumanCase, pk.ParameterName);
                        CloseMethodBrace();
                    }
                }

                foreach (ForeignKey fk in tbl.ForeignKeys)
                {
                    WriteLine("public IEnumerable<{0}> FindBy{1}({2} {3})", tbl.NameHumanCase, fk.FKColumn.NameHumanCase, fk.FKColumn.PropertyType, fk.FKColumn.ParameterName);
                    OpenMethodBrace();
                    WriteLine("return Context.{0}s.Where(x => x.{1} == {2} ).AsEnumerable();", tbl.NameHumanCase, fk.FKColumn.NameHumanCase, fk.FKColumn.ParameterName);
                    CloseMethodBrace();
                }

                foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == false).GroupBy(g => g.ColumnString).Select(s => s.First()))
                {
                    WriteLine("public IEnumerable<{0}> GetBy{1}({2})", tbl.NameHumanCase, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), Index.CreateIndexParameterString(index));
                    OpenMethodBrace();
                    WriteLine("return Context.{0}s.Where(x => {1} ).AsEnumerable();", tbl.NameHumanCase, Index.CreateIndexWhereString(index));
                    CloseMethodBrace();
                }

                foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
                {
                    WriteLine("public {0} FindBy{1}({2})", tbl.NameHumanCase, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), Index.CreateIndexParameterString(index));
                    OpenMethodBrace();
                    WriteLine("return Context.{0}s.Where(x => {1} ).FirstOrDefault();", tbl.NameHumanCase, Index.CreateIndexWhereString(index));
                    CloseMethodBrace();
                }

                if (!Setting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
                {
                    WriteLine("// Reverse Navigation Methods");

                    foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties)
                    {
                        string methodString = string.Empty;
                        string returnString = string.Empty;
                        string pkMethodName = rn.PKColumn.ParentTable.NameHumanCase + rn.PKColumn.NameHumanCase != rn.PKColumn.NameHumanCase ? rn.PKColumn.ParentTable.NameHumanCase + rn.PKColumn.NameHumanCase : rn.PKColumn.NameHumanCase;

                        if (rn.Relationship == Relationship.OneToOne || rn.Relationship == Relationship.OneToMany)
                        {
                            methodString = string.Format("public {0} Get{0}By{1}({2} {3})", rn.FKTable.NameHumanCase, pkMethodName, rn.PKColumn.PropertyType, rn.PKColumn.ParameterName);
                            returnString = string.Format("return Context.{0}s.Where(x => x.{1} == {2}).FirstOrDefault();", rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.ParameterName);
                        }
                        else if (rn.Relationship == Relationship.ManyToOne || rn.Relationship == Relationship.ManyToMany)
                        {
                            methodString = string.Format("public IEnumerable<{0}> Get{1}By{2}({3} {4})", rn.FKTable.NameHumanCase, Inflector.MakePlural(rn.FKTable.NameHumanCase), pkMethodName, rn.PKColumn.PropertyType, rn.PKColumn.ParameterName);
                            returnString = string.Format("return Context.{0}s.Where(x => x.{1} == {2}).AsEnumerable();", rn.FKTable.NameHumanCase, rn.FKColumn.NameHumanCase, rn.PKColumn.ParameterName);
                        }

                        WriteLine(methodString);
                        OpenMethodBrace();
                        WriteLine(returnString);
                        CloseMethodBrace();
                    }
                }

                CloseBrace();
                CloseBrace();
            }

            #endregion

            #region Repository Interfaces

            foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateRepositoryInterface).OrderBy(x => x.NameHumanCase) select t)
            {
                StartNewFile("I" + tbl.NameHumanCase + "Repository" + Setting.GeneratedFileExtension, RepositoryInterfaceProjectName, RepositoryInterfaceFolderName);

                CreateHeader();

                WriteLine("using System;");
                WriteLine("using System.Collections.Generic;");
                WriteLine("using {0};", PocoNamespace);
                WriteLine("");

                BeginNamespace(RepositoryInterfaceNamespace);
                BeginInterface("I" + tbl.NameHumanCase + "Repository", Setting.MakeInterfacesPartial, "");

                WriteLine("{0} Insert({0} data);", tbl.NameHumanCase);
                WriteLine("{0} Update({0} data);", tbl.NameHumanCase);
                WriteLine("void Delete(int id);");
                WriteLine("void Delete({0} data);", tbl.NameHumanCase);
                WriteLine("IEnumerable<{0}> GetAll();", tbl.NameHumanCase);

                if (tbl.HasPrimaryKey)
                {
                    foreach (Column pk in tbl.PrimaryKeys)
                    {
                        WriteLine("{0} FindBy{1}({2} {3});", tbl.NameHumanCase, pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
                    }
                }

                foreach (ForeignKey fk in tbl.ForeignKeys)
                {
                    WriteLine("IEnumerable<{0}> FindBy{1}({2} {3});", tbl.NameHumanCase, fk.FKColumn.NameHumanCase, fk.FKColumn.PropertyType, fk.FKColumn.ParameterName);
                }

                foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == false).GroupBy(g => g.ColumnString).Select(s => s.First()))
                {
                    WriteLine("IEnumerable<{0}> GetBy{1}({2});", tbl.NameHumanCase, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), Index.CreateIndexParameterString(index));
                }

                foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
                {
                    WriteLine("{0} FindBy{1}({2});", tbl.NameHumanCase, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), Index.CreateIndexParameterString(index));
                }

                if (!Setting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
                {
                    WriteLine("// Reverse Navigation Methods");

                    foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties)
                    {
                        string methodString = string.Empty;
                        string pkMethodName = rn.PKColumn.ParentTable.NameHumanCase + rn.PKColumn.NameHumanCase != rn.PKColumn.NameHumanCase ? rn.PKColumn.ParentTable.NameHumanCase + rn.PKColumn.NameHumanCase : rn.PKColumn.NameHumanCase;

                        if (rn.Relationship == Relationship.OneToOne || rn.Relationship == Relationship.OneToMany)
                        {
                            methodString = string.Format("{0} Get{0}By{1}({2} {3});", rn.FKTable.NameHumanCase, pkMethodName, rn.PKColumn.PropertyType, rn.PKColumn.NameHumanCase);
                        }
                        else if (rn.Relationship == Relationship.ManyToOne || rn.Relationship == Relationship.ManyToMany)
                        {
                            methodString = string.Format("IEnumerable<{0}> Get{1}By{2}({3} {4});", rn.FKTable.NameHumanCase, Inflector.MakePlural(rn.FKTable.NameHumanCase), pkMethodName, rn.PKColumn.PropertyType, rn.PKColumn.NameHumanCase);
                        }

                        WriteLine(methodString);
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

                StartNewFile(className + Setting.GeneratedFileExtension, ServiceProjectName, ServiceFolderName);

                CreateHeader();

                WriteLine("using System;");
                WriteLine("using System.Collections.Generic;");
                WriteLine("using System.Linq;");
                WriteLine("using {0};", ContextNamespace);
                WriteLine("using {0};", PocoNamespace);

                if (tbl.TableData.GenerateRepositoryInterface)
                {
                    WriteLine("using {0};", RepositoryInterfaceNamespace);
                }

                WriteLine("");

                BeginNamespace(RepositoryNamespace);
                BeginClass(className, Setting.MakeClassesPartial, tbl.TableData.GenerateRepositoryInterface ? "I" + tbl.NameHumanCase + "Repository" : "");

                WriteLine("private readonly {0} Context;", Setting.DatabaseContextName);
                WriteLine("private {0} {0};", repositoryName);

                WriteLine("public {0}()", className);
                OpenMethodBrace();
                WriteLine("Context = new {0}();", Setting.DatabaseContextName);
                WriteLine("{0} = new {0}();", repositoryName);
                CloseMethodBrace();

                WriteLine("public {0} Insert({0} data)", tbl.NameHumanCase);
                OpenMethodBrace();
                WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot insert null value in {0}.Insert\"); }}", className);
                WriteLine("");
                WriteLine("return {0}.Insert(data);", repositoryName);
                CloseMethodBrace();

                WriteLine("public {0} Update({0} data)", tbl.NameHumanCase);
                OpenMethodBrace();
                WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot update null value in {0}.Update\"); }}", className);
                WriteLine("");
                WriteLine("return {0}.Update(data);", repositoryName);
                CloseMethodBrace();

                WriteLine("public void Delete(int id)");
                OpenMethodBrace();
                WriteLine("{0} data = FindById(id);", tbl.NameHumanCase);
                WriteLine("Delete(data);");
                CloseMethodBrace();

                WriteLine("public void Delete({0} data)", tbl.NameHumanCase);
                OpenMethodBrace();
                WriteLine("if(data == null) {{ throw new ArgumentNullException(\"data\", \"Cannot delete null value in {0}.Delete\"); }}", className);
                WriteLine("");
                WriteLine("{0}.Delete(data);", repositoryName);
                CloseMethodBrace();

                WriteLine("public IEnumerable<{0}> GetAll()", tbl.NameHumanCase);
                OpenMethodBrace();
                WriteLine("return {0}.GetAll();", repositoryName);
                CloseMethodBrace();

                if (tbl.HasPrimaryKey)
                {
                    foreach (Column pk in tbl.PrimaryKeys)
                    {
                        WriteLine("public {0} FindBy{1}({2} {3})", tbl.NameHumanCase, pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
                        OpenMethodBrace();
                        WriteLine("return {0}.FindBy{1}({2});", repositoryName, pk.NameHumanCase, pk.ParameterName);
                        CloseMethodBrace();
                    }
                }

                foreach (ForeignKey fk in tbl.ForeignKeys)
                {
                    WriteLine("public IEnumerable<{0}> FindBy{1}({2} {3})", tbl.NameHumanCase, fk.FKColumn.NameHumanCase, fk.FKColumn.PropertyType, fk.FKColumn.ParameterName);
                    OpenMethodBrace();
                    WriteLine("return {0}.FindBy{1}({2});", repositoryName, fk.FKColumn.NameHumanCase, fk.FKColumn.ParameterName);
                    CloseMethodBrace();
                }

                foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == false).GroupBy(g => g.ColumnString).Select(s => s.First()))
                {
                    WriteLine("public IEnumerable<{0}> GetBy{1}({2})", tbl.NameHumanCase, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), Index.CreateIndexParameterString(index));
                    OpenMethodBrace();
                    WriteLine("return {0}.GetBy{1}({2});", repositoryName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), string.Join(", ", index.Columns.Select(s => s.ParameterName)));
                    CloseMethodBrace();
                }

                foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
                {
                    WriteLine("public {0} FindBy{1}({2})", tbl.NameHumanCase, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), Index.CreateIndexParameterString(index));
                    OpenMethodBrace();
                    WriteLine("return {0}.FindBy{1}({2});", repositoryName, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), string.Join(", ", index.Columns.Select(s => s.ParameterName)));
                    CloseMethodBrace();
                }

                if (!Setting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
                {
                    WriteLine("// Reverse Navigation Methods");

                    foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties)
                    {
                        string methodString = string.Empty;
                        string returnString = string.Empty;
                        string pkMethodName = rn.PKColumn.ParentTable.NameHumanCase + rn.PKColumn.NameHumanCase != rn.PKColumn.NameHumanCase ? rn.PKColumn.ParentTable.NameHumanCase + rn.PKColumn.NameHumanCase : rn.PKColumn.NameHumanCase;

                        if (rn.Relationship == Relationship.OneToOne || rn.Relationship == Relationship.OneToMany)
                        {
                            methodString = string.Format("public {0} Get{0}By{1}({2} {3})", rn.FKTable.NameHumanCase, pkMethodName, rn.PKColumn.PropertyType, rn.PKColumn.ParameterName);
                            returnString = string.Format("return {0}.Get{1}By{2}({3});", repositoryName, rn.FKTable.NameHumanCase, pkMethodName, rn.PKColumn.ParameterName);
                        }
                        else if (rn.Relationship == Relationship.ManyToOne || rn.Relationship == Relationship.ManyToMany)
                        {
                            methodString = string.Format("public IEnumerable<{0}> Get{1}By{2}({3} {4})", rn.FKTable.NameHumanCase, Inflector.MakePlural(rn.FKTable.NameHumanCase), pkMethodName, rn.PKColumn.PropertyType, rn.PKColumn.ParameterName);
                            returnString = string.Format("return {0}.Get{1}By{2}({3});", repositoryName, Inflector.MakePlural(rn.FKTable.NameHumanCase), pkMethodName, rn.PKColumn.ParameterName);
                        }

                        WriteLine(methodString);
                        OpenMethodBrace();
                        WriteLine(returnString);
                        CloseMethodBrace();
                    }
                }

                CloseBrace();
                CloseBrace();
            }

            #endregion

            #region Service Interfaces

            foreach (Table tbl in from t in Tables.Where(t => !t.IsMapping && t.TableData.GenerateServiceInterface).OrderBy(x => x.NameHumanCase) select t)
            {
                StartNewFile("I" + tbl.NameHumanCase + "Service" + Setting.GeneratedFileExtension, ServiceInterfaceProjectName, ServiceInterfaceFolderName);

                CreateHeader();

                WriteLine("using System;");
                WriteLine("using System.Collections.Generic;");
                WriteLine("using {0};", PocoNamespace);
                WriteLine("");

                BeginNamespace(ServiceInterfaceNamespace);
                BeginInterface("I" + tbl.NameHumanCase + "Service", Setting.MakeInterfacesPartial, "");

                WriteLine("{0} Insert({0} data);", tbl.NameHumanCase);
                WriteLine("{0} Update({0} data);", tbl.NameHumanCase);
                WriteLine("void Delete(int id);");
                WriteLine("void Delete({0} data);", tbl.NameHumanCase);
                WriteLine("IEnumerable<{0}> GetAll();", tbl.NameHumanCase);

                if (tbl.HasPrimaryKey)
                {
                    foreach (Column pk in tbl.PrimaryKeys)
                    {
                        WriteLine("{0} FindBy{1}({2} {3});", tbl.NameHumanCase, pk.NameHumanCase, pk.PropertyType, pk.ParameterName);
                    }
                }

                foreach (ForeignKey fk in tbl.ForeignKeys)
                {
                    WriteLine("IEnumerable<{0}> FindBy{1}({2} {3});", tbl.NameHumanCase, fk.FKColumn.NameHumanCase, fk.FKColumn.PropertyType, fk.FKColumn.ParameterName);
                }

                foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == false).GroupBy(g => g.ColumnString).Select(s => s.First()))
                {
                    WriteLine("IEnumerable<{0}> GetBy{1}({2});", tbl.NameHumanCase, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), Index.CreateIndexParameterString(index));
                }

                foreach (Index index in tbl.Indexes.Where(x => x.IsPrimaryKey == false && x.IsUnique == true).GroupBy(g => g.ColumnString).Select(s => s.First()))
                {
                    WriteLine("{0} FindBy{1}({2});", tbl.NameHumanCase, string.Join(string.Empty, index.Columns.Select(s => s.NameHumanCase)), Index.CreateIndexParameterString(index));
                }

                if (!Setting.VirtualReverseNavigationProperties && tbl.ReverseNavigationProperties.Any())
                {
                    WriteLine("// Reverse Navigation Methods");

                    foreach (ReverseNavigation rn in tbl.ReverseNavigationProperties)
                    {
                        string methodString = string.Empty;
                        string pkMethodName = rn.PKColumn.ParentTable.NameHumanCase + rn.PKColumn.NameHumanCase != rn.PKColumn.NameHumanCase ? rn.PKColumn.ParentTable.NameHumanCase + rn.PKColumn.NameHumanCase : rn.PKColumn.NameHumanCase;

                        if (rn.Relationship == Relationship.OneToOne || rn.Relationship == Relationship.OneToMany)
                        {
                            methodString = string.Format("{0} Get{0}By{1}({2} {3});", rn.FKTable.NameHumanCase, pkMethodName, rn.PKColumn.PropertyType, rn.PKColumn.NameHumanCase);
                        }
                        else if (rn.Relationship == Relationship.ManyToOne || rn.Relationship == Relationship.ManyToMany)
                        {
                            methodString = string.Format("IEnumerable<{0}> Get{1}By{2}({3} {4});", rn.FKTable.NameHumanCase, Inflector.MakePlural(rn.FKTable.NameHumanCase), pkMethodName, rn.PKColumn.PropertyType, rn.PKColumn.NameHumanCase);
                        }

                        WriteLine(methodString);
                    }
                }

                CloseBrace();
                CloseBrace();
            }

            #endregion
        }

        private void CreateModelConfigurations()
        {
            #region POCO Configuration

            if (!Setting.UseDataAnnotations)
            {
                foreach (Table tbl in Tables.Where(t => !t.IsMapping && t.HasPrimaryKey && t.TableData.GeneratePoco).OrderBy(x => x.NameHumanCase))
                {
                    StartNewFile(tbl.NameHumanCase + Setting.ConfigurationClassName + Setting.FileExtension, ConfigurationProjectName, ConfigurationFolderName);

                    CreateHeader();

                    WriteLine("using System.Data.Entity.ModelConfiguration;");
                    WriteLine("using System.ComponentModel.DataAnnotations.Schema;");
                    WriteLine("using {0};", PocoNamespace);
                    WriteLine("");

                    BeginNamespace(PocoConfigurationNamespace);
                    BeginClass(tbl.NameHumanCase + Setting.ConfigurationClassName, Setting.MakeClassesPartial, string.Format("EntityTypeConfiguration<{0}>", tbl.NameHumanCase));

                    WriteLine("public {0}()", tbl.NameHumanCase + Setting.ConfigurationClassName);
                    WriteLine(": this( \"{0}\" )", string.IsNullOrEmpty(tbl.Schema) ? "" : tbl.Schema);
                    OpenMethodBrace();
                    CloseMethodBrace();

                    WriteLine("public {0}(string schema)", tbl.NameHumanCase + Setting.ConfigurationClassName);
                    OpenMethodBrace();
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

                    CloseMethodBrace();
                    CloseBrace();
                    CloseBrace();
                }
            }

            #endregion
        }

        private void CreateStoredProcedures()
        {

            if (StoredProcedures.Any() && Tables.Where(x => x.TableData.GeneratePoco).Count() > 0)
            {
                foreach (StoredProcedure sp in StoredProcedures.Where(x => x.ReturnModels.Count > 0 && x.ReturnModels.Any(returnColumns => returnColumns.Any()) && !StoredProcedure.StoredProcedureReturnTypes.ContainsKey(x.NameHumanCase) && !StoredProcedure.StoredProcedureReturnTypes.ContainsKey(x.Name)))
                {
                    string spReturnClassName = StoredProcedure.WriteStoredProcReturnModelName(sp);

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
                            WriteLine("{0}", StoredProcedure.WriteStoredProcReturnColumn(returnColumn));
                        }
                    }
                    else
                    {
                        int model = 0;
                        foreach (var returnModel in sp.ReturnModels)
                        {
                            model++;
                            WriteLine("public class ResultSetModel{0}", model);
                            OpenMethodBrace();

                            foreach (var returnColumn in returnModel)
                            {
                                WriteLine("{0}", StoredProcedure.WriteStoredProcReturnColumn(returnColumn));
                            }
                            CloseMethodBrace();

                            WriteLine("public List<ResultSetModel{0}> ResultSet{0};", model);

                        }
                    }
                    CloseBrace();
                }
            }
            
        }
    }
}

