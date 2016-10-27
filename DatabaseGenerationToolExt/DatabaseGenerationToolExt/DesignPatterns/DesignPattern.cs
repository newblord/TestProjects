using System.Globalization;
using DatabaseGenerationToolExt.DatabaseObjects;
using System;
using System.Text;
using System.Collections.Generic;

namespace DatabaseGenerationToolExt.DesignPatterns
{
    public class DesignPattern
    {
        private static string TargetFrameworkVersion;

        private DatabaseGenerationSetting Setting { get; set; }

        public DesignPattern(string targetFrameworkVersion, DatabaseGenerationSetting setting)
        {
            TargetFrameworkVersion = targetFrameworkVersion;
            Setting = setting;
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

        private bool IsSupportedFrameworkVersion(string frameworkVersion)
        {
            if (!string.IsNullOrEmpty(TargetFrameworkVersion))
            {
                var nfi = CultureInfo.InvariantCulture.NumberFormat;
                float target = float.Parse(TargetFrameworkVersion, nfi);
                float isSupported = float.Parse(frameworkVersion, nfi);
                return isSupported <= target;
            }
            return true;
        }

        private string WritePocoClassAttributes(Table t)
        {
            // Do nothing by default
            // Example:
            // if(t.ClassName.StartsWith("Order"))
            //	  WriteLine("	 [SomeAttribute]");

            if (Setting.UseDataAnnotations)
            {
                return $"[Table(\"{t.Name}\", Schema = \"{t.Schema}\")]";
            }

            return string.Empty;
        }

        // Writes optional base classes
        private string WritePocoBaseClasses(Table t)
        {
            //if (t.ClassName == "User")
            //	 return "IdentityUser<int, CustomUserLogin, CustomUserRole, CustomUserClaim>, ";
            return "";
        }

        // Writes any boilerplate stuff
        private string WritePocoBaseClassBody(Table t)
        {
            // Do nothing by default
            // Example:
            // WriteLine("		  // " + t.ClassName);

            return string.Empty;
        }

        private string WritePocoColumn(Column c)
        {
            // Example of adding a [Required] data annotation attribute to all non-null fields
            //if (!c.IsNullable)
            //	 return "[System.ComponentModel.DataAnnotations.Required] " + c.Entity;

            StringBuilder sb = new StringBuilder();

            if (Setting.UseDataAnnotations)
            {
                if (c.IsIdentity)
                    sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Identity)]");
                if (c.IsComputed)
                    sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.Computed)]");
                if (c.IsPrimaryKey && !c.IsIdentity && !c.IsStoreGenerated)
                    sb.AppendLine("[DatabaseGenerated(DatabaseGeneratedOption.None)]");

                if (c.IsPrimaryKey)
                    sb.AppendLine("[Key]");
                if (!c.IsNullable)
                    sb.AppendLine("[Required]");
                if (!c.IsMaxLength && c.MaxLength > 0)
                {
                    sb.AppendLine(string.Format("[MaxLength({0})]", c.MaxLength));
                    if (c.PropertyType.Equals("string", StringComparison.InvariantCultureIgnoreCase))
                        sb.AppendLine(string.Format("[StringLength({0})]", c.MaxLength));
                }
                if (c.IsMaxLength)
                    sb.AppendLine("[MaxLength]");

                sb.AppendLine(string.Format("[Column(\"{0}\", TypeName=\"{1}\")]"
                                , c.Name
                                , c.SqlPropertyType
                            //,c.IsPrimaryKey ? string.Format(", Order = {0}", c.PrimaryKeyOrdinal) : ""
                            ));
            }

            sb.AppendLine(c.Entity);

            return sb.ToString();
        }

        private string WritePocoInterfaceColumn(Column c)
        {
            // Example of adding a [Required] data annotation attribute to all non-null fields
            //if (!c.IsNullable)
            //	 return "[System.ComponentModel.DataAnnotations.Required] " + c.Entity;

            return c.InterfaceEntity;
        }

        private void CreateHeader()
        {
            WriteLine("//------------------------------------------------------------------------------");
            WriteLine("// <auto-generated>");
            WriteLine("//	  This code was generated from a template.");
            WriteLine("//");
            WriteLine("//	  Manual changes to this file may cause unexpected behavior in your application.");
            WriteLine("//	  Manual changes to this file will be overwritten if the code is regenerated.");
            WriteLine("// </auto-generated>");
            WriteLine("//------------------------------------------------------------------------------");
            WriteLine("");
        }

        private void BeginNamespace(string name)
        {
            WriteLine("namespace {0}", name);
            WriteLine("{");
            PushIndent("\t");
        }

        private void BeginInterface(string name, bool isPartial, string baseClass)
        {
            WriteLine("public {0}interface {1}{2}", isPartial ? "partial " : "", name, !string.IsNullOrEmpty(baseClass) ? " : " + baseClass : "");
            WriteLine("{");
            PushIndent("\t");
        }

        private void BeginClass(string name, bool isPartial, string baseClass)
        {
            WriteLine("public {0}class {1}{2}", isPartial ? "partial " : "", name, !string.IsNullOrEmpty(baseClass) ? " : " + baseClass : "");
            WriteLine("{");
            PushIndent("\t");
        }

        private void CloseBrace()
        {
            PopIndent();
            WriteLine("}");
        }

        private void OpenMethodBrace()
        {
            WriteLine("{");
            PushIndent("\t");
        }

        private void CloseMethodBrace()
        {
            PopIndent();
            WriteLine("}");
            WriteLine("");
        }

        public void CreateFiles(Tables tables, List<string> storedProcedures)
        {

        }
    }
}
