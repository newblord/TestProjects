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

		private bool SkipTableHeaderCheckboxEvent { get; set; }

		private bool SkipTableCellValueEvent { get; set; }

		public UpdateFromDatabase(string connectionStringName, List<string> tableNames, List<string> storedProcedureNames)
		{
			InitializeComponent();

			ConnectionString = connectionStringName;
			TableNames = tableNames;
			StoredProcedureNames = storedProcedureNames;

			InitializeDatabaseObjects();

		}

		#region Private Methods

		private void SetupTableGridViewHeaderCheckbox()
		{
			Rectangle rect = gvTables.GetCellDisplayRectangle(0, -1, true);
			rect.Y = rect.Height / 3;
			rect.X = rect.Location.X + (rect.Width / 3);
			CheckBox cbx = new CheckBox();
			cbx.Name = "TableSelectHeader";
			//datagridview[0, 0].ToolTipText = "sdfsdf";
			cbx.Size = new Size(18, 18);
			cbx.Location = rect.Location;
			cbx.BackColor = Color.Transparent;
			cbx.ThreeState = true;
			cbx.CheckStateChanged += new EventHandler(checkboxHeader_CheckStateChanged);
			gvTables.Controls.Add(cbx);
		}

		private void ToggleTableOptions(CheckState state, int rowIndex)
		{
			gvTables[2, rowIndex].Value = state == CheckState.Checked ? true : false;
			gvTables[3, rowIndex].Value = state == CheckState.Checked ? true : false;
			gvTables[4, rowIndex].Value = state == CheckState.Checked ? true : false;
			gvTables[5, rowIndex].Value = state == CheckState.Checked ? true : false;
		}

		private void InitializeDatabaseObjects()
		{
			InitializeDatabaseTables();
			//InitializeDatabaseViews();
			//InitializeDatabaseStoredProcedures();
			//InitializeDatabaseFunctions();
		}

		private void InitializeDatabaseTables()
		{
			string tables = string.Join("', '", TableNames);
			List<TableData> tableData = new List<TableData>();

			string sql = @"SELECT
								s.NAME        AS [Schema]
								, o.type_desc AS [Type]
								, o.NAME      AS [Name]
								, CAST(Case
									WHEN o.NAME IN ('{TABLE_NAMES}') THEN 1
									ELSE 0
									END AS BIT) AS Checked
							FROM   sys.all_objects o
										INNER JOIN sys.schemas s
												ON s.schema_id = o.schema_id
							WHERE
								o.type IN ('U') 
								AND s.NAME NOT IN ( 'sys', 'INFORMATION_SCHEMA' )
							ORDER  BY s.NAME,o.NAME 
							";

			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();

				command.CommandType = CommandType.Text;
				command.CommandText = sql.Replace("{TABLE_NAMES}", tables);

				SqlDataReader reader = command.ExecuteReader();


				while (reader.Read())
				{
					TableData data = new TableData();

					bool isChecked = bool.Parse(reader["Checked"].ToString());

					data.TableName = reader["Name"].ToString();
					data.TableSelect = isChecked == true ? CheckState.Checked : CheckState.Unchecked;

					tableData.Add(data);
				}

				connection.Close();
			}

			gvTables.DataSource = tableData;
		}

		//private void InitializeDatabaseViews()
		//{
		//	using (SqlConnection connection = new SqlConnection(ConnectionString))
		//	{
		//		connection.Open();
		//		SqlCommand command = connection.CreateCommand();

		//		command.CommandType = CommandType.Text;
		//		command.CommandText = @"SELECT
		//									  s.NAME        AS [Schema]
		//									  , o.type_desc AS [Type]
		//									  , o.NAME      AS [Name]
		//									FROM   sys.all_objects o
		//											 INNER JOIN sys.schemas s
		//														ON s.schema_id = o.schema_id
		//									WHERE
		//									  o.type IN ('V') 
		//									  AND s.NAME NOT IN ( 'sys', 'INFORMATION_SCHEMA' )
		//									ORDER  BY o.NAME 
		//									";

		//		SqlDataReader reader = command.ExecuteReader();

		//		TreeNode node = tvDBComponents.Nodes.Add("Views");

		//		while (reader.Read())
		//		{
		//			node.Nodes.Add(reader["Name"].ToString());
		//		}

		//		connection.Close();
		//	}
		//}

		//private void InitializeDatabaseStoredProcedures()
		//{
		//	string tables = string.Join("', '", TableNames);

		//	string sql = @"SELECT
		//									  s.NAME        AS [Schema]
		//									  , o.type_desc AS [Type]
		//									  , o.NAME      AS [Name]
		//									  , Case
		//											WHEN o.NAME IN ('{SPROC_NAMES}') THEN 1
		//											ELSE 0
		//											END AS Checked
		//									FROM   sys.all_objects o
		//											 INNER JOIN sys.schemas s
		//														ON s.schema_id = o.schema_id
		//									WHERE
		//									  o.type IN ('P') 
		//									  AND s.NAME NOT IN ( 'sys', 'INFORMATION_SCHEMA' )
		//									ORDER  BY o.type,o.NAME 
		//									";

		//	using (SqlConnection connection = new SqlConnection(ConnectionString))
		//	{
		//		connection.Open();
		//		SqlCommand command = connection.CreateCommand();

		//		command.CommandType = CommandType.Text;
		//		command.CommandText = sql.Replace("{SPROC_NAMES}", tables);

		//		SqlDataReader reader = command.ExecuteReader();

		//		TreeNode node = tvDBComponents.Nodes.Add("Stored Procedures");

		//		while (reader.Read())
		//		{
		//			TreeNode newNode = new TreeNode(reader["Name"].ToString());

		//			if (int.Parse(reader["Checked"].ToString()) == 1)
		//				newNode.Checked = true;

		//			node.Nodes.Add(newNode);
		//		}

		//		connection.Close();
		//	}
		//}

		//private void InitializeDatabaseFunctions()
		//{
		//	using (SqlConnection connection = new SqlConnection(ConnectionString))
		//	{
		//		connection.Open();
		//		SqlCommand command = connection.CreateCommand();

		//		command.CommandType = CommandType.Text;
		//		command.CommandText = @"SELECT
		//									  s.NAME        AS [Schema]
		//									  , o.type_desc AS [Type]
		//									  , o.NAME      AS [Name]
		//									FROM   sys.all_objects o
		//											 INNER JOIN sys.schemas s
		//														ON s.schema_id = o.schema_id
		//									WHERE
		//									  o.type IN ('FN', 'IF', 'TF') 
		//									  AND s.NAME NOT IN ( 'sys', 'INFORMATION_SCHEMA' )
		//									ORDER  BY o.type,o.NAME 
		//									";

		//		SqlDataReader reader = command.ExecuteReader();

		//		TreeNode node = tvDBComponents.Nodes.Add("Functions");

		//		while (reader.Read())
		//		{
		//			node.Nodes.Add(reader["Name"].ToString());
		//		}

		//		connection.Close();
		//	}
		//}

		#endregion

		#region Events

		private void UpdateFromDatabase_Load(object sender, EventArgs e)
		{
			SetupTableGridViewHeaderCheckbox();
		}

		public void checkboxHeader_CheckStateChanged(object sender, EventArgs e)
		{
			if (gvTables.IsCurrentCellInEditMode)
			{
				gvTables.EndEdit();
			}

			if (!SkipTableHeaderCheckboxEvent)
			{
				CheckBox cbx = (CheckBox)sender;

				if (cbx.CheckState == CheckState.Indeterminate)
				{
					cbx.CheckState = CheckState.Unchecked;
				}

				SkipTableCellValueEvent = true;

				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					gvTables.Rows[i].Cells[0].Value = cbx.Checked == true ? CheckState.Checked : CheckState.Unchecked;
					ToggleTableOptions((CheckState)gvTables.Rows[i].Cells[0].Value, i);
				}

				SkipTableCellValueEvent = false;
			}
		}

		#endregion

		private void gvTables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex > -1 && e.RowIndex > -1 && !SkipTableCellValueEvent)
			{
				if (e.ColumnIndex == 0)
				{
					CheckState isChecked = (CheckState)gvTables[0, e.RowIndex].FormattedValue;

					CheckBox cbx = (CheckBox)gvTables.Controls.Find("TableSelectHeader", false).First();
					
					List<TableData> tableData = (List<TableData>)gvTables.DataSource;

					SkipTableHeaderCheckboxEvent = true;

					if (cbx.CheckState == CheckState.Checked && isChecked == CheckState.Unchecked ||
							cbx.CheckState == CheckState.Unchecked && isChecked == CheckState.Checked)
					{
						cbx.CheckState = CheckState.Indeterminate;
					}

					int checkedCount = tableData.Where(x => x.TableSelect == CheckState.Checked).Count();

					cbx.CheckState = checkedCount > 0 ? CheckState.Checked : CheckState.Unchecked;

					if (checkedCount > 0 && checkedCount < tableData.Count)
					{
						cbx.CheckState = CheckState.Indeterminate;
					}

					if (isChecked != CheckState.Indeterminate)
					{
						ToggleTableOptions(isChecked, e.RowIndex);
					}

					SkipTableHeaderCheckboxEvent = false;

					gvTables.EndEdit();
				}
				else if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5)
				{
					DataGridViewCheckBoxCell cbx = (DataGridViewCheckBoxCell)gvTables[0, e.RowIndex];
					bool cbx1Value = (bool)gvTables[2, e.RowIndex].FormattedValue;
					bool cbx2Value = (bool)gvTables[3, e.RowIndex].FormattedValue;
					bool cbx3Value = (bool)gvTables[4, e.RowIndex].FormattedValue;
					bool cbx4Value = (bool)gvTables[5, e.RowIndex].FormattedValue;

					if (cbx1Value && cbx2Value && cbx3Value && cbx4Value)
					{
						cbx.Value = CheckState.Checked;
					}
					else if (!cbx1Value && !cbx2Value && !cbx3Value && !cbx4Value)
					{
						cbx.Value = CheckState.Unchecked;
					}
					else if (cbx1Value || cbx2Value || cbx3Value || cbx4Value)
					{
						cbx.Value = CheckState.Indeterminate;
					}

					gvTables.EndEdit();
				}
			}
		}

		private void gvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			gvTables.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}

		private void tcDatabaseObjects_Selected(object sender, TabControlEventArgs e)
		{
			//TabPage tp = e.TabPage;

			//int totalWidth = 0;

			//if (tp.Text == "Views")
			//{
			//	foreach (DataGridViewColumn c in gvViews.Columns)
			//	{
			//		totalWidth += c.Width;
			//	}

			//	this.Width = totalWidth;
			//}
		}
	}

	#region Helper Classes

	class TableData
	{
		public TableData() { }

		public CheckState TableSelect { get; set; }
		public string TableName { get; set; }
		public bool GeneratePoco { get; set; }
		public bool GeneratePocoInterface { get; set; }
		public bool GenerateRepository { get; set; }
		public bool GenerateRepositoryInterface { get; set; }
	}

	#endregion
}