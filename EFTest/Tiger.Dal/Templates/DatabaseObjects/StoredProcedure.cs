using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public class StoredProcedure
	{
		public string Schema;
		public string Name;
		public string NameHumanCase;
		public List<StoredProcedureParameter> Parameters;
		public List<List<DataColumn>> ReturnModels;   // A list of return models, containing a list of return columns

		public StoredProcedure()
		{
			Parameters = new List<StoredProcedureParameter>();
			ReturnModels = new List<List<DataColumn>>();
		}

		public static bool IsNullable(DataColumn col)
		{
			return col.AllowDBNull && !ReversePocoCore.NotNullable.Contains(col.DataType.Name.ToLower());
		}

		public static string WrapTypeIfNullable(string propertyType, DataColumn col)
		{
			if (!IsNullable(col))
				return propertyType;
			return String.Format(ReversePocoCore.Setting.NullableShortHand ? "{0}?" : "Nullable<{0}>", propertyType);
		}
		
	}
}
