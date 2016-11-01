using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Helpers
{
	public static class Global
	{
		public static DatabaseObjects.DatabaseGenerationSetting Setting { get; private set; } = new DatabaseObjects.DatabaseGenerationSetting();

		public static Microsoft.VisualStudio.Shell.Package Package { get; private set; }

		public static List<DatabaseObjects.TableData> SelectedTables { get; set; } = new List<DatabaseObjects.TableData>();

		public static List<string> SelectedStoredProcedures { get; set; } = new List<string>();

		public static void InitializePackage(Microsoft.VisualStudio.Shell.Package package)
		{
			Package = package;
		}

		public static void InitializeSetting(DatabaseObjects.DatabaseGenerationSetting setting)
		{
			Setting = setting;
		}

		public static void ResetValues()
		{
			Setting = new DatabaseObjects.DatabaseGenerationSetting();
			Package = null;
			SelectedTables = new List<DatabaseObjects.TableData>();
			SelectedStoredProcedures = new List<string>();
		}
	}
}
