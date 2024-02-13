using ReverseEngineerDBTool.DatabaseGeneration.Settings;
using ReverseEngineerDBTool.Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineerDBTool.Helpers
{
    public static class Global
    {
        public static DatabaseGenerationSetting DatabaseSetting { get; set; } = new DatabaseGenerationSetting();

        public static ProjectSetting ProjectSetting { get; set; } = new ProjectSetting();

        public static List<TableData> SelectedTables { get; set; } = new List<TableData>();

        public static List<StoredProcedureData> SelectedStoredProcedures { get; set; } = new List<StoredProcedureData>();

        public static List<SpellFunctionData> SelectedEnums { get; set; } = new List<SpellFunctionData>();

        public static void ResetValues()
        {
            DatabaseSetting = new DatabaseGenerationSetting();
            ProjectSetting = new ProjectSetting();
            SelectedTables = new List<TableData>();
            SelectedStoredProcedures = new List<StoredProcedureData>();
            SelectedEnums = new List<SpellFunctionData>();
        }
    }
}
