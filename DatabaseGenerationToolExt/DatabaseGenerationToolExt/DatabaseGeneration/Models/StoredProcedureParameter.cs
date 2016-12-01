using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
	public class StoredProcedureParameter : Base.Column
	{
		public StoredProcedureParameterMode Mode { get; set; }
		public int Precision { get; set; }
		public int Scale { get; set; }
	}
}
