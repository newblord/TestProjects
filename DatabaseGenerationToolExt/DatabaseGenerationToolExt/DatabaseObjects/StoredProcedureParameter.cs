using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseObjects
{
	public class StoredProcedureParameter
	{
		public int Ordinal { get; set; }
		public StoredProcedureParameterMode Mode { get; set; }
		public string Name { get; set; }
		public string NameHumanCase { get; set; }
		public string SqlDbType { get; set; }
		public string PropertyType { get; set; }
		public string UserDefinedTypeName { get; set; }
		public int DateTimePrecision { get; set; }
		public int MaxLength { get; set; }
		public int Precision { get; set; }
		public int Scale { get; set; }
	}
}
