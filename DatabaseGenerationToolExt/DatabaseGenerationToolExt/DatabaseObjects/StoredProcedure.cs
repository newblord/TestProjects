using DatabaseGenerationToolExt.Templates;
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
