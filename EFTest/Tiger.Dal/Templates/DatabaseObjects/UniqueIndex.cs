using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public class UniqueIndex
	{
		public string Schema;
		public string TableName;
		public string IndexName;
		public byte KeyOrdinal;
		public string Column;
		public int ColumnCount;
	}
}
