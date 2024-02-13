using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DatabaseGenerationToolExt.Forms.Models;
using DatabaseGenerationToolExt.DesignPatterns;
using DatabaseGenerationToolExt.Helpers;
using DatabaseGenerationToolExt.DatabaseGeneration.Models;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Forms
{
    public partial class DatabaseObjectSelector : Form
    {

        public DatabaseObjectSelector()
        {
            InitializeComponent();

            List<SpellFunctionData> enumDatas = new List<SpellFunctionData>();

            enumDatas.Add(new SpellFunctionData() { FunctionName = string.Empty, FunctionSelect = false, FunctionRawText = string.Empty });

            bsSelectedEnums.DataSource = enumDatas;

            gvTables.AutoGenerateColumns = false;
            gvStoredProcedures.AutoGenerateColumns = false;
            gvSelectedTable.AutoGenerateColumns = false;
            gvSpellFunctions.AutoGenerateColumns = false;
        }

        private void ShowLoader(string message)
        {
            lblLoaderMessage.Text = message;
            pnlLoader.BringToFront();
            pnlLoader.Visible = true;
        }

        private void HideLoader()
        {
            pnlLoader.Invoke(new Action(() => pnlLoader.Visible = false));
            pnlLoader.Invoke(new Action(() => pnlLoader.SendToBack()));
        }

        private Task RunTask(string message, Action action)
        {
            ShowLoader(message);

            Task task = Task.Run(action);

            return task;
        }

        #region Events

        private void Combobox_SelectionChangesCommitted(Object sender, EventArgs e)
        {
            ((ComboBox)sender).DataBindings["SelectedValue"].WriteValue();
        }

        private void DatabaseObjectSelector_Load(object sender, EventArgs e)
        {

        }

        private async void DatabaseObjectSelector_Shown(object sender, EventArgs e)
        {
            Task settingTask = RunTask("Configuring Settings", () =>
            {
                Logger.ResetLogs();
                DesignPattern.ProcessDatabaseXML();
            });
            await settingTask;

            Task envTask = RunTask("Loading Environment Selector", () =>
            {

                using (EnvironmentSelector conForm = new EnvironmentSelector())
                {
                    conForm.ShowDialog();

                    if (conForm.SelectedEnvironment != null)
                    {
                        Global.DatabaseSetting.ConnectionString = conForm.SelectedEnvironment.ConnectionString;
                    }
                    else
                    {
                        conForm.Dispose();
                        Global.ResetValues();
                        Environment.Exit(0);
                    }
                }
            });
            await envTask;

            Task schemaTask = RunTask("Processing Database Schema", () =>
            {
                DatabaseGeneration.SchemaReader reader = new DatabaseGeneration.SchemaReader();

                var tables = reader.LoadTables(true);

                InitializeDatabaseTables(tables);
                InitializeDatabaseStoredProcedures();
                InitializeDatabaseSpellFunctions();
            });
            await schemaTask;

            SetupTableGridViewHeaderCheckbox();
            SetupStoredProcedureGridViewHeaderCheckbox();
            SetupEnumGridViewHeaderCheckbox();
            UpdateTableSettings();

            HideLoader();
        }

        private void DatabaseObjectSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.ResetValues();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (Settings frm = new Settings())
            {
                frm.ShowDialog();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<TableData> tableData = (List<TableData>)bsTables.DataSource;
            List<StoredProcedureData> sprocData = (List<StoredProcedureData>)gvStoredProcedures.DataSource;
            List<SpellFunctionData> enumData = (List<SpellFunctionData>)gvSpellFunctions.DataSource;
            List<TableData> selectedTables = tableData.Where(x => x.TableSelect).ToList();

            Global.SelectedTables = selectedTables;
            Global.SelectedStoredProcedures = sprocData.Where(x => x.StoredProcSelect).ToList();
            Global.SelectedEnums = enumData.Where(x => x.FunctionSelect).ToList();

            if (tableData.Where(x => x.TableSelect).Count() == 0)
            {
                MessageBox.Show("Select a table to generate.");
                return;
            }
            if (string.IsNullOrEmpty(Global.ProjectSetting.ContextProjectName))
            {
                MessageBox.Show("Select a Project for Context in Settings.");
                return;
            }
            if (enumData.Where(x => x.FunctionSelect).Count() > 0 && string.IsNullOrEmpty(Global.ProjectSetting.EnumProjectName))
            {
                MessageBox.Show("Select a Project for Enum in Settings.");
                return;
            }
            if (Global.DatabaseSetting.UseDataAnnotations == false && string.IsNullOrEmpty(Global.ProjectSetting.ConfigurationProjectName))
            {
                MessageBox.Show("Select a Project for Configuration in Settings.");
                return;
            }
            if (string.IsNullOrEmpty(Global.ProjectSetting.ModelProjectName))
            {
                MessageBox.Show("Select a Project for Model in Settings.");
                return;
            }
            if (tableData.Where(x => x.GenerateModelInterface).Count() > 0 && string.IsNullOrEmpty(Global.ProjectSetting.ModelInterfaceProjectName))
            {
                MessageBox.Show("Select a Project for Model Interface in Settings.");
                return;
            }
            if (tableData.Where(x => x.GenerateModelDto).Count() > 0 && string.IsNullOrEmpty(Global.ProjectSetting.ModelDtoProjectName))
            {
                MessageBox.Show("Select a Project for Model DTO in Settings.");
                return;
            }
            if (tableData.Where(x => x.GenerateSpecification).Count() > 0 && string.IsNullOrEmpty(Global.ProjectSetting.SpecificationProjectName))
            {
                MessageBox.Show("Select a Project for Specification in Settings.");
                return;
            }
            if (tableData.Where(x => x.GenerateRepository).Count() > 0 && string.IsNullOrEmpty(Global.ProjectSetting.RepositoryProjectName))
            {
                MessageBox.Show("Select a Project for Repository in Settings.");
                return;
            }
            if (tableData.Where(x => x.GenerateRepositoryInterface).Count() > 0 && string.IsNullOrEmpty(Global.ProjectSetting.RepositoryInterfaceProjectName))
            {
                MessageBox.Show("Select a Project for Repository Interface in Settings.");
                return;
            }
            if (tableData.Where(x => x.GenerateService).Count() > 0 && string.IsNullOrEmpty(Global.ProjectSetting.ServiceProjectName))
            {
                MessageBox.Show("Select a Project for Service in Settings.");
                return;
            }
            if (tableData.Where(x => x.GenerateServiceInterface).Count() > 0 && string.IsNullOrEmpty(Global.ProjectSetting.ServiceInterfaceProjectName))
            {
                MessageBox.Show("Select a Project for Service Interface in Settings.");
                return;
            }
            
            // Read schema
            DatabaseGeneration.SchemaReader reader = new DatabaseGeneration.SchemaReader();

            var tables = reader.LoadTables(false);
            var storedProcs = reader.LoadStoredProcs();
            var enums = reader.LoadEnums();
            
            try
            {
                // Generate output
                DesignPattern designPattern = new EntityFrameworkDesignPattern(tables, storedProcs, enums);
                designPattern.CreateFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

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

            cbx.CheckStateChanged += new EventHandler(TableCheckboxHeader_CheckStateChanged);
            gvTables.Controls.Add(cbx);
        }

        private void SetupStoredProcedureGridViewHeaderCheckbox()
        {
            Rectangle rect = gvStoredProcedures.GetCellDisplayRectangle(0, -1, true);
            rect.Size = new Size(20, 40);
            rect.Y = rect.Height / 4;
            rect.X = rect.Location.X + (rect.Width / 4);
            CheckBox cbx = new CheckBox();
            cbx.Name = "StoredProcSelectHeader";
            cbx.Size = new Size(18, 18);
            cbx.Location = rect.Location;
            cbx.BackColor = Color.Transparent;
            cbx.ThreeState = true;

            HandleStoredProcSelectHeaderChange(cbx);

            cbx.CheckStateChanged += new EventHandler(StoredProcCheckboxHeader_CheckStateChanged);
            gvStoredProcedures.Controls.Add(cbx);
        }

        private void SetupEnumGridViewHeaderCheckbox()
        {
            Rectangle rect = gvSpellFunctions.GetCellDisplayRectangle(0, -1, true);
            rect.Size = new Size(20, 40);
            rect.Y = rect.Height / 4;
            rect.X = rect.Location.X + (rect.Width / 4);
            CheckBox cbx = new CheckBox();
            cbx.Name = "FunctionSelectHeader";
            cbx.Size = new Size(18, 18);
            cbx.Location = rect.Location;
            cbx.BackColor = Color.Transparent;
            cbx.ThreeState = true;

            HandleFunctionSelectHeaderChange(cbx);

            cbx.CheckStateChanged += new EventHandler(FunctionCheckboxHeader_CheckStateChanged);
            gvSpellFunctions.Controls.Add(cbx);
        }

        private void InitializeDatabaseTables(DatabaseGeneration.Models.Tables tables)
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

            using (SqlConnection connection = new SqlConnection(Global.DatabaseSetting.ConnectionString))
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

                    var table = tables.Where(x => x.Name == data.TableName).FirstOrDefault();

                    if (table != null)
                    {
                        data.Columns.AddRange(table.Columns.Select(x => new NameValueModel(x.NameHumanCase, string.Empty)));
                    }

                    tableData.Add(data);
                }

                connection.Close();
            }

            bsTables.DataSource = tableData;

            gvTables.Invoke(new Action(() => gvTables.DataSource = bsTables));
        }

        private void InitializeDatabaseStoredProcedures()
        {
            List<StoredProcedureData> sprocData = new List<StoredProcedureData>();

            string sql = @"SELECT
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

            using (SqlConnection connection = new SqlConnection(Global.DatabaseSetting.ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    StoredProcedureData data = Global.SelectedStoredProcedures.Where(x => x.StoredProcName == name).FirstOrDefault();

                    if (data == null)
                    {
                        data = new StoredProcedureData();

                        data.StoredProcName = name;
                        data.StoredProcSelect = false;
                    }

                    sprocData.Add(data);
                }

                connection.Close();
            }

            gvStoredProcedures.Invoke(new Action(() => gvStoredProcedures.DataSource = sprocData));
        }

        private void InitializeDatabaseSpellFunctions()
        {
            List<SpellFunctionData> enumData = new List<SpellFunctionData>();

            string sql = @"DECLARE @functions TABLE
								  (
										Name   VARCHAR(500),
										RawText VARCHAR(max)
								  )
								DECLARE @t TABLE
								  (
										line VARCHAR(max)
								  )
								DECLARE @rawText VARCHAR(max)
								DECLARE @name VARCHAR(500)
								DECLARE db_cursor CURSOR FOR
									SELECT
										NAME
									FROM   sys.objects
									WHERE
										type = 'FN'
										AND NAME LIKE '%FN_Spell_%'

								OPEN db_cursor

								FETCH NEXT FROM db_cursor INTO @name

								WHILE @@FETCH_STATUS = 0
									BEGIN
										INSERT INTO @t
										EXEC Sp_helptext
											@name

										SELECT
											@rawText = Stuff((SELECT
																	line AS [text()]
																FROM   @t
																FOR XML PATH (''), Type).value('.[1]', 'nvarchar(max)'), 1, 0, '')

										INSERT INTO @functions
														(Name,RawText)
										VALUES      (@name,@rawText)

										DELETE FROM @t

										FETCH NEXT FROM db_cursor INTO @name
									END

								CLOSE db_cursor

								DEALLOCATE db_cursor

								SELECT
									Name,
									RawText
								FROM   @functions";

            using (SqlConnection connection = new SqlConnection(Global.DatabaseSetting.ConnectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    SpellFunctionData data = Global.SelectedEnums.Where(x => x.FunctionName == reader["Name"].ToString()).FirstOrDefault();

                    if (data == null)
                    {
                        data = new SpellFunctionData();

                        data.FunctionName = reader["Name"].ToString();
                        data.FunctionSelect = false;
                        data.EnumName = GetEnumerationNameFromSpellFunction(data.FunctionName);
                    }

                    data.FunctionRawText = reader["RawText"].ToString();

                    enumData.Add(data);
                }

                connection.Close();
            }

            gvSpellFunctions.Invoke(new Action(() => gvSpellFunctions.DataSource = enumData));
        }

        private string GetEnumerationNameFromSpellFunction(string spellFunctionName)
        {
            string returnVal = spellFunctionName.ToLower();

            returnVal = returnVal.Replace("fn_spell_", string.Empty).Replace("_", " ");

            returnVal = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(returnVal);
            returnVal = returnVal.Replace(" ", string.Empty);

            return returnVal;
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
            List<TableData> tableData = (List<TableData>)bsTables.DataSource;

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
            List<TableData> tableData = (List<TableData>)bsTables.DataSource;

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

        private void gvTables_SelectionChanged(object sender, EventArgs e)
        {
            if (gvTables.SelectedRows.Count > 0)
            {
                TableData table = (TableData)gvTables.SelectedRows[0].DataBoundItem;

                if (table.Columns.Count > 0)
                {
                    gvSelectedTable.DataSource = table.Columns;
                }
            }
        }

        private void gvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gvTables.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

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

        public void TableCheckboxHeader_CheckStateChanged(object sender, EventArgs e)
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

        #region Tab - Stored Procedures

        #region Private Methods

        private void HandleStoredProcSelectChange(bool isChecked)
        {
            CheckBox cbxHeader = (CheckBox)gvStoredProcedures.Controls.Find("StoredProcSelectHeader", false).First();

            HandleStoredProcSelectHeaderChange(cbxHeader);

            if (cbxHeader.CheckState == CheckState.Checked && !isChecked ||
                    cbxHeader.CheckState == CheckState.Unchecked && isChecked)
            {
                cbxHeader.CheckState = CheckState.Indeterminate;
            }
        }

        private void HandleStoredProcSelectHeaderChange(CheckBox cbx)
        {
            List<StoredProcedureData> sprocData = (List<StoredProcedureData>)gvStoredProcedures.DataSource;

            int checkedCount = sprocData.Where(x => x.StoredProcSelect == true).Count();

            if (checkedCount > 0 && checkedCount < sprocData.Count)
            {
                cbx.CheckState = CheckState.Indeterminate;
            }
            else if (checkedCount == sprocData.Count)
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

        private void gvStoredProcedures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gvStoredProcedures.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void gvStoredProcedures_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell cbx = (DataGridViewCheckBoxCell)gvStoredProcedures[e.ColumnIndex, e.RowIndex];

                if (cbx.EditingCellValueChanged)
                {
                    if (e.ColumnIndex == 0)
                    {
                        bool isChecked = (bool)gvStoredProcedures[0, e.RowIndex].FormattedValue;

                        HandleStoredProcSelectChange(isChecked);

                        gvStoredProcedures.EndEdit();
                    }
                }
            }
        }

        public void StoredProcCheckboxHeader_CheckStateChanged(object sender, EventArgs e)
        {
            if (gvStoredProcedures.IsCurrentCellInEditMode)
            {
                gvStoredProcedures.EndEdit();
            }

            CheckBox cbx = (CheckBox)sender;

            if (cbx.Focused)
            {
                if (cbx.CheckState == CheckState.Indeterminate)
                {
                    cbx.CheckState = CheckState.Unchecked;
                }

                for (int i = 0; i < gvStoredProcedures.Rows.Count; i++)
                {
                    gvStoredProcedures.Rows[i].Cells[0].Value = cbx.Checked;
                }

            }
        }

        #endregion
        #endregion

        #region Tab - Enums

        #region Private Methods

        private void HandleFunctionSelectChange(bool isChecked)
        {
            CheckBox cbxHeader = (CheckBox)gvSpellFunctions.Controls.Find("FunctionSelectHeader", false).First();

            HandleFunctionSelectHeaderChange(cbxHeader);

            if (cbxHeader.CheckState == CheckState.Checked && !isChecked ||
                    cbxHeader.CheckState == CheckState.Unchecked && isChecked)
            {
                cbxHeader.CheckState = CheckState.Indeterminate;
            }
        }

        private void HandleFunctionSelectHeaderChange(CheckBox cbx)
        {
            List<SpellFunctionData> enumData = (List<SpellFunctionData>)gvSpellFunctions.DataSource;

            int checkedCount = enumData.Where(x => x.FunctionSelect == true).Count();

            if (checkedCount > 0 && checkedCount < enumData.Count)
            {
                cbx.CheckState = CheckState.Indeterminate;
            }
            else if (checkedCount == enumData.Count)
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

        private void gvSpellFunctions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gvSpellFunctions.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void gvSpellFunctions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell cbx = (DataGridViewCheckBoxCell)gvSpellFunctions[e.ColumnIndex, e.RowIndex];

                if (cbx.EditingCellValueChanged)
                {
                    if (e.ColumnIndex == 0)
                    {
                        bool isChecked = (bool)gvSpellFunctions[0, e.RowIndex].FormattedValue;

                        HandleFunctionSelectChange(isChecked);

                        SpellFunctionData data = (SpellFunctionData)gvSpellFunctions.Rows[e.RowIndex].DataBoundItem;

                        if (isChecked)
                        {
                            bsSelectedEnums.Insert(bsSelectedEnums.Count, data);
                        }
                        else
                        {
                            var enums = (List<SpellFunctionData>)bsSelectedEnums.DataSource;

                            var @enum = enums.Where(x => x.FunctionName == data.FunctionName).FirstOrDefault();

                            if (@enum != null)
                            {
                                int index = enums.ToList().IndexOf(@enum);
                                bsSelectedEnums.RemoveAt(index);
                            }
                        }

                        gvSpellFunctions.EndEdit();
                    }
                }
            }
        }

        private void gvSpellFunctions_DataSourceChanged(object sender, EventArgs e)
        {
            List<SpellFunctionData> enums = (List<SpellFunctionData>)gvSpellFunctions.DataSource;

            foreach (SpellFunctionData data in enums.Where(x => x.FunctionSelect).ToList())
            {
                bsSelectedEnums.Insert(bsSelectedEnums.Count, data);
            }
        }

        public void FunctionCheckboxHeader_CheckStateChanged(object sender, EventArgs e)
        {
            if (gvSpellFunctions.IsCurrentCellInEditMode)
            {
                gvSpellFunctions.EndEdit();
            }

            CheckBox cbx = (CheckBox)sender;

            if (cbx.Focused)
            {
                if (cbx.CheckState == CheckState.Indeterminate)
                {
                    cbx.CheckState = CheckState.Unchecked;
                }

                for (int i = 0; i < gvSpellFunctions.Rows.Count; i++)
                {
                    gvSpellFunctions.Rows[i].Cells[0].Value = cbx.Checked;
                }

            }
        }

        #endregion

        #endregion


    }

}