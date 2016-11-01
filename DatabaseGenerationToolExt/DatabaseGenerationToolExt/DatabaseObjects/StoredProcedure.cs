using DatabaseGenerationToolExt.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseObjects
{
	public class StoredProcedure
	{
		public string Schema { get; set; }
		public string Name { get; set; }
		public string NameHumanCase { get; set; }
		public List<StoredProcedureParameter> Parameters { get; set; }
		public List<List<DataColumn>> ReturnModels { get; set; }   // A list of return models, containing a list of return columns

        public static Dictionary<string, string> StoredProcedureReturnTypes = new Dictionary<string, string>();

        public StoredProcedure()
		{
			Parameters = new List<StoredProcedureParameter>();
			ReturnModels = new List<List<DataColumn>>();
		}

		public static bool IsNullable(DataColumn col)
		{
			return col.AllowDBNull && !PropertyTypeHelper.NotNullable.Contains(col.DataType.Name.ToLower());
		}

		public static string WrapTypeIfNullable(string propertyType, DataColumn col)
		{
			if (!IsNullable(col))
				return propertyType;
			return String.Format(Global.Setting.NullableShortHand ? "{0}?" : "Nullable<{0}>", propertyType);
		}

        public static Func<StoredProcedure, string> WriteStoredProcFunctionName = sp => sp.NameHumanCase;

        /// <summary>
        /// StoredProcedure renaming ************************************************************************************************************
        /// Use the following function to rename stored procs such as sp_CreateOrderHistory to CreateOrderHistory, my_sp_shipments to Shipments, etc.
        /// Example:
        /// StoredProcedureRename = (name, schema) =>
		/// {
		///	    if (name.StartsWith("sp_"))
		///		    name = name.Remove(0, 3);
		///	    return name.Replace("my_sp_", "");
		/// };
        /// </summary>
        public static Func<string, string, string> StoredProcedureRename = (name, schema) => name;  // Do nothing by default

        public static Func<StoredProcedure, bool> StoredProcHasOutParams = (sp) =>
        {
            return sp.Parameters.Any(x => x.Mode != StoredProcedureParameterMode.In);
        };

        public static Func<StoredProcedure, bool, string> WriteStoredProcFunctionParams = (sp, includeProcResult) =>
        {
            var sb = new StringBuilder();
            int n = 1;
            int count = sp.Parameters.Count;
            foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
            {
                sb.AppendFormat("{0}{1}{2} {3}{4}",
                        p.Mode == StoredProcedureParameterMode.In ? "" : "out ",
                        p.PropertyType,
                        PropertyTypeHelper.NotNullable.Contains(p.PropertyType.ToLower()) ? string.Empty : "?",
                        p.NameHumanCase,
                        (n++ < count) ? ", " : string.Empty);
            }
            if (includeProcResult && sp.ReturnModels.Count > 0 && sp.ReturnModels.First().Count > 0)
                sb.AppendFormat((sp.Parameters.Count > 0 ? ", " : "") + "out int procResult");
            return sb.ToString();
        };

        public static Func<StoredProcedure, string> WriteStoredProcFunctionOverloadCall = (sp) =>
        {
            var sb = new StringBuilder();
            foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
            {
                sb.AppendFormat("{0}{1}, ",
                        p.Mode == StoredProcedureParameterMode.In ? "" : "out ",
                        p.NameHumanCase);
            }
            sb.Append("out procResult");
            return sb.ToString();
        };

        public static Func<StoredProcedure, string> WriteStoredProcFunctionSqlAtParams = sp =>
        {
            var sb = new StringBuilder();
            int n = 1;
            int count = sp.Parameters.Count;
            foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
            {
                sb.AppendFormat("{0}{1}{2}",
                        p.Name,
                        p.Mode == StoredProcedureParameterMode.In ? string.Empty : " OUTPUT",
                        (n++ < count) ? ", " : string.Empty);
            }
            return sb.ToString();
        };

        public static Func<StoredProcedureParameter, string> WriteStoredProcSqlParameterName = p => p.NameHumanCase + "Param";

        public static Func<StoredProcedure, bool, string> WriteStoredProcFunctionDeclareSqlParameter = (sp, includeProcResult) =>
        {
            var sb = new StringBuilder();
            foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
            {
                bool isNullable = !PropertyTypeHelper.NotNullable.Contains(p.PropertyType.ToLower());
                var getValueOrDefault = isNullable ? ".GetValueOrDefault()" : string.Empty;

                sb.AppendLine(string.Format("				var {0} = new System.Data.SqlClient.SqlParameter {{ ParameterName = \"{1}\", SqlDbType = System.Data.SqlDbType.{2}, Direction = System.Data.ParameterDirection.{3}{4}{5}{6}{7} }};",
                        WriteStoredProcSqlParameterName(p),
                        p.Name,
                        p.SqlDbType,
                        p.Mode == StoredProcedureParameterMode.In ? "Input" : "Output",
                        p.Mode == StoredProcedureParameterMode.In ? ", Value = " + p.NameHumanCase + getValueOrDefault : string.Empty,
                        p.MaxLength != 0 ? ", Size = " + p.MaxLength : string.Empty,
                        (p.Precision > 0 || p.Scale > 0) ? ", Precision = " + p.Precision + ", Scale = " + p.Scale : string.Empty,
                        p.PropertyType.ToLower().Contains("datatable") ? ", TypeName = \"" + p.UserDefinedTypeName + "\"" : string.Empty));

                if (p.Mode == StoredProcedureParameterMode.In)
                {
                    sb.AppendFormat(
                        isNullable
                                ? "				if (!{0}.HasValue){1}					 {0}Param.Value = System.DBNull.Value;{1}{1}"
                                : "				if ({0}Param.Value == null){1}					 {0}Param.Value = System.DBNull.Value;{1}{1}",
                        p.NameHumanCase, Environment.NewLine);
                }
            }
            if (includeProcResult && sp.ReturnModels.Count < 2)
                sb.AppendLine("				var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = \"@procResult\", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };");
            return sb.ToString();
        };

        public static Func<StoredProcedure, string> WriteTableValuedFunctionDeclareSqlParameter = sp =>
        {
            var sb = new StringBuilder();
            foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
            {
                sb.AppendLine(string.Format("				var {0}Param = new System.Data.Entity.Core.Objects.ObjectParameter(\"{1}\", typeof({2})) {{ Value = {3} }};",
                        p.NameHumanCase,
                        p.Name.Substring(1),
                        p.PropertyType,
                        p.NameHumanCase + (p.Mode == StoredProcedureParameterMode.In && PropertyTypeHelper.NotNullable.Contains(p.PropertyType.ToLowerInvariant()) ? string.Empty : ".GetValueOrDefault()")));
            }
            return sb.ToString();
        };

        public static Func<StoredProcedure, bool, string> WriteStoredProcFunctionSqlParameterAnonymousArray = (sp, includeProcResultParam) =>
        {
            var sb = new StringBuilder();
            bool hasParam = false;
            foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
            {
                sb.Append(string.Format("{0}Param, ", p.NameHumanCase));
                hasParam = true;
            }
            if (includeProcResultParam)
                sb.Append("procResultParam");
            else if (hasParam)
                sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        };

        public static Func<StoredProcedure, string> WriteTableValuedFunctionSqlParameterAnonymousArray = sp =>
        {
            if (sp.Parameters.Count == 0)
                return "new System.Data.Entity.Core.Objects.ObjectParameter[] { }";
            var sb = new StringBuilder();
            foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
            {
                sb.Append(string.Format("{0}Param, ", p.NameHumanCase));
            }
            return sb.ToString().Substring(0, sb.Length - 2);
        };

        public static Func<StoredProcedure, bool, string> WriteStoredProcFunctionSetSqlParameters = (sp, isFake) =>
        {
            var sb = new StringBuilder();
            foreach (var p in sp.Parameters.Where(x => x.Mode != StoredProcedureParameterMode.In).OrderBy(x => x.Ordinal))
            {
                string Default = string.Format("default({0})", p.PropertyType);
                bool notNullable = PropertyTypeHelper.NotNullable.Contains(p.PropertyType.ToLower());

                if (isFake)
                    sb.AppendLine(string.Format("				{0} = {1};", p.NameHumanCase, Default));
                else
                {
                    sb.AppendLine(string.Format("				if (IsSqlParameterNull({0}Param))", p.NameHumanCase));
                    sb.AppendLine(string.Format("					 {0} = {1};", p.NameHumanCase, notNullable ? Default : "null"));
                    sb.AppendLine("				else");
                    sb.AppendLine(string.Format("					 {0} = ({1}) {2}Param.Value;", p.NameHumanCase, p.PropertyType, p.NameHumanCase));
                }
            }
            return sb.ToString();
        };

        public static Func<StoredProcedure, string> WriteStoredProcReturnModelName = sp =>
            StoredProcedureReturnTypes.ContainsKey(sp.NameHumanCase)
                ? StoredProcedureReturnTypes[sp.NameHumanCase]
                : StoredProcedureReturnTypes.ContainsKey(sp.Name)
                        ? StoredProcedureReturnTypes[sp.Name]
                        : string.Format("{0}ReturnModel", sp.NameHumanCase);

        public static Func<DataColumn, string> WriteStoredProcReturnColumn = col =>
            string.Format("public {0} {1} {{ get; set; }}",
                StoredProcedure.WrapTypeIfNullable("System." + col.DataType.Name, col), col.ColumnName);

        public static Func<StoredProcedure, string> WriteStoredProcReturnType = (sp) =>
        {
            var returnModelCount = sp.ReturnModels.Count;
            if (returnModelCount == 0)
                return "int";

            var spReturnClassName = WriteStoredProcReturnModelName(sp);
            return (returnModelCount == 1) ? string.Format("System.Collections.Generic.List<{0}>", spReturnClassName) : spReturnClassName;
        };

    }
}
