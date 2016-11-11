using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
	public class EnumDefinition
	{
		public string Schema { get; set; }
		public string Table { get; set; }
		public string Column { get; set; }
		public string EnumType { get; set; }
	}
}
