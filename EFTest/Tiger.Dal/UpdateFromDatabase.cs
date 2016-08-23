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

namespace Tiger.Dal
{
	public partial class UpdateFromDatabase : Form
	{

		private string ConnectionString { get; set; }

		public List<string> TableNames { get; set; }

		public List<string> StoredProcedureNames { get; set; }

		public UpdateFromDatabase(string connectionStringName)
		{
			InitializeComponent();

			TableNames = new List<string>();
			StoredProcedureNames = new List<string>();

			ConnectionString = connectionStringName;

			InitializeDatabaseTreeview();
		}

		private void InitializeDatabaseTreeview()
		{
			InitializeDatabaseTables();
			InitializeDatabaseViews();
			InitializeDatabaseStoredProcedures();
			InitializeDatabaseFunctions();
		}

		private void InitializeDatabaseTables()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();

				command.CommandType = CommandType.Text;
				command.CommandText = @"SELECT
											  s.NAME        AS [Schema]
											  , o.type_desc AS [Type]
											  , o.NAME      AS [Name]
											FROM   sys.all_objects o
													 INNER JOIN sys.schemas s
																ON s.schema_id = o.schema_id
											WHERE
											  o.type IN ('U') 
											  AND s.NAME NOT IN ( 'sys', 'INFORMATION_SCHEMA' )
											ORDER  BY s.NAME,o.NAME 
											";

				SqlDataReader reader = command.ExecuteReader();

				TreeNode node = tvDBComponents.Nodes.Add("Tables");

				while (reader.Read())
				{
					node.Nodes.Add(reader["Name"].ToString());
				}

				connection.Close();
			}
		}

		private void InitializeDatabaseViews()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();

				command.CommandType = CommandType.Text;
				command.CommandText = @"SELECT
											  s.NAME        AS [Schema]
											  , o.type_desc AS [Type]
											  , o.NAME      AS [Name]
											FROM   sys.all_objects o
													 INNER JOIN sys.schemas s
																ON s.schema_id = o.schema_id
											WHERE
											  o.type IN ('V') 
											  AND s.NAME NOT IN ( 'sys', 'INFORMATION_SCHEMA' )
											ORDER  BY o.NAME 
											";

				SqlDataReader reader = command.ExecuteReader();

				TreeNode node = tvDBComponents.Nodes.Add("Views");

				while (reader.Read())
				{
					node.Nodes.Add(reader["Name"].ToString());
				}

				connection.Close();
			}
		}

		private void InitializeDatabaseStoredProcedures()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();

				command.CommandType = CommandType.Text;
				command.CommandText = @"SELECT
											  s.NAME        AS [Schema]
											  , o.type_desc AS [Type]
											  , o.NAME      AS [Name]
											FROM   sys.all_objects o
													 INNER JOIN sys.schemas s
																ON s.schema_id = o.schema_id
											WHERE
											  o.type IN ('P') 
											  AND s.NAME NOT IN ( 'sys', 'INFORMATION_SCHEMA' )
											ORDER  BY o.type,o.NAME 
											";

				SqlDataReader reader = command.ExecuteReader();

				TreeNode node = tvDBComponents.Nodes.Add("Stored Procedures");

				while (reader.Read())
				{
					node.Nodes.Add(reader["Name"].ToString());
				}

				connection.Close();
			}
		}

		private void InitializeDatabaseFunctions()
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();

				command.CommandType = CommandType.Text;
				command.CommandText = @"SELECT
											  s.NAME        AS [Schema]
											  , o.type_desc AS [Type]
											  , o.NAME      AS [Name]
											FROM   sys.all_objects o
													 INNER JOIN sys.schemas s
																ON s.schema_id = o.schema_id
											WHERE
											  o.type IN ('FN', 'IF', 'TF') 
											  AND s.NAME NOT IN ( 'sys', 'INFORMATION_SCHEMA' )
											ORDER  BY o.type,o.NAME 
											";

				SqlDataReader reader = command.ExecuteReader();

				TreeNode node = tvDBComponents.Nodes.Add("Functions");

				while (reader.Read())
				{
					node.Nodes.Add(reader["Name"].ToString());
				}

				connection.Close();
			}
		}

		private void tvDBComponents_AfterCheck(object sender, TreeViewEventArgs e)
		{
			SetChildrenChecked(e.Node, e.Node.Checked);
		}

		private void SetChildrenChecked(TreeNode treeNode, bool checkedState)
		{
			foreach (TreeNode item in treeNode.Nodes)
			{
				if (item.Checked != checkedState)
				{
					item.Checked = checkedState;
				}
			}
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			foreach (TreeNode mainNode in tvDBComponents.Nodes)
			{
				if(mainNode.Text == "Tables")
				{
					foreach(TreeNode node in mainNode.Nodes)
					{
						if (node.Checked == true)
							TableNames.Add(node.Text);
					}
				}
				if(mainNode.Text == "Stored Procedures")
				{
					foreach (TreeNode node in mainNode.Nodes)
					{
						if (node.Checked == true)
							StoredProcedureNames.Add(node.Text);
					}
				}
			}

			this.Close();
		}
	}
}
