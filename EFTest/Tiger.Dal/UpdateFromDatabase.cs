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
using Tiger.Dal.Templates.DatabaseObjects;

namespace Tiger.Dal
{
	public partial class UpdateFromDatabase : Form
	{

		private string ConnectionStringName { get; set; }

		public List<string> TableNames { get; set; }

		public List<string> StoredProcedureNames { get; set; }

		public DatabaseGenerationSetting Setting { get; set; }

		public UpdateFromDatabase(string connectionStringName, List<string> tableNames, List<string> storedProcedureNames, DatabaseGenerationSetting setting)
		{
			InitializeComponent();

			ConnectionStringName = connectionStringName;
			TableNames = tableNames;
			StoredProcedureNames = storedProcedureNames;
			this.Setting = setting;

			InitializeDatabaseObjects();
			LoadDatabaseGenerationSettings();
		}

		#region Private Methods

		private void SetupTableGridViewHeaderCheckbox()
		{
			Rectangle rect = gvTables.GetCellDisplayRectangle(0, -1, true);
			rect.Size = new Size(20, 40);
			rect.Y = rect.Height / 4;
			rect.X = rect.Location.X + (rect.Width / 4);
			CheckBox cbx = new CheckBox();
			cbx.Name = "TableSelectHeader";
			cbx.Size = new Size(18, 18);
			cbx.Location = rect.Location;
			cbx.BackColor = Color.Transparent;
			cbx.ThreeState = true;
			cbx.CheckStateChanged += new EventHandler(checkboxHeader_CheckStateChanged);
			gvTables.Controls.Add(cbx);
		}

