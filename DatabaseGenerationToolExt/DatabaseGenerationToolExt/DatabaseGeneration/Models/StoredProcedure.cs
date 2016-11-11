using DatabaseGenerationToolExt.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
	public class StoredProcedure
	{
		public string Schema { get; set; }
		public string Name { get; set; }
		public string NameHumanCase { get; set; }
		public Forms.Models.StoredProcedureData StoredProcData { get; set; }
		public List<StoredProcedureParameter> Parameters { get; set; }
		public List<List<DataColumn>> ReturnModels { get; set; }   // A list of return models, containing a list of return columns

		public StoredProcedure()
		{
			StoredProcData = new Forms.Models.StoredProcedureData();
			Parameters = new List<StoredProcedureParameter>();
			ReturnModels = new List<List<DataColumn>>();
		}
	}
}
