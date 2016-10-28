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
        public EntityFrameworkDesignPattern(string targetFrameworkVersion, DatabaseGenerationSetting setting, Package package) : base(targetFrameworkVersion, setting, package)
        {
        }

        public string ConfigurationFolderName { get; set; }
        public string ConfigurationProjectName { get; set; }
        public string ContextFolderName { get; set; }
        public string ContextProjectName { get; set; }
        public string ModelFolderName { get; set; }
        public string ModelInterfaceFolderName { get; set; }
        public string ModelInterfaceProjectName { get; set; }
        public string ModelProjectName { get; set; }
        public string PocoConfigurationNamespace { get; set; }
        public string RepositoryFolderName { get; set; }
        public string RepositoryInterfaceFolderName { get; set; }
        public string RepositoryInterfaceProjectName { get; set; }
        public string RepositoryProjectName { get; set; }
        public string ServiceFolderName { get; set; }
        public string ServiceInterfaceFolderName { get; set; }
        public string ServiceInterfaceProjectName { get; set; }
        public string ServiceProjectName { get; set; }

        public string ContextNamespace { get; set; } = "Context";
        public string PocoInterfaceNamespace { get; set; } = "Poco.Interface";
        public string PocoNamespace { get; set; } = "Poco";
        public string RepositoryInterfaceNamespace { get; set; } = "Repository.Interface";
        public string RepositoryNamespace { get; set; } = "Repository";
        public string ServiceInterfaceNamespace { get; set; } = "Service.Interface";
        public string ServiceNamespace { get; set; } = "Service";
        public string UnitOfWorkNamespace { get; set; } = "Context.UnitOfWork";

        public void CreateFiles(Tables tables)
        {

            foreach (Table tbl in from t in tables.Where(t => !t.IsMapping && t.TableData.GeneratePocoInterface).OrderBy(x => x.NameHumanCase) select t)
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

            EndFile();
            ProcessFiles();
        }
    }
}

