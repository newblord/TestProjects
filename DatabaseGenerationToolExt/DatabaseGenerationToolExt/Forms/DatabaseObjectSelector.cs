using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DatabaseGenerationToolExt.DatabaseObjects;
using Microsoft.VisualStudio.Shell;
using DatabaseGenerationToolExt.DesignPatterns;
using DatabaseGenerationToolExt.Helpers;
using System.Data.Common;

namespace DatabaseGenerationToolExt.Forms
{
	public partial class DatabaseObjectSelector : Form
	{


		public bool IsCanceled { get; set; } = false;

		public DatabaseObjectSelector()
		{
			InitializeComponent();

			DesignPattern.ProcessDatabaseXML();

			using (ConnectionStringSelector conForm = new ConnectionStringSelector())
			{
				conForm.ShowDialog();

				if (conForm.SelectedConnection != null)
				{
					Logger.ResetLogs();

					Global.Setting.ConnectionStringName = conForm.SelectedConnection.ConnectionStringName;
					Global.Setting.ConnectionString = conForm.SelectedConnection.ConnectionString;
					Global.Setting.ProviderName = conForm.SelectedConnection.ProviderName;

					PopulateDropDownLists();
					InitializeDatabaseObjects();
					LoadDatabaseGenerationSettings();
				}
				else
				{
					conForm.Dispose();
					Global.ResetValues();
					IsCanceled = true;
				}
			}
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

			HandleTableSelectHeaderChange(cbx);

			cbx.CheckStateChanged += new EventHandler(checkboxHeader_CheckStateChanged);
			gvTables.Controls.Add(cbx);
		}

		private void PopulateDropDownLists()
		{
			List<EnumValue> values = new List<EnumValue>();

			values.Add(new EnumValue { Name = "None", Value = 0 });
			values.Add(new EnumValue { Name = "In Summary Block", Value = 1 });
			values.Add(new EnumValue { Name = "End of Field", Value = 2 });
			ddlIncludeComments.DataSource = values;
			ddlIncludeComments.DisplayMember = "Name";
			ddlIncludeComments.ValueMember = "Value";
		}

