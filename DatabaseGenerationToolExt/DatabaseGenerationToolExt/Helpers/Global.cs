using DatabaseGenerationToolExt.DatabaseGeneration.Settings;
using DatabaseGenerationToolExt.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Helpers
{
	public static class Global
	{
		public static DatabaseGenerationSetting Setting { get; private set; } = new DatabaseGenerationSetting();

		public static Microsoft.VisualStudio.Shell.Package Package { get; private set; }

		public static List<TableData> SelectedTables { get; set; } = new List<TableData>();

		public static List<StoredProcedureData> SelectedStoredProcedures { get; set; } = new List<StoredProcedureData>();

		public static List<EnumData> SelectedEnums { get; set; } = new List<EnumData>();

		public static void InitializePackage(Microsoft.VisualStudio.Shell.Package package)
		{
			Package = package;
		}

		public static void InitializeSetting(DatabaseGenerationSetting setting)
		{
			Setting = setting;
		}

		public static void ResetValues()
		{
			Setting = new DatabaseGenerationSetting();
			Package = null;
			SelectedTables = new List<TableData>();
			SelectedStoredProcedures = new List<StoredProcedureData>();
			SelectedEnums = new List<EnumData>();
		}
	}
}
