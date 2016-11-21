using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
	public class Tables : List<Table>
	{
		public Table GetTable(string tableName, string schema)
		{
			return this.SingleOrDefault(x =>
				String.Compare(x.Name, tableName, StringComparison.OrdinalIgnoreCase) == 0 &&
				String.Compare(x.Schema, schema, StringComparison.OrdinalIgnoreCase) == 0);
		}

		public void SetupConfig()
		{
			foreach (var tbl in this)
			{
				tbl.SetupConfig();
				tbl.SetPrimaryKeys();
			}
		}

		public void ResetNavigationProperties()
		{
			foreach (var tbl in this)
			{
				tbl.ResetNavigationProperties();
			}
		}
	}
}
