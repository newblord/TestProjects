using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public class UniqueIndex
	{
		public string Schema { get; set; }
		public string TableName { get; set; }
		public string IndexName { get; set; }
		public byte KeyOrdinal { get; set; }
		public string Column { get; set; }
		public int ColumnCount { get; set; }
	}
}
