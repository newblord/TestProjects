using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseObjects
{
	public class TableData
	{
		public bool TableSelect { get; set; }
		public string TableName { get; set; }
		public bool GenerateModel { get; set; }
		public bool GenerateModelInterface { get; set; }
		public bool GenerateRepository { get; set; }
		public bool GenerateRepositoryInterface { get; set; }
		public bool GenerateService { get; set; }
		public bool GenerateServiceInterface { get; set; }
	}
}
