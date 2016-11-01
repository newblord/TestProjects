using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Helpers
{
	public static class PropertyTypeHelper
	{
		public static readonly List<string> NotNullable = new List<string>
		  {
				"string",
				"byte[]",
				"datatable",
				"system.data.datatable",
				"object",
				"microsoft.sqlserver.types.sqlgeography",
				"microsoft.sqlserver.types.sqlgeometry",
				"system.data.entity.spatial.dbgeography",
				"system.data.entity.spatial.dbgeometry",
				"system.data.entity.hierarchy.hierarchyid"
		  };

		public static string GetSqlDbType(string sqlType, int scale, int precision)
		{
			string sysType = "VarChar";
			switch (sqlType)
			{
				case "hierarchyid":
					sysType = "VarChar";
					break;

				case "bigint":
					sysType = "BigInt";
					break;

				case "binary":
					sysType = "Binary";
					break;

				case "bit":
					sysType = "Bit";
					break;

				case "char":
					sysType = "Char";
					break;

				case "datetime":
					sysType = "DateTime";
					break;

				case "decimal":
					sysType = "Decimal";
					break;

				case "float":
					sysType = "Float";
					break;

				case "image":
					sysType = "Image";
					break;

				case "int":
					sysType = "Int";
					break;

				case "money":
					sysType = "Money";
					break;

				case "nchar":
					sysType = "NChar";
					break;

				case "ntext":
					sysType = "NText";
					break;

				case "nvarchar":
					sysType = "NVarChar";
					break;

				case "real":
					sysType = "Real";
					break;

				case "uniqueidentifier":
					sysType = "UniqueIdentifier";
					break;

				case "smalldatetime":
					sysType = "SmallDateTime";
					break;

				case "smallint":
					sysType = "SmallInt";
					break;

				case "smallmoney":
					sysType = "SmallMoney";
					break;

				case "text":
					sysType = "Text";
					break;

				case "timestamp":
					sysType = "Timestamp";
					break;

				case "tinyint":
					sysType = "TinyInt";
					break;

				case "varbinary":
					sysType = "VarBinary";
					break;

				case "varchar":
					sysType = "VarChar";
					break;

				case "variant":
					sysType = "Variant";
					break;

				case "xml":
					sysType = "Xml";
					break;

				case "udt":
					sysType = "Udt";
					break;

				case "table type":
				case "structured":
					sysType = "Structured";
					break;

				case "date":
					sysType = "Date";
					break;

				case "time":
					sysType = "Time";
					break;

				case "datetime2":
					sysType = "DateTime2";
					break;

				case "datetimeoffset":
					sysType = "DateTimeOffset";
					break;
			}
			return sysType;
		}

		public static string GetPropertyType(string sqlType, int scale, int precision)
		{
			string sysType = "string";
			switch (sqlType)
			{
				case "hierarchyid":
					sysType = "System.Data.Entity.Hierarchy.HierarchyId";
					break;
				case "bigint":
					sysType = "long";
					break;
				case "smallint":
					sysType = "short";
					break;
				case "int":
					sysType = "int";
					break;
				case "uniqueidentifier":
					sysType = "Guid";
					break;
				case "smalldatetime":
				case "datetime":
				case "datetime2":
				case "date":
					sysType = "DateTime";
					break;
				case "datetimeoffset":
					sysType = "DateTimeOffset";
					break;
				case "table type":
					sysType = "Data.DataTable";
					break;
				case "time":
					sysType = "TimeSpan";
					break;
				case "float":
					sysType = "double";
					break;
				case "real":
					sysType = "float";
					break;
				case "numeric":
				case "smallmoney":
				case "decimal":
				case "money":
					sysType = "decimal";
					break;
				case "tinyint":
					sysType = "byte";
					break;
				case "bit":
					sysType = "bool";
					break;
				case "image":
				case "binary":
				case "varbinary":
				case "varbinary(max)":
				case "timestamp":
					sysType = "byte[]";
					break;
				case "geography":
					if (Global.Setting.DisableGeographyTypes)
						sysType = "";
					else
						sysType = "System.Data.Entity.Spatial.DbGeography";
					break;
				case "geometry":
					if (Global.Setting.DisableGeographyTypes)
						sysType = "";
					else
						sysType = "System.Data.Entity.Spatial.DbGeometry";
					break;
			}
			return sysType;
		}
	}
}
