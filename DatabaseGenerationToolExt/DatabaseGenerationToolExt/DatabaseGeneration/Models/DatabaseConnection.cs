using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
	public class DatabaseConnection
	{
		public string ConnectionStringName { get; set; }
		public string ConnectionString { get; set; }
		public string ProviderName { get; set; }
		public string ConfigFilePath { get; set; }
	}
}
