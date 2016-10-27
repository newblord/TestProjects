using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseObjects
{
	public class Index
	{
		public string SchemaName { get; set; }
		public string IndexName { get; set; }
		public string TableName { get; set; }
		public bool IsUnique { get; set; }
		public bool IsPrimaryKey { get; set; }
		public string ColumnString { get; set; }
		public List<Column> Columns { get; set; }

		public Index()
		{
			Columns = new List<Column>();
		}
	}
}
