using DatabaseGenerationToolExt.DatabaseGeneration.Models;
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

		public ConnectionStringSelector()
		{
			InitializeComponent();

			List<DatabaseConnection> connections = ConnectionHelper.FindAllConnectionStrings();

			if (connections.Count > 0)
			{
				DatabaseConnection value = connections.Where(x => x.ConnectionStringName == Global.DatabaseSetting.ConnectionStringName).FirstOrDefault();

				connections.Insert(0, new DatabaseConnection());

				cbConnections.DataSource = connections;
				cbConnections.DisplayMember = "ConnectionStringName";
				cbConnections.ValueMember = "ConnectionStringName";

				if (value != null)
				{
					cbConnections.SelectedValue = value.ConnectionStringName;
				}
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
