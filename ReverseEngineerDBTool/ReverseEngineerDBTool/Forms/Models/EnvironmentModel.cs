using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineerDBTool.Forms.Models
{
    public class EnvironmentModel
    {
        public string DatabaseName { get; set; }
        public string ServerName { get; set; }
        public string EnvironmentText { get { return $"{ServerName} - {DatabaseName}"; } }

        public string ConnectionString
        {
            get
            {
                var connectionString = new SqlConnectionStringBuilder()
                {
                    AsynchronousProcessing = true,
                    DataSource = ServerName,
                    InitialCatalog = DatabaseName,
                    IntegratedSecurity = true
                };

                return connectionString.ToString();
            }
        }
    }
}
