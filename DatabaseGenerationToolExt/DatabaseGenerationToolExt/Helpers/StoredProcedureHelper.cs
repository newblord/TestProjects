using DatabaseGenerationToolExt.DatabaseGeneration.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Helpers
{
	public static class StoredProcedureHelper
	{
		public static Dictionary<string, string> StoredProcedureReturnTypes = new Dictionary<string, string>();

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

		public static string WriteStoredProcFunctionName(StoredProcedure sp)
		{
			return sp.NameHumanCase;
		}

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
		public static string StoredProcedureRename(string name, string schema)
		{
			return name;  // Do nothing by default
		}

		public static bool StoredProcHasOutParams(StoredProcedure sp)
		{
			return sp.Parameters.Any(x => x.Mode != StoredProcedureParameterMode.In);
		}

		public static string WriteStoredProcFunctionParams(StoredProcedure sp, bool includeProcResult)
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
		}

		public static string WriteStoredProcFunctionOverloadCall(StoredProcedure sp)
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
		}

		public static string WriteStoredProcFunctionSqlAtParams(StoredProcedure sp)
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
		}

		public static string WriteStoredProcSqlParameterName(StoredProcedureParameter p)
		{
			return p.NameHumanCase + "Param";
		}

		public static string WriteStoredProcFunctionDeclareSqlParameter(StoredProcedure sp, bool includeProcResult)
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
		}

		public static string WriteTableValuedFunctionDeclareSqlParameter(StoredProcedure sp)
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
		}

		public static string WriteStoredProcFunctionSqlParameterAnonymousArray(StoredProcedure sp, bool includeProcResultParam)
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
		}

		public static string WriteTableValuedFunctionSqlParameterAnonymousArray(StoredProcedure sp)
		{
			if (sp.Parameters.Count == 0)
				return "new System.Data.Entity.Core.Objects.ObjectParameter[] { }";
			var sb = new StringBuilder();
			foreach (var p in sp.Parameters.OrderBy(x => x.Ordinal))
			{
				sb.Append(string.Format("{0}Param, ", p.NameHumanCase));
			}
			return sb.ToString().Substring(0, sb.Length - 2);
		}

		public static string WriteStoredProcFunctionSetSqlParameters(StoredProcedure sp, bool isFake)
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
		}

		public static string WriteStoredProcReturnModelName(StoredProcedure sp)
		{
			return StoredProcedureReturnTypes.ContainsKey(sp.NameHumanCase) ?
							StoredProcedureReturnTypes[sp.NameHumanCase] : StoredProcedureReturnTypes.ContainsKey(sp.Name) ?
																								StoredProcedureReturnTypes[sp.Name] : string.Format("{0}ReturnModel", sp.NameHumanCase);
		}

		public static string WriteStoredProcReturnColumn(DataColumn col)
		{
			return $"public {WrapTypeIfNullable("System." + col.DataType.Name, col)} {col.ColumnName} {{ get; set; }}";
		}

		public static string WriteStoredProcReturnType(StoredProcedure sp)
		{
			var returnModelCount = sp.ReturnModels.Count;
			if (returnModelCount == 0)
				return "int";

			var spReturnClassName = WriteStoredProcReturnModelName(sp);
			return (returnModelCount == 1) ? $"System.Collections.Generic.List<{spReturnClassName}>" : spReturnClassName;
		}
	}
}