		private void LoadDatabaseGenerationSettings()
		{
			DatabaseGenerationSetting setting = Global.Setting;

			if (setting != null)
			{
				txtDbContextName.DataBindings.Add("Text", setting, "DatabaseContextName");
				txtContextInterfaceBaseClass.DataBindings.Add("Text", setting, "ContextInterfaceBaseClass");
				txtContextBaseClass.DataBindings.Add("Text", setting, "ContextBaseClass");
				txtConfigurationClassName.DataBindings.Add("Text", setting, "ConfigurationClassName");
				ddlIncludeComments.SelectedValue = (int)setting.IncludeComments;

				cbxPartialClasses.DataBindings.Add("Checked", setting, "MakeClassesPartial");
				cbxPartialInterfaces.DataBindings.Add("Checked", setting, "MakeInterfacesPartial");
				cbxPartialContextInterface.DataBindings.Add("Checked", setting, "MakeContextInterfacePartial");
				cbxUseDataAnnotations.DataBindings.Add("Checked", setting, "UseDataAnnotations");
				cbxGenerateContextClass.DataBindings.Add("Checked", setting, "GenerateContextClass");
				cbxGenerateUnitOfWorkInterface.DataBindings.Add("Checked", setting, "GenerateUnitOfWorkInterface");
				cbxVirtualReverseNavProperty.DataBindings.Add("Checked", setting, "VirtualReverseNavigationProperties");
				cbxUseCamelCase.DataBindings.Add("Checked", setting, "UseCamelCase");
				cbxDisableGeographyTypes.DataBindings.Add("Checked", setting, "DisableGeographyTypes");
				cbxNullableShortHand.DataBindings.Add("Checked", setting, "NullableShortHand");
				cbxPrependSchema.DataBindings.Add("Checked", setting, "PrependSchemaName");
				cbxIncludeQueryTraceOn.DataBindings.Add("Checked", setting, "IncludeQueryTraceOn9481Flag");
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
			List<TableData> tableData = new List<TableData>();

			string sql = @"SELECT
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

			using (SqlConnection connection = new SqlConnection(Global.Setting.ConnectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();

				command.CommandType = CommandType.Text;
				command.CommandText = sql;

				SqlDataReader reader = command.ExecuteReader();


				while (reader.Read())
				{
					TableData data = Global.SelectedTables.Where(x => x.TableName == reader["Name"].ToString()).FirstOrDefault();

					if (data == null)
					{
						data = new TableData();

						data.TableName = reader["Name"].ToString();
						data.TableSelect = false;
					}

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

		private void DatabaseObjectSelector_Load(object sender, EventArgs e)
		{
			SetupTableGridViewHeaderCheckbox();
			UpdateTableSettings();
		}

		private void DatabaseObjectSelector_FormClosing(object sender, FormClosingEventArgs e)
		{
			Global.ResetValues();
		}

		private void tcDatabaseObjects_Selected(object sender, TabControlEventArgs e)
		{
			TabPage tp = e.TabPage;

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

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			List<TableData> tableData = (List<TableData>)gvTables.DataSource;

			Global.SelectedTables = tableData.Where(x => x.TableSelect == true).ToList();

			Global.Setting.IncludeComments = (CommentsStyle)ddlIncludeComments.SelectedValue;

			// Read schema

			SchemaReader reader = new SchemaReader();

			var tables = reader.LoadTables();
			var storedProcs = reader.LoadStoredProcs();

			// Generate output
			if (tables.Count > 0 || storedProcs.Count > 0)
			{
				DesignPattern designPattern = new EntityFrameworkDesignPattern("4.61", tables, storedProcs);
				designPattern.CreateFiles();
			}

			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region Tab - Tables

		private bool SkipTableCellValueEvent { get; set; }

		#region Private Methods

		private void ToggleTableFileOptions(bool isChecked, int rowIndex)
		{
			gvTables[2, rowIndex].Value = isChecked;
			gvTables[3, rowIndex].Value = isChecked;
			gvTables[4, rowIndex].Value = isChecked;
			gvTables[5, rowIndex].Value = isChecked;
			gvTables[6, rowIndex].Value = isChecked;
			gvTables[7, rowIndex].Value = isChecked;
			gvTables[8, rowIndex].Value = isChecked;
		}

		private void UpdateTableSettings()
		{
			List<TableData> tableData = (List<TableData>)gvTables.DataSource;

			if (tableData.Any())
			{
				if (!cbxModelInterfaces.Focused)
					cbxModelInterfaces.Checked = tableData.Where(x => x.GenerateModelInterface).Count() == tableData.Count;
				if (!cbxModelDtos.Focused)
					cbxModelDtos.Checked = tableData.Where(x => x.GenerateModelDto).Count() == tableData.Count;
				if (!cbxSpecifications.Focused)
					cbxSpecifications.Checked = tableData.Where(x => x.GenerateSpecification).Count() == tableData.Count;
				if (!cbxRepositories.Focused)
					cbxRepositories.Checked = tableData.Where(x => x.GenerateRepository).Count() == tableData.Count;
				if (!cbxRepositoryInterfaces.Focused)
					cbxRepositoryInterfaces.Checked = tableData.Where(x => x.GenerateRepositoryInterface).Count() == tableData.Count;
				if (!cbxServices.Focused)
					cbxServices.Checked = tableData.Where(x => x.GenerateService).Count() == tableData.Count;
				if (!cbxServiceInterfaces.Focused)
					cbxServiceInterfaces.Checked = tableData.Where(x => x.GenerateServiceInterface).Count() == tableData.Count;
			}
		}

		private void HandleTableSelectChange(bool isChecked)
		{
			CheckBox cbxHeader = (CheckBox)gvTables.Controls.Find("TableSelectHeader", false).First();

			HandleTableSelectHeaderChange(cbxHeader);

			if (cbxHeader.CheckState == CheckState.Checked && !isChecked ||
					cbxHeader.CheckState == CheckState.Unchecked && isChecked)
			{
				cbxHeader.CheckState = CheckState.Indeterminate;
			}
		}

		private void HandleTableSelectHeaderChange(CheckBox cbx)
		{
			List<TableData> tableData = (List<TableData>)gvTables.DataSource;

			int checkedCount = tableData.Where(x => x.TableSelect == true).Count();

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

						SkipTableCellValueEvent = true;

						HandleTableSelectChange(isChecked);
						ToggleTableFileOptions(isChecked, e.RowIndex);
						UpdateTableSettings();

						SkipTableCellValueEvent = false;

						gvTables.EndEdit();
					}
					else if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5)
					{
						SkipTableCellValueEvent = true;

						DataGridViewCheckBoxCell cbxSelect = (DataGridViewCheckBoxCell)gvTables[0, e.RowIndex];
						bool iModelValue = (bool)gvTables[2, e.RowIndex].FormattedValue;
						bool modelDtoValue = (bool)gvTables[3, e.RowIndex].FormattedValue;
						bool specValue = (bool)gvTables[4, e.RowIndex].FormattedValue;
						bool repoValue = (bool)gvTables[5, e.RowIndex].FormattedValue;
						bool iRepoValue = (bool)gvTables[6, e.RowIndex].FormattedValue;
						bool serviceValue = (bool)gvTables[7, e.RowIndex].FormattedValue;
						bool iServiceValue = (bool)gvTables[8, e.RowIndex].FormattedValue;

						if (iModelValue || modelDtoValue || specValue || repoValue || iRepoValue || serviceValue || iServiceValue)
						{
							cbxSelect.Value = true;
							HandleTableSelectChange(true);
						}
						else
						{
							cbxSelect.Value = false;
							HandleTableSelectChange(false);
						}

						UpdateTableSettings();

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

				cbxModelInterfaces.Checked = cbx.Checked;
				cbxModelDtos.Checked = cbx.Checked;
				cbxSpecifications.Checked = cbx.Checked;
				cbxRepositories.Checked = cbx.Checked;
				cbxRepositoryInterfaces.Checked = cbx.Checked;
				cbxServices.Checked = cbx.Checked;
				cbxServiceInterfaces.Checked = cbx.Checked;

				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					gvTables.Rows[i].Cells[0].Value = cbx.Checked;
					ToggleTableFileOptions((bool)gvTables.Rows[i].Cells[0].Value, i);
				}
				SkipTableCellValueEvent = false;
			}
		}

		private void cbxModelInterfaces_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[2]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[2].Value = cbx.Checked;
				}
			}
		}

		private void cbxModelDtos_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[3]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[3].Value = cbx.Checked;
				}
			}
		}

		private void cbxSpecifications_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[4]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[4].Value = cbx.Checked;
				}
			}
		}

		private void cbxRepositories_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[5]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[5].Value = cbx.Checked;
				}
			}
		}

		private void cbxRepositoryInterfaces_CheckStateChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[6]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[6].Value = cbx.Checked;
				}
			}
		}

		private void cbxServices_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[7]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[7].Value = cbx.Checked;
				}
			}
		}

		private void cbxServiceInterfaces_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox cbx = (CheckBox)sender;

			if (cbx.Focused)
			{
				for (int i = 0; i < gvTables.Rows.Count; i++)
				{
					((DataGridViewCheckBoxCell)gvTables.Rows[i].Cells[8]).EditingCellValueChanged = true;
					gvTables.Rows[i].Cells[8].Value = cbx.Checked;
				}
			}
		}

		#endregion

		#endregion
		
	}

}