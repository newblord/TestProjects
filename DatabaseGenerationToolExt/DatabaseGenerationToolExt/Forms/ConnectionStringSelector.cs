using DatabaseGenerationToolExt.DatabaseObjects;
using DatabaseGenerationToolExt.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseGenerationToolExt.Forms
{
    public partial class ConnectionStringSelector : Form
    {
        public DatabaseConnection SelectedConnection { get; set; }
        public string ConnectionStringName { get; private set; }

        public ConnectionStringSelector(Microsoft.VisualStudio.Shell.Package package)
        {
            InitializeComponent();

            ConnectionHelper.Initialize(package);
            List<DatabaseConnection> connections = ConnectionHelper.FindAllConnectionStrings();

            if (connections.Count > 0)
            {
                cbConnections.DataSource = connections;
                cbConnections.DisplayMember = "ConnectionStringName";
                cbConnections.ValueMember = "ConnectionString";

                cbConnections.Items.Insert(0, new DatabaseConnection());
            }
            else
            {
                MessageBox.Show("No Connection Strings were found in solution");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cbConnections.SelectedIndex > 0)
            {
                List<DatabaseConnection> connections = (List<DatabaseConnection>)cbConnections.DataSource;

                SelectedConnection = connections[cbConnections.SelectedIndex];

                this.Close();
            }
            else
            {
                MessageBox.Show("Select a connection string name");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedConnection = null;
            this.Close();
        }
    }
}