		private void LoadDatabaseGenerationSettings()
		{
			if (Setting != null)
			{
				txtDbContextName.DataBindings.Add("Text", Setting, "DatabaseContextName");
				txtContextInterfaceBaseClass.DataBindings.Add("Text", Setting, "ContextInterfaceBaseClass");
				txtContextBaseClass.DataBindings.Add("Text", Setting, "ContextBaseClass");

				cbxPartialClasses.DataBindings.Add("Checked", Setting, "MakeClassesPartial");
				cbxPartialInterfaces.DataBindings.Add("Checked", Setting, "MakeInterfacesPartial");
				cbxPartialContextInterface.DataBindings.Add("Checked", Setting, "MakeContextInterfacePartial");
				cbxGenerateSeparateFiles.DataBindings.Add("Checked", Setting, "GenerateSeparateFiles");
				cbxUseDataAnnotations.DataBindings.Add("Checked", Setting, "UseDataAnnotations");
				cbxUseCamelCase.DataBindings.Add("Checked", Setting, "UseCamelCase");
				cbxDisableGeographyTypes.DataBindings.Add("Checked", Setting, "DisableGeographyTypes");
				cbxNullableShortHand.DataBindings.Add("Checked", Setting, "NullableShortHand");
				cbxPrivateSetterForComputedColumns.DataBindings.Add("Checked", Setting, "PrivateSetterForComputerColumns");
			}
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

			using (SqlConnection connection = new SqlConnection(ConnectionStringName))
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
					data.TableSelect = isChecked;

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

		#endregion

		#region Tab - Tables

		private bool SkipTableHeaderCheckboxEvent { get; set; }

		private bool SkipTableCellValueEvent { get; set; }

		#region Private Methods
		private void ToggleTableFileOptions(bool state, int rowIndex)
		{
			gvTables[2, rowIndex].Value = state;
			gvTables[3, rowIndex].Value = state;
			gvTables[4, rowIndex].Value = state;
			gvTables[5, rowIndex].Value = state;
		}

		private void HandleTableSelectChange(bool isChecked)
		{
			CheckBox cbxHeader = (CheckBox)gvTables.Controls.Find("TableSelectHeader", false).First();

			List<TableData> tableData = (List<TableData>)gvTables.DataSource;

			int checkedCount = tableData.Where(x => x.TableSelect == true).Count();

			if (checkedCount > 0 && checkedCount < tableData.Count)
			{
				cbxHeader.CheckState = CheckState.Indeterminate;
			}
			else if (checkedCount == tableData.Count)
			{
				cbxHeader.CheckState = CheckState.Checked;
			}
			else
			{
				cbxHeader.CheckState = CheckState.Unchecked;
			}

			if (cbxHeader.CheckState == CheckState.Checked && !isChecked ||
					cbxHeader.CheckState == CheckState.Unchecked && isChecked)
			{
				cbxHeader.CheckState = CheckState.Indeterminate;
			}
		}
		
		#endregion

		#region Events
		private void gvTables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex > -1 && e.RowIndex > -1 && !SkipTableCellValueEvent)
			{
				DataGridViewCheckBoxCell cbx = (DataGridViewCheckBoxCell)gvTables[e.ColumnIndex, e.RowIndex];

				if (cbx.EditingCellValueChanged)
				{
					if (e.ColumnIndex == 0)
					{
						bool isChecked = (bool)gvTables[0, e.RowIndex].FormattedValue;

						HandleTableSelectChange(isChecked);

						ToggleTableFileOptions(isChecked, e.RowIndex);

						gvTables.EndEdit();
					}
					else if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5)
					{
						SkipTableCellValueEvent = true;

						DataGridViewCheckBoxCell cbxSelect = (DataGridViewCheckBoxCell)gvTables[0, e.RowIndex];
						bool pocoValue = (bool)gvTables[2, e.RowIndex].FormattedValue;
						bool iPocoValue = (bool)gvTables[3, e.RowIndex].FormattedValue;
						bool repoValue = (bool)gvTables[4, e.RowIndex].FormattedValue;
						bool iRepoValue = (bool)gvTables[5, e.RowIndex].FormattedValue;

						if (pocoValue || iPocoValue || repoValue || iRepoValue)
						{
							cbxSelect.Value = true;
							HandleTableSelectChange(true);
						}
						else
						{
							cbxSelect.Value = false;
							HandleTableSelectChange(false);
						}

						if (!pocoValue)
							cbxPocos.Checked = false;
						if (!iPocoValue)
							cbxPocoInterfaces.Checked = false;
						if (!repoValue)
							cbxRepositories.Checked = false;
						if (!iRepoValue)
							cbxRepositoryInterfaces.Checked = false;

						SkipTableCellValueEvent = false;

						gvTables.EndEdit();
					}
				}
			}
		}

		private void gvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			gvTables.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}

		public void checkboxHeader_CheckStateChanged(object sender, EventArgs e)
		{
			if (gvTables.IsCurrentCellInEditMode)
			{
				gvTables.EndEdit();
			}

			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				if (cbx.CheckState == CheckState.Indeterminate)
				{
					cbx.CheckState = CheckState.Unchecked;
				}

				SkipTableCellValueEvent = true;

				cbxPocos.Checked = cbx.Checked;
				cbxPocoInterfaces.Checked = cbx.Checked;
				cbxRepositories.Checked = cbx.Checked;
				cbxRepositoryInterfaces.Checked = cbx.Checked;

				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					gvTables.Rows[i].Cells[0].Value = cbx.Checked;
					ToggleTableFileOptions((bool)gvTables.Rows[i].Cells[0].Value, i);
				}
				SkipTableCellValueEvent = false;
			}
		}

		private void cbxPocos_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				if (cbx.CheckState == CheckState.Indeterminate)
				{
					cbx.CheckState = CheckState.Unchecked;
				}

				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[2]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[2].Value = cbx.Checked;
				}
			}
		}

		private void cbxPocoInterfaces_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				if (cbx.CheckState == CheckState.Indeterminate)
				{
					cbx.CheckState = CheckState.Unchecked;
				}

				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[3]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[3].Value = cbx.Checked;
				}
			}
		}

		private void cbxRepositories_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				if (cbx.CheckState == CheckState.Indeterminate)
				{
					cbx.CheckState = CheckState.Unchecked;
				}

				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[4]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[4].Value = cbx.Checked;
				}
			}
		}

		private void cbxRepositoryInterfaces_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				if (cbx.CheckState == CheckState.Indeterminate)
				{
					cbx.CheckState = CheckState.Unchecked;
				}

				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[5]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[5].Value = cbx.Checked;
				}
			}
		}
		#endregion

		#endregion

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			List<TableData> tableData = (List<TableData>)gvTables.DataSource;

			TableNames = tableData.Where(x => x.TableSelect == true).Select(x => x.TableName).ToList();

			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			TableNames = new List<string>();
			StoredProcedureNames = new List<string>();

			this.Close();
		}
	}

	#region Helper Classes

	class TableData
	{
		public bool TableSelect { get; set; }
		public string TableName { get; set; }
		public bool GeneratePoco { get; set; }
		public bool GeneratePocoInterface { get; set; }
		public bool GenerateRepository { get; set; }
		public bool GenerateRepositoryInterface { get; set; }
	}

	#endregion
}