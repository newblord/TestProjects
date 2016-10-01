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

		private void LoadDatabaseGenerationSettings()
		{
			if(Setting != null)
			{
				txtDbContextName.Text = Setting.DatabaseContextName;
				txtContextInterfaceBaseClass.Text = Setting.ContextInterfaceBaseClass;
				txtContextBaseClass.Text = Setting.ContextBaseClass;

				cbxPartialClasses.Checked = Setting.MakeClassesPartial;
				cbxPartialInterfaces.Checked = Setting.MakeInterfacesPartial;
				cbxPartialContextInterface.Checked = Setting.MakeContextInterfacePartial;
				cbxGenerateSeparateFiles.Checked = Setting.GenerateSeparateFiles;
				cbxUseDataAnnotations.Checked = Setting.UseDataAnnotations;
				cbxUseCamelCase.Checked = Setting.UseCamelCase;
				cbxDisableGeographyTypes.Checked = Setting.DisableGeographyTypes;
				cbxNullableShortHand.Checked = Setting.NullableShortHand;
				cbxPrivateSetterForComputedColumns.Checked = Setting.PrivateSetterForComputerColumns;
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
		private void ToggleTableOptions(CheckState state, int rowIndex)
		{
			gvTables[2, rowIndex].Value = state == CheckState.Checked ? true : false;
			gvTables[3, rowIndex].Value = state == CheckState.Checked ? true : false;
			gvTables[4, rowIndex].Value = state == CheckState.Checked ? true : false;
			gvTables[5, rowIndex].Value = state == CheckState.Checked ? true : false;
		}
		#endregion

		#region Events
		private void gvTables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex > -1 && e.RowIndex > -1 && !SkipTableCellValueEvent)
			{
				if (e.ColumnIndex == 0)
				{
					CheckState isChecked = (CheckState)gvTables[0, e.RowIndex].FormattedValue;

					TableData row = (TableData)gvTables.Rows[e.RowIndex].DataBoundItem;

					CheckBox cbx = (CheckBox)gvTables.Controls.Find("TableSelectHeader", false).First();

					List<TableData> tableData = (List<TableData>)gvTables.DataSource;

					SkipTableHeaderCheckboxEvent = true;

					int checkedCount = tableData.Where(x => x.TableSelect == CheckState.Checked || x.TableSelect == CheckState.Indeterminate).Count();

					if (checkedCount > 0 && checkedCount < tableData.Count)
					{
						cbx.CheckState = CheckState.Indeterminate;
					}
					else if (checkedCount == tableData.Count)
					{
						cbx.CheckState = CheckState.Checked;
					}
					else
					{
						cbx.CheckState = CheckState.Unchecked;
					}

					if (cbx.CheckState == CheckState.Checked && isChecked == CheckState.Unchecked ||
							cbx.CheckState == CheckState.Unchecked && isChecked == CheckState.Checked ||
							cbx.CheckState == CheckState.Unchecked && isChecked == CheckState.Indeterminate)
					{
						cbx.CheckState = CheckState.Indeterminate;
					}
					else if (isChecked != CheckState.Indeterminate)
					{
						ToggleTableOptions(isChecked, e.RowIndex);
					}
					else if (isChecked == CheckState.Indeterminate)
					{
						SkipTableCellValueEvent = true;
						gvTables[0, e.RowIndex].Value = CheckState.Unchecked;
						ToggleTableOptions(CheckState.Unchecked, e.RowIndex);
						SkipTableCellValueEvent = false;
					}

					SkipTableHeaderCheckboxEvent = false;

					gvTables.EndEdit();
				}
				else if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5)
				{
					DataGridViewCheckBoxCell cbx = (DataGridViewCheckBoxCell)gvTables[0, e.RowIndex];
					bool pocoValue = (bool)gvTables[2, e.RowIndex].FormattedValue;
					bool iPocoValue = (bool)gvTables[3, e.RowIndex].FormattedValue;
					bool repoValue = (bool)gvTables[4, e.RowIndex].FormattedValue;
					bool iRepoValue = (bool)gvTables[5, e.RowIndex].FormattedValue;

					if (pocoValue && iPocoValue && repoValue && iRepoValue)
					{
						cbx.Value = CheckState.Checked;
					}
					else if (!pocoValue && !iPocoValue && !repoValue && !iRepoValue)
					{
						cbx.Value = CheckState.Unchecked;
					}
					else if (pocoValue || iPocoValue || repoValue || iRepoValue)
					{
						cbx.Value = CheckState.Indeterminate;
					}

					if (!pocoValue)
						cbxPocos.CheckState = CheckState.Unchecked;
					if (!iPocoValue)
						cbxPocoInterfaces.CheckState = CheckState.Unchecked;
					if (!repoValue)
						cbxRepositories.CheckState = CheckState.Unchecked;
					if (!iRepoValue)
						cbxRepositoryInterfaces.CheckState = CheckState.Unchecked;

					gvTables.EndEdit();
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

			if (!SkipTableHeaderCheckboxEvent)
			{
				CheckBox cbx = (CheckBox)sender;

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
					gvTables.Rows[i].Cells[0].Value = cbx.Checked == true ? CheckState.Checked : CheckState.Unchecked;
					ToggleTableOptions((CheckState)gvTables.Rows[i].Cells[0].Value, i);
				}

				SkipTableCellValueEvent = false;
			}
		}

		private void cbxPocos_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.CheckState == CheckState.Indeterminate)
			{
				cbx.CheckState = CheckState.Unchecked;
			}

			for (int i = 0; i < gvTables.Rows.Count; i++)
			{
				gvTables.Rows[i].Cells[2].Value = cbx.Checked == true ? true : false;
			}
		}

		private void cbxPocoInterfaces_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.CheckState == CheckState.Indeterminate)
			{
				cbx.CheckState = CheckState.Unchecked;
			}

			for (int i = 0; i < gvTables.Rows.Count; i++)
			{
				gvTables.Rows[i].Cells[3].Value = cbx.Checked == true ? true : false;
			}
		}

		private void cbxRepositories_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.CheckState == CheckState.Indeterminate)
			{
				cbx.CheckState = CheckState.Unchecked;
			}

			for (int i = 0; i < gvTables.Rows.Count; i++)
			{
				gvTables.Rows[i].Cells[4].Value = cbx.Checked == true ? true : false;
			}
		}

		private void cbxRepositoryInterfaces_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.CheckState == CheckState.Indeterminate)
			{
				cbx.CheckState = CheckState.Unchecked;
			}

			for (int i = 0; i < gvTables.Rows.Count; i++)
			{
				gvTables.Rows[i].Cells[5].Value = cbx.Checked == true ? true : false;
			}
		}
		#endregion

		#endregion
	}

	#region Helper Classes

	public class DatabaseGenerationSetting
	{
		public string DatabaseContextName { get; set; }
		public string ContextInterfaceBaseClass { get; set; }
		public string ContextBaseClass { get; set; }
		public bool MakeClassesPartial { get; set; }
		public bool MakeInterfacesPartial { get; set; }
		public bool MakeContextInterfacePartial { get; set; }
		public bool GenerateSeparateFiles { get; set; }
		public bool UseDataAnnotations { get; set; }
		public bool UseCamelCase { get; set; }
		public bool DisableGeographyTypes { get; set; }
		public bool NullableShortHand { get; set; }
		public bool PrivateSetterForComputerColumns { get; set; }
	}

	class TableData
	{
		public CheckState TableSelect { get; set; }
		public string TableName { get; set; }
		public bool GeneratePoco { get; set; }
		public bool GeneratePocoInterface { get; set; }
		public bool GenerateRepository { get; set; }
		public bool GenerateRepositoryInterface { get; set; }
	}

	#endregion
}