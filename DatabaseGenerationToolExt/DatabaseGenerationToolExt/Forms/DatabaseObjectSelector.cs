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
using DatabaseGenerationToolExt.Templates;
using DatabaseGenerationToolExt.Helpers;

namespace DatabaseGenerationToolExt.Forms
{
    public partial class DatabaseObjectSelector : Form
	{
		public List<TableData> TableNames { get; set; }

		public List<string> StoredProcedureNames { get; set; }

		public DatabaseGenerationSetting Setting { get; set; }

		public DatabaseObjectSelector(Package package)
		{
            ConnectionStringSelector conForm = new ConnectionStringSelector(package);

            conForm.ShowDialog();

            if (conForm.SelectedConnection != null)
            {
                Setting = new DatabaseObjects.DatabaseGenerationSetting(conForm.SelectedConnection);
                TableNames = new List<TableData>();
                StoredProcedureNames = new List<string>();
                

                // TODO: Need to fix this method to use a differnet file instead of hte TemplateFile now
                //ReversePocoCore.ProcessDatabaseXML(Host.TemplateFile, ref TableNames, ref StoredProcedureNames, ref Setting);
            }
            else
            {
                conForm.Dispose();
                this.Close();
            }

            InitializeComponent();

			PopulateDropDownLists();
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
			if (Setting != null)
			{
				txtDbContextName.DataBindings.Add("Text", Setting, "DatabaseContextName");
				txtContextInterfaceBaseClass.DataBindings.Add("Text", Setting, "ContextInterfaceBaseClass");
				txtContextBaseClass.DataBindings.Add("Text", Setting, "ContextBaseClass");
				txtConfigurationClassName.DataBindings.Add("Text", Setting, "ConfigurationClassName");
				ddlIncludeComments.SelectedValue = (int)Setting.IncludeComments;

				cbxPartialClasses.DataBindings.Add("Checked", Setting, "MakeClassesPartial");
				cbxPartialInterfaces.DataBindings.Add("Checked", Setting, "MakeInterfacesPartial");
				cbxPartialContextInterface.DataBindings.Add("Checked", Setting, "MakeContextInterfacePartial");
				cbxGenerateSeparateFiles.DataBindings.Add("Checked", Setting, "GenerateSeparateFiles");
				cbxUseDataAnnotations.DataBindings.Add("Checked", Setting, "UseDataAnnotations");
				cbxGenerateContextClass.DataBindings.Add("Checked", Setting, "GenerateContextClass");
				cbxGenerateUnitOfWorkInterface.DataBindings.Add("Checked", Setting, "GenerateUnitOfWorkInterface");
				cbxVirtualReverseNavProperty.DataBindings.Add("Checked", Setting, "VirtualReverseNavigationProperties");
				cbxUseCamelCase.DataBindings.Add("Checked", Setting, "UseCamelCase");
				cbxDisableGeographyTypes.DataBindings.Add("Checked", Setting, "DisableGeographyTypes");
				cbxNullableShortHand.DataBindings.Add("Checked", Setting, "NullableShortHand");
				cbxPrivateSetterForComputedColumns.DataBindings.Add("Checked", Setting, "PrivateSetterForComputedColumns");
				cbxPrependSchema.DataBindings.Add("Checked", Setting, "PrependSchemaName");
				cbxIncludeQueryTraceOn.DataBindings.Add("Checked", Setting, "IncludeQueryTraceOn9481Flag");
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

			using (SqlConnection connection = new SqlConnection(Setting.ConnectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();

				command.CommandType = CommandType.Text;
				command.CommandText = sql;

				SqlDataReader reader = command.ExecuteReader();


				while (reader.Read())
				{
					TableData data = TableNames.Where(x => x.TableName == reader["Name"].ToString()).FirstOrDefault();

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

		private void UpdateFromDatabase_Load(object sender, EventArgs e)
		{
			SetupTableGridViewHeaderCheckbox();
			UpdateTableSettings();
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

			TableNames = tableData.Where(x => x.TableSelect == true).ToList();

			Setting.IncludeComments = (CommentsStyle)ddlIncludeComments.SelectedValue;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();
            // Read schema
            ReversePocoCore reversePocoCore = new ReversePocoCore(Setting);

            var factory = ConnectionHelper.GetDbProviderFactory(Setting.Providername);
            var tables = reversePocoCore.LoadTables(factory, TableNames);
            var storedProcs = reversePocoCore.LoadStoredProcs(factory, StoredProcedureNames);

            // Generate output
            if (tables.Count > 0 || storedProcs.Count > 0)
            {
                DesignPattern pattern = new DesignPattern("4.6.1", Setting);
            }

            sw.Stop();
            Logger.AddLog($"// Total Elapsed Time: {sw.Elapsed.TotalSeconds.ToString()}");

            this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			TableNames = new List<TableData>();
			StoredProcedureNames = new List<string>();

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
        }

		private void UpdateTableSettings()
		{
			List<TableData> tableData = (List<TableData>)gvTables.DataSource;

			if (tableData.Any())
			{
				if(!cbxPocos.Focused)
					cbxPocos.Checked = tableData.Where(x => x.GeneratePoco).Count() == tableData.Count;
				if (!cbxPocoInterfaces.Focused)
					cbxPocoInterfaces.Checked = tableData.Where(x => x.GeneratePocoInterface).Count() == tableData.Count;
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
						bool pocoValue = (bool)gvTables[2, e.RowIndex].FormattedValue;
						bool iPocoValue = (bool)gvTables[3, e.RowIndex].FormattedValue;
						bool repoValue = (bool)gvTables[4, e.RowIndex].FormattedValue;
						bool iRepoValue = (bool)gvTables[5, e.RowIndex].FormattedValue;
                        bool serviceValue = (bool)gvTables[6, e.RowIndex].FormattedValue;
                        bool iServiceValue = (bool)gvTables[7, e.RowIndex].FormattedValue;

                        if (pocoValue || iPocoValue || repoValue || iRepoValue || serviceValue || iServiceValue)
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

				cbxPocos.Checked = cbx.Checked;
				cbxPocoInterfaces.Checked = cbx.Checked;
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

		private void cbxPocos_CheckStateChanged(object sender, EventArgs e)
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

		private void cbxPocoInterfaces_CheckStateChanged(object sender, EventArgs e)
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

		private void cbxRepositories_CheckStateChanged(object sender, EventArgs e)
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

		private void cbxRepositoryInterfaces_CheckStateChanged(object sender, EventArgs e)
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

        private void cbxServices_CheckedChanged(object sender, EventArgs e)
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

        private void cbxServiceInterfaces_CheckedChanged(object sender, EventArgs e)
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

        #endregion

        #endregion

    }

}