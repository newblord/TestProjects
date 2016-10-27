using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseObjects
{
    public class DatabaseGenerationSetting
    {
        public DatabaseGenerationSetting(DatabaseConnection connection)
        {
            ConnectionStringName = connection.ConnectionStringName;
            ConnectionString = connection.ConnectionString;
            Providername = connection.ProviderName;

            DatabaseContextName = "POCTest";
            ContextInterfaceBaseClass = "IDisposable";
            ContextBaseClass = "DbContext";
            MakeClassesPartial = true;
            MakeInterfacesPartial = true;
            MakeContextInterfacePartial = true;
            GenerateSeparateFiles = true;
            UseDataAnnotations = true;
            GenerateContextClass = true;
            GenerateUnitOfWorkInterface = true;
            VirtualReverseNavigationProperties = false;
            UseCamelCase = true;
            DisableGeographyTypes = false;
            NullableShortHand = true;
            PrivateSetterForComputedColumns = true;
            FileExtension = ".cs";
            GeneratedFileExtension = ".generated.cs";
            PrependSchemaName = true;
            ConfigurationClassName = "Configuration";
            IncludeComments = CommentsStyle.AtEndOfField;
            IncludeQueryTraceOn9481Flag = false;
        }

        private string _databaseContextInterfaceName = null;
        private string _defaultConstructorArgument = null;

        public string Providername { get; set; }
        public string ConnectionStringName { get; set; }
        public string ConnectionString { get; set; }
        string DefaultConstructorArgument {
            get
            {
                return _defaultConstructorArgument ?? $"\"Name={ConnectionStringName}\"";
            }
            set
            {
                _defaultConstructorArgument = value;
            }
        }
        
        public string DatabaseContextName { get; set; }
        /// <summary>
        /// Defaults to "I" + DatabaseContextName
        /// </summary>
        public string DatabaseContextInterfaceName
        {
            get
            {
                return _databaseContextInterfaceName ?? ("I" + DatabaseContextName);
            }
            set
            {
                _databaseContextInterfaceName = value;
            }
        }
        /// <summary>
        /// Specify what the base classes are for your database context interface
        /// </summary>
        public string ContextInterfaceBaseClass { get; set; }
        /// <summary>
        /// Specify what the base class is for your DbContext.  For ASP.NET Identity use "IdentityDbContext<ApplicationUser>"
        /// </summary>
        public string ContextBaseClass { get; set; }
        public bool MakeClassesPartial { get; set; }
        public bool MakeInterfacesPartial { get; set; }
        public bool MakeContextInterfacePartial { get; set; }
        public bool GenerateSeparateFiles { get; set; }
        /// <summary>
        /// True value generates DataAnnotations on Poco classes and False will generate FluentAPI Configuration
        /// </summary>
        public bool UseDataAnnotations { get; set; }
        public bool GenerateContextClass { get; set; }
        public bool GenerateUnitOfWorkInterface { get; set; }
        /// <summary>
        /// True value will generate Reverse Navigation properties and False will generate methods to retreive data
        /// </summary>
        public bool VirtualReverseNavigationProperties { get; set; }
        /// <summary>
        /// This will rename the tables & fields to use CamelCase. If false table & field names will be left alone.
        /// </summary>
        public bool UseCamelCase { get; set; }
        /// <summary>
        /// Turns off use of System.Data.Entity.Spatial.DbGeography and System.Data.Entity.Spatial.DbGeometry as OData doesn't support entities with geometry/geography types.
        /// </summary>
        public bool DisableGeographyTypes { get; set; }
        /// <summary>
        /// true => T?, false => Nullable<T>
        /// </summary>
        public bool NullableShortHand { get; set; }
        /// <summary>
        /// If the columns is computed, use a private setter.
        /// </summary>
        public bool PrivateSetterForComputedColumns { get; set; }
        /// <summary>
        /// File Extension used for context and Unit of Work files
        /// </summary>
        public string FileExtension { get; set; }
        /// <summary>
        /// File Extension used for TT generated files
        /// </summary>
        public string GeneratedFileExtension { get; set; }
        /// <summary>
        /// Control if the schema name is prepended to the table name
        /// </summary>
        public bool PrependSchemaName { get; set; }
        /// <summary>
        /// Configuration, Mapping, Map, etc. This is appended to the Poco class name to configure the mappings.
        /// </summary>
        public string ConfigurationClassName { get; set; }
        /// <summary>
        /// Adds comments to the generated code
        /// </summary>
        public CommentsStyle IncludeComments { get; set; }
        /// <summary>
        /// If SqlServer 2014 appears frozen / take a long time when this file is saved, try setting this to true (you will also need elevated privileges).
        /// </summary>
        public bool IncludeQueryTraceOn9481Flag { get; set; }
    }
}
