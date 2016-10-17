using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public class DatabaseGenerationSetting
	{
		private string _databaseContextInterfaceName = null;

		public string ConnectionString { get; set; }
		public string DatabaseContextName { get; set; }
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
		public string ContextInterfaceBaseClass { get; set; }
		public string ContextBaseClass { get; set; }
		public bool MakeClassesPartial { get; set; }
		public bool MakeInterfacesPartial { get; set; }
		public bool MakeContextInterfacePartial { get; set; }
		public bool GenerateSeparateFiles { get; set; }
		public bool UseDataAnnotations { get; set; }
		public bool GenerateContextClass { get; set; }
		public bool GenerateUnitOfWorkInterface { get; set; }
		public bool UseCamelCase { get; set; }
		public bool DisableGeographyTypes { get; set; }
		public bool NullableShortHand { get; set; }
		public bool PrivateSetterForComputedColumns { get; set; }
		public string FileExtension { get; set; }
		public string GeneratedFileExtension { get; set; }
		public bool PrependSchemaName { get; set; }
		public string ConfigurationClassName { get; set; }
		public string CollectionType { get; set; }
		public CommentsStyle IncludeComments { get; set; }
		public bool IncludeQueryTraceOn9481Flag { get; set; }
	}
}
