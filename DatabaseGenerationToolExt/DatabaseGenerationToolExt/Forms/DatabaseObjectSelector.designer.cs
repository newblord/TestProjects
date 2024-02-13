namespace DatabaseGenerationToolExt.Forms
{
	partial class DatabaseObjectSelector
    {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlLoader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoaderMessage = new System.Windows.Forms.Label();
            this.tpEnums = new System.Windows.Forms.TabPage();
            this.gvSpellFunctions = new System.Windows.Forms.DataGridView();
            this.FunctionSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FunctionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionRawText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpStoredProcedures = new System.Windows.Forms.TabPage();
            this.gvStoredProcedures = new System.Windows.Forms.DataGridView();
            this.StoredProcSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StoredProcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpTables = new System.Windows.Forms.TabPage();
            this.gvSelectedTable = new System.Windows.Forms.DataGridView();
            this.TableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableColumnEnum = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gvTables = new System.Windows.Forms.DataGridView();
            this.TableSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableIModel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TableModelDto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TableSpecification = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TableRepository = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TableIRepository = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ServiceInterface = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbTables = new System.Windows.Forms.GroupBox();
            this.cbxSpecifications = new System.Windows.Forms.CheckBox();
            this.cbxModelDtos = new System.Windows.Forms.CheckBox();
            this.cbxServiceInterfaces = new System.Windows.Forms.CheckBox();
            this.cbxServices = new System.Windows.Forms.CheckBox();
            this.cbxRepositoryInterfaces = new System.Windows.Forms.CheckBox();
            this.cbxRepositories = new System.Windows.Forms.CheckBox();
            this.cbxModelInterfaces = new System.Windows.Forms.CheckBox();
            this.tcDatabaseObjects = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSettings = new System.Windows.Forms.Button();
            this.bsSelectedEnums = new System.Windows.Forms.BindingSource(this.components);
            this.bsTables = new System.Windows.Forms.BindingSource(this.components);
            this.pnlLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpEnums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpellFunctions)).BeginInit();
            this.tpStoredProcedures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStoredProcedures)).BeginInit();
            this.tpTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTables)).BeginInit();
            this.gbTables.SuspendLayout();
            this.tcDatabaseObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedEnums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(585, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(666, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlLoader
            // 
            this.pnlLoader.BackColor = System.Drawing.Color.White;
            this.pnlLoader.Controls.Add(this.pictureBox1);
            this.pnlLoader.Controls.Add(this.lblLoaderMessage);
            this.pnlLoader.Location = new System.Drawing.Point(0, 0);
            this.pnlLoader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLoader.Name = "pnlLoader";
            this.pnlLoader.Size = new System.Drawing.Size(882, 563);
            this.pnlLoader.TabIndex = 2;
            this.pnlLoader.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseGenerationToolExt.Properties.Resources.loader;
            this.pictureBox1.Location = new System.Drawing.Point(261, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoaderMessage
            // 
            this.lblLoaderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaderMessage.Location = new System.Drawing.Point(258, 442);
            this.lblLoaderMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaderMessage.Name = "lblLoaderMessage";
            this.lblLoaderMessage.Size = new System.Drawing.Size(402, 51);
            this.lblLoaderMessage.TabIndex = 1;
            this.lblLoaderMessage.Text = "message here:";
            // 
            // tpEnums
            // 
            this.tpEnums.Controls.Add(this.gvSpellFunctions);
            this.tpEnums.Location = new System.Drawing.Point(4, 22);
            this.tpEnums.Name = "tpEnums";
            this.tpEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnums.Size = new System.Drawing.Size(874, 503);
            this.tpEnums.TabIndex = 3;
            this.tpEnums.Text = "Enums";
            this.tpEnums.UseVisualStyleBackColor = true;
            // 
            // gvSpellFunctions
            // 
            this.gvSpellFunctions.AllowUserToAddRows = false;
            this.gvSpellFunctions.AllowUserToDeleteRows = false;
            this.gvSpellFunctions.AllowUserToResizeColumns = false;
            this.gvSpellFunctions.AllowUserToResizeRows = false;
            this.gvSpellFunctions.ColumnHeadersHeight = 35;
            this.gvSpellFunctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvSpellFunctions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FunctionSelect,
            this.FunctionName,
            this.FunctionRawText});
            this.gvSpellFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSpellFunctions.Location = new System.Drawing.Point(3, 3);
            this.gvSpellFunctions.MultiSelect = false;
            this.gvSpellFunctions.Name = "gvSpellFunctions";
            this.gvSpellFunctions.RowHeadersVisible = false;
            this.gvSpellFunctions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSpellFunctions.Size = new System.Drawing.Size(868, 497);
            this.gvSpellFunctions.TabIndex = 0;
            this.gvSpellFunctions.DataSourceChanged += new System.EventHandler(this.gvSpellFunctions_DataSourceChanged);
            this.gvSpellFunctions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSpellFunctions_CellContentClick);
            this.gvSpellFunctions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSpellFunctions_CellValueChanged);
            // 
            // FunctionSelect
            // 
            this.FunctionSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FunctionSelect.DataPropertyName = "FunctionSelect";
            this.FunctionSelect.HeaderText = "";
            this.FunctionSelect.Name = "FunctionSelect";
            this.FunctionSelect.Width = 20;
            // 
            // FunctionName
            // 
            this.FunctionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FunctionName.DataPropertyName = "FunctionName";
            this.FunctionName.HeaderText = "Name";
            this.FunctionName.MinimumWidth = 150;
            this.FunctionName.Name = "FunctionName";
            this.FunctionName.ReadOnly = true;
            this.FunctionName.Width = 250;
            // 
            // FunctionRawText
            // 
            this.FunctionRawText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FunctionRawText.DataPropertyName = "FunctionRawText";
            this.FunctionRawText.HeaderText = "Functions Sql";
            this.FunctionRawText.Name = "FunctionRawText";
            // 
            // tpStoredProcedures
            // 
            this.tpStoredProcedures.Controls.Add(this.gvStoredProcedures);
            this.tpStoredProcedures.Location = new System.Drawing.Point(4, 22);
            this.tpStoredProcedures.Name = "tpStoredProcedures";
            this.tpStoredProcedures.Padding = new System.Windows.Forms.Padding(3);
            this.tpStoredProcedures.Size = new System.Drawing.Size(874, 503);
            this.tpStoredProcedures.TabIndex = 2;
            this.tpStoredProcedures.Text = "Stored Procedures";
            this.tpStoredProcedures.UseVisualStyleBackColor = true;
            // 
            // gvStoredProcedures
            // 
            this.gvStoredProcedures.AllowUserToAddRows = false;
            this.gvStoredProcedures.AllowUserToDeleteRows = false;
            this.gvStoredProcedures.AllowUserToResizeColumns = false;
            this.gvStoredProcedures.AllowUserToResizeRows = false;
            this.gvStoredProcedures.ColumnHeadersHeight = 34;
            this.gvStoredProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvStoredProcedures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoredProcSelect,
            this.StoredProcName});
            this.gvStoredProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStoredProcedures.Location = new System.Drawing.Point(3, 3);
            this.gvStoredProcedures.Name = "gvStoredProcedures";
            this.gvStoredProcedures.RowHeadersVisible = false;
            this.gvStoredProcedures.Size = new System.Drawing.Size(868, 497);
            this.gvStoredProcedures.TabIndex = 0;
            this.gvStoredProcedures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStoredProcedures_CellContentClick);
            this.gvStoredProcedures.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStoredProcedures_CellValueChanged);
            // 
            // StoredProcSelect
            // 
            this.StoredProcSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StoredProcSelect.DataPropertyName = "StoredProcSelect";
            this.StoredProcSelect.HeaderText = "";
            this.StoredProcSelect.Name = "StoredProcSelect";
            this.StoredProcSelect.Width = 20;
            // 
            // StoredProcName
            // 
            this.StoredProcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StoredProcName.DataPropertyName = "StoredProcName";
            this.StoredProcName.HeaderText = "Name";
            this.StoredProcName.MinimumWidth = 150;
            this.StoredProcName.Name = "StoredProcName";
            this.StoredProcName.ReadOnly = true;
            this.StoredProcName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StoredProcName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tpTables
            // 
            this.tpTables.Controls.Add(this.gvSelectedTable);
            this.tpTables.Controls.Add(this.gvTables);
            this.tpTables.Controls.Add(this.gbTables);
            this.tpTables.Location = new System.Drawing.Point(4, 22);
            this.tpTables.Name = "tpTables";
            this.tpTables.Padding = new System.Windows.Forms.Padding(3);
            this.tpTables.Size = new System.Drawing.Size(874, 503);
            this.tpTables.TabIndex = 0;
            this.tpTables.Text = "Tables";
            this.tpTables.UseVisualStyleBackColor = true;
            // 
            // gvSelectedTable
            // 
            this.gvSelectedTable.AllowUserToAddRows = false;
            this.gvSelectedTable.AllowUserToDeleteRows = false;
            this.gvSelectedTable.AllowUserToResizeColumns = false;
            this.gvSelectedTable.AllowUserToResizeRows = false;
            this.gvSelectedTable.ColumnHeadersHeight = 34;
            this.gvSelectedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvSelectedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableColumn,
            this.TableColumnEnum});
            this.gvSelectedTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.gvSelectedTable.Location = new System.Drawing.Point(631, 85);
            this.gvSelectedTable.Name = "gvSelectedTable";
            this.gvSelectedTable.RowHeadersVisible = false;
            this.gvSelectedTable.Size = new System.Drawing.Size(240, 415);
            this.gvSelectedTable.TabIndex = 3;
            // 
            // TableColumn
            // 
            this.TableColumn.DataPropertyName = "Name";
            this.TableColumn.HeaderText = "Column";
            this.TableColumn.Name = "TableColumn";
            // 
            // TableColumnEnum
            // 
            this.TableColumnEnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableColumnEnum.DataPropertyName = "Value";
            this.TableColumnEnum.DataSource = this.bsSelectedEnums;
            this.TableColumnEnum.DisplayMember = "EnumName";
            this.TableColumnEnum.HeaderText = "Enum";
            this.TableColumnEnum.Name = "TableColumnEnum";
            this.TableColumnEnum.ValueMember = "EnumName";
            // 
            // gvTables
            // 
            this.gvTables.AllowUserToAddRows = false;
            this.gvTables.AllowUserToDeleteRows = false;
            this.gvTables.AllowUserToResizeRows = false;
            this.gvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableSelect,
            this.TableName,
            this.TableIModel,
            this.TableModelDto,
            this.TableSpecification,
            this.TableRepository,
            this.TableIRepository,
            this.Service,
            this.ServiceInterface});
            this.gvTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvTables.Location = new System.Drawing.Point(3, 85);
            this.gvTables.MultiSelect = false;
            this.gvTables.Name = "gvTables";
            this.gvTables.RowHeadersVisible = false;
            this.gvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTables.ShowEditingIcon = false;
            this.gvTables.Size = new System.Drawing.Size(627, 415);
            this.gvTables.TabIndex = 2;
            this.gvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellContentClick);
            this.gvTables.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellValueChanged);
            this.gvTables.SelectionChanged += new System.EventHandler(this.gvTables_SelectionChanged);
            // 
            // TableSelect
            // 
            this.TableSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TableSelect.DataPropertyName = "TableSelect";
            this.TableSelect.HeaderText = "";
            this.TableSelect.Name = "TableSelect";
            this.TableSelect.Width = 20;
            // 
            // TableName
            // 
            this.TableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableName.DataPropertyName = "TableName";
            this.TableName.HeaderText = "Name";
            this.TableName.MinimumWidth = 150;
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            // 
            // TableIModel
            // 
            this.TableIModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TableIModel.DataPropertyName = "GenerateModelInterface";
            this.TableIModel.HeaderText = "Model Interface";
            this.TableIModel.Name = "TableIModel";
            this.TableIModel.Width = 55;
            // 
            // TableModelDto
            // 
            this.TableModelDto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TableModelDto.DataPropertyName = "GenerateModelDto";
            this.TableModelDto.HeaderText = "Model DTO";
            this.TableModelDto.Name = "TableModelDto";
            this.TableModelDto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TableModelDto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TableModelDto.Width = 40;
            // 
            // TableSpecification
            // 
            this.TableSpecification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TableSpecification.DataPropertyName = "GenerateSpecification";
            this.TableSpecification.HeaderText = "Specification";
            this.TableSpecification.Name = "TableSpecification";
            this.TableSpecification.Width = 70;
            // 
            // TableRepository
            // 
            this.TableRepository.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TableRepository.DataPropertyName = "GenerateRepository";
            this.TableRepository.HeaderText = "Repository";
            this.TableRepository.Name = "TableRepository";
            this.TableRepository.Width = 60;
            // 
            // TableIRepository
            // 
            this.TableIRepository.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TableIRepository.DataPropertyName = "GenerateRepositoryInterface";
            this.TableIRepository.HeaderText = "Repository Interface";
            this.TableIRepository.Name = "TableIRepository";
            this.TableIRepository.Width = 62;
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Service.DataPropertyName = "GenerateService";
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            this.Service.Width = 47;
            // 
            // ServiceInterface
            // 
            this.ServiceInterface.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ServiceInterface.DataPropertyName = "GenerateServiceInterface";
            this.ServiceInterface.HeaderText = "Service Interface";
            this.ServiceInterface.Name = "ServiceInterface";
            this.ServiceInterface.Width = 60;
            // 
            // gbTables
            // 
            this.gbTables.Controls.Add(this.cbxSpecifications);
            this.gbTables.Controls.Add(this.cbxModelDtos);
            this.gbTables.Controls.Add(this.cbxServiceInterfaces);
            this.gbTables.Controls.Add(this.cbxServices);
            this.gbTables.Controls.Add(this.cbxRepositoryInterfaces);
            this.gbTables.Controls.Add(this.cbxRepositories);
            this.gbTables.Controls.Add(this.cbxModelInterfaces);
            this.gbTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTables.Location = new System.Drawing.Point(3, 3);
            this.gbTables.Name = "gbTables";
            this.gbTables.Size = new System.Drawing.Size(868, 82);
            this.gbTables.TabIndex = 0;
            this.gbTables.TabStop = false;
            this.gbTables.Text = "Table Settings";
            // 
            // cbxSpecifications
            // 
            this.cbxSpecifications.AutoSize = true;
            this.cbxSpecifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSpecifications.Location = new System.Drawing.Point(421, 22);
            this.cbxSpecifications.Name = "cbxSpecifications";
            this.cbxSpecifications.Size = new System.Drawing.Size(106, 17);
            this.cbxSpecifications.TabIndex = 7;
            this.cbxSpecifications.Text = "All Specifications";
            this.cbxSpecifications.UseVisualStyleBackColor = true;
            this.cbxSpecifications.CheckedChanged += new System.EventHandler(this.cbxSpecifications_CheckedChanged);
            // 
            // cbxModelDtos
            // 
            this.cbxModelDtos.AutoSize = true;
            this.cbxModelDtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModelDtos.Location = new System.Drawing.Point(7, 22);
            this.cbxModelDtos.Name = "cbxModelDtos";
            this.cbxModelDtos.Size = new System.Drawing.Size(100, 17);
            this.cbxModelDtos.TabIndex = 6;
            this.cbxModelDtos.Text = "All Model DTOs";
            this.cbxModelDtos.UseVisualStyleBackColor = true;
            this.cbxModelDtos.CheckedChanged += new System.EventHandler(this.cbxModelDtos_CheckedChanged);
            // 
            // cbxServiceInterfaces
            // 
            this.cbxServiceInterfaces.AutoSize = true;
            this.cbxServiceInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServiceInterfaces.Location = new System.Drawing.Point(281, 51);
            this.cbxServiceInterfaces.Name = "cbxServiceInterfaces";
            this.cbxServiceInterfaces.Size = new System.Drawing.Size(126, 17);
            this.cbxServiceInterfaces.TabIndex = 5;
            this.cbxServiceInterfaces.Text = "All Service Interfaces";
            this.cbxServiceInterfaces.UseVisualStyleBackColor = true;
            this.cbxServiceInterfaces.CheckedChanged += new System.EventHandler(this.cbxServiceInterfaces_CheckedChanged);
            // 
            // cbxServices
            // 
            this.cbxServices.AutoSize = true;
            this.cbxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServices.Location = new System.Drawing.Point(281, 22);
            this.cbxServices.Name = "cbxServices";
            this.cbxServices.Size = new System.Drawing.Size(81, 17);
            this.cbxServices.TabIndex = 4;
            this.cbxServices.Text = "All Services";
            this.cbxServices.UseVisualStyleBackColor = true;
            this.cbxServices.CheckedChanged += new System.EventHandler(this.cbxServices_CheckedChanged);
            // 
            // cbxRepositoryInterfaces
            // 
            this.cbxRepositoryInterfaces.AutoSize = true;
            this.cbxRepositoryInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRepositoryInterfaces.Location = new System.Drawing.Point(132, 51);
            this.cbxRepositoryInterfaces.Name = "cbxRepositoryInterfaces";
            this.cbxRepositoryInterfaces.Size = new System.Drawing.Size(140, 17);
            this.cbxRepositoryInterfaces.TabIndex = 3;
            this.cbxRepositoryInterfaces.Text = "All Repository Interfaces";
            this.cbxRepositoryInterfaces.UseVisualStyleBackColor = true;
            this.cbxRepositoryInterfaces.CheckStateChanged += new System.EventHandler(this.cbxRepositoryInterfaces_CheckStateChanged);
            // 
            // cbxRepositories
            // 
            this.cbxRepositories.AutoSize = true;
            this.cbxRepositories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRepositories.Location = new System.Drawing.Point(132, 22);
            this.cbxRepositories.Name = "cbxRepositories";
            this.cbxRepositories.Size = new System.Drawing.Size(98, 17);
            this.cbxRepositories.TabIndex = 2;
            this.cbxRepositories.Text = "All Repositories";
            this.cbxRepositories.UseVisualStyleBackColor = true;
            this.cbxRepositories.CheckStateChanged += new System.EventHandler(this.cbxRepositories_CheckStateChanged);
            // 
            // cbxModelInterfaces
            // 
            this.cbxModelInterfaces.AutoSize = true;
            this.cbxModelInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModelInterfaces.Location = new System.Drawing.Point(7, 51);
            this.cbxModelInterfaces.Name = "cbxModelInterfaces";
            this.cbxModelInterfaces.Size = new System.Drawing.Size(119, 17);
            this.cbxModelInterfaces.TabIndex = 1;
            this.cbxModelInterfaces.Text = "All Model Interfaces";
            this.cbxModelInterfaces.UseVisualStyleBackColor = true;
            this.cbxModelInterfaces.CheckStateChanged += new System.EventHandler(this.cbxModelInterfaces_CheckStateChanged);
            // 
            // tcDatabaseObjects
            // 
            this.tcDatabaseObjects.Controls.Add(this.tpTables);
            this.tcDatabaseObjects.Controls.Add(this.tpStoredProcedures);
            this.tcDatabaseObjects.Controls.Add(this.tpEnums);
            this.tcDatabaseObjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcDatabaseObjects.Location = new System.Drawing.Point(0, 0);
            this.tcDatabaseObjects.Name = "tcDatabaseObjects";
            this.tcDatabaseObjects.SelectedIndex = 0;
            this.tcDatabaseObjects.Size = new System.Drawing.Size(882, 529);
            this.tcDatabaseObjects.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 532);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnGenerate);
            this.splitContainer1.Size = new System.Drawing.Size(882, 33);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // bsSelectedEnums
            // 
            this.bsSelectedEnums.DataSource = typeof(DatabaseGenerationToolExt.Forms.Models.SpellFunctionData);
            // 
            // bsTables
            // 
            this.bsTables.DataSource = typeof(DatabaseGenerationToolExt.DatabaseGeneration.Models.Table);
            // 
            // DatabaseObjectSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.ControlBox = false;
            this.Controls.Add(this.tcDatabaseObjects);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DatabaseObjectSelector";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reverse Engineer Database Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatabaseObjectSelector_FormClosing);
            this.Load += new System.EventHandler(this.DatabaseObjectSelector_Load);
            this.Shown += new System.EventHandler(this.DatabaseObjectSelector_Shown);
            this.pnlLoader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpEnums.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSpellFunctions)).EndInit();
            this.tpStoredProcedures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStoredProcedures)).EndInit();
            this.tpTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectedTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTables)).EndInit();
            this.gbTables.ResumeLayout(false);
            this.gbTables.PerformLayout();
            this.tcDatabaseObjects.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSelectedEnums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTables)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsTables;
        private System.Windows.Forms.BindingSource bsSelectedEnums;
        private System.Windows.Forms.Panel pnlLoader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoaderMessage;
        private System.Windows.Forms.TabPage tpEnums;
        private System.Windows.Forms.DataGridView gvSpellFunctions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FunctionSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionRawText;
        private System.Windows.Forms.TabPage tpStoredProcedures;
        private System.Windows.Forms.DataGridView gvStoredProcedures;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StoredProcSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoredProcName;
        private System.Windows.Forms.TabPage tpTables;
        private System.Windows.Forms.DataGridView gvSelectedTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TableColumnEnum;
        private System.Windows.Forms.DataGridView gvTables;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TableSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TableIModel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TableModelDto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TableSpecification;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TableRepository;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TableIRepository;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Service;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ServiceInterface;
        private System.Windows.Forms.GroupBox gbTables;
        private System.Windows.Forms.CheckBox cbxSpecifications;
        private System.Windows.Forms.CheckBox cbxModelDtos;
        private System.Windows.Forms.CheckBox cbxServiceInterfaces;
        private System.Windows.Forms.CheckBox cbxServices;
        private System.Windows.Forms.CheckBox cbxRepositoryInterfaces;
        private System.Windows.Forms.CheckBox cbxRepositories;
        private System.Windows.Forms.CheckBox cbxModelInterfaces;
        private System.Windows.Forms.TabControl tcDatabaseObjects;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSettings;
    }
}