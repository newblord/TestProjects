using DatabaseGenerationToolExt.Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseGenerationToolExt.Forms
{
    public partial class EnvironmentSelector : Form
    {
        public EnvironmentModel SelectedEnvironment { get; set; }

        public EnvironmentSelector()
        {
            InitializeComponent();

            var envs = GetEnvironments();

            var selectedConfig = envs.Where(x => x.ConnectionString.Equals(Helpers.Global.DatabaseSetting.ConnectionString)).FirstOrDefault();

            envs.Insert(0, new EnvironmentModel());

            ddlEnvironment.DataSource = envs;
            ddlEnvironment.ValueMember = "EnvironmentText";
            ddlEnvironment.DisplayMember = "EnvironmentText";

            if (selectedConfig != null)
            {
                ddlEnvironment.SelectedItem = selectedConfig;
            }
        }

        private void EnvironmentSelector_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        private List<EnvironmentModel> GetEnvironments()
        {
            var envs = new List<EnvironmentModel>();

            var connectionString = new SqlConnectionStringBuilder()
            {
                AsynchronousProcessing = true,
                DataSource = "SRCMAINT",
                InitialCatalog = "MAINT",
                IntegratedSecurity = true
            };

            var connection = new SqlConnection(connectionString.ToString());

            connection.Open();

            var command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = @"SELECT cv.CONFIG_VALUE as DatabaseName, cu.SERVER_NAME as ServerName
                                    FROM[ConfigValue] cv
                                        JOIN ConfigSetting cs
                                             ON cv.CONFIG_SETTING_KEY = cs.CONFIG_SETTING_KEY

                                             and cs.CONFIG_SETTING_NAME = 'CuroDBName'

                                             join Config c
                                                on cv.CONFIG_KEY = c.CONFIG_KEY
                                                   inner join Servers cu on cu.SERVERS_KEY = c.CURO_DB_SERVER_KEY
                                    order by cu.SERVER_NAME, cs.CONFIG_SETTING_NAME";

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    EnvironmentModel env = new EnvironmentModel();

                    env.DatabaseName = reader["DatabaseName"].ToString();
                    env.ServerName = reader["ServerName"].ToString();

                    envs.Add(env);
                }
            }

            connection.Close();
            connection.Dispose();

            return envs;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (ddlEnvironment.SelectedIndex > 0)
            {
                List<EnvironmentModel> envs = (List<EnvironmentModel>)ddlEnvironment.DataSource;

                SelectedEnvironment = envs[ddlEnvironment.SelectedIndex];

                this.Close();
            }
            else
            {
                MessageBox.Show("Select an Environment.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedEnvironment = null;
            this.Close();
        }
    }
}
