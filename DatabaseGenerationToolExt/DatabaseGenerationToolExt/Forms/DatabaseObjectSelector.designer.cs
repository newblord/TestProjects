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
			this.btnGenerate = new System.Windows.Forms.Button();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.tpEnums = new System.Windows.Forms.TabPage();
			this.gvEnums = new System.Windows.Forms.DataGridView();
			this.EnumSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.EnumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpStoredProcedures = new System.Windows.Forms.TabPage();
			this.gvStoredProcedures = new System.Windows.Forms.DataGridView();
			this.StoredProcSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.StoredProcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpTables = new System.Windows.Forms.TabPage();
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
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.ddlIncludeComments = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtConfigurationClassName = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtContextInterfaceBaseClass = new System.Windows.Forms.TextBox();
			this.txtContextBaseClass = new System.Windows.Forms.TextBox();
			this.txtDbContextName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cbxUseCamelCase = new System.Windows.Forms.CheckBox();
			this.cbxDisableGeographyTypes = new System.Windows.Forms.CheckBox();
			this.cbxNullableShortHand = new System.Windows.Forms.CheckBox();
			this.cbxPrependSchema = new System.Windows.Forms.CheckBox();
			this.cbxIncludeQueryTraceOn = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.cbxPartialClasses = new System.Windows.Forms.CheckBox();
			this.cbxPartialInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxPartialContextInterface = new System.Windows.Forms.CheckBox();
			this.cbxUseDataAnnotations = new System.Windows.Forms.CheckBox();
			this.cbxGenerateContextClass = new System.Windows.Forms.CheckBox();
			this.cbxGenerateUnitOfWorkInterface = new System.Windows.Forms.CheckBox();
			this.cbxVirtualReverseNavProperty = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tcDatabaseObjects = new System.Windows.Forms.TabControl();
			this.tpProjectSettings = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbProjectFolders = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
			this.txtContextFolder = new System.Windows.Forms.TextBox();
			this.txtModelFolder = new System.Windows.Forms.TextBox();
			this.txtModelDtoFolder = new System.Windows.Forms.TextBox();
			this.txtModelInterfaceFolder = new System.Windows.Forms.TextBox();
			this.txtRepositoryFolder = new System.Windows.Forms.TextBox();
			this.txtRepositoryInterfaceFolder = new System.Windows.Forms.TextBox();
			this.txtServiceFolder = new System.Windows.Forms.TextBox();
			this.txtServiceInterfaceFolder = new System.Windows.Forms.TextBox();
			this.txtSpecificationFolder = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.gbProjectNames = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.ddlContextProject = new System.Windows.Forms.ComboBox();
			this.ddlModelProject = new System.Windows.Forms.ComboBox();
			this.ddlModelDtoProject = new System.Windows.Forms.ComboBox();
			this.ddlModelInterfaceProject = new System.Windows.Forms.ComboBox();
			this.ddlRepositoryProject = new System.Windows.Forms.ComboBox();
			this.ddlRepositoryInterfaceProject = new System.Windows.Forms.ComboBox();
			this.ddlServiceProject = new System.Windows.Forms.ComboBox();
			this.ddlServiceInterfaceProject = new System.Windows.Forms.ComboBox();
			this.ddlSpecificationProject = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.gbNamespaces = new System.Windows.Forms.GroupBox();
			this.txtConfigurationNamespace = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.txtSpecificationNamespace = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.txtServiceInterfaceNamespace = new System.Windows.Forms.TextBox();
			this.txtServiceNamespace = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.txtRepositoryInterfaceNamespace = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtRepositoryNamespace = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtModelDtoNamespace = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtModelInterfaceNamespace = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtModelNamespace = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtContextNamespace = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.ddlConfigurationProject = new System.Windows.Forms.ComboBox();
			this.txtConfigurationFolder = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel3.SuspendLayout();
			this.tpEnums.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvEnums)).BeginInit();
			this.tpStoredProcedures.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvStoredProcedures)).BeginInit();
			this.tpTables.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvTables)).BeginInit();
			this.gbTables.SuspendLayout();
			this.tpSettings.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.tcDatabaseObjects.SuspendLayout();
			this.tpProjectSettings.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbProjectFolders.SuspendLayout();
			this.flowLayoutPanel7.SuspendLayout();
			this.flowLayoutPanel6.SuspendLayout();
			this.gbProjectNames.SuspendLayout();
			this.flowLayoutPanel5.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.gbNamespaces.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(495, 3);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 0;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.btnCancel);
			this.flowLayoutPanel3.Controls.Add(this.btnGenerate);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 454);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(654, 34);
			this.flowLayoutPanel3.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(576, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// tpEnums
			// 
			this.tpEnums.Controls.Add(this.gvEnums);
			this.tpEnums.Location = new System.Drawing.Point(4, 22);
			this.tpEnums.Name = "tpEnums";
			this.tpEnums.Padding = new System.Windows.Forms.Padding(3);
			this.tpEnums.Size = new System.Drawing.Size(621, 396);
			this.tpEnums.TabIndex = 3;
			this.tpEnums.Text = "Enums";
			this.tpEnums.UseVisualStyleBackColor = true;
			// 
			// gvEnums
			// 
			this.gvEnums.AllowUserToAddRows = false;
			this.gvEnums.AllowUserToDeleteRows = false;
			this.gvEnums.AllowUserToResizeColumns = false;
			this.gvEnums.AllowUserToResizeRows = false;
			this.gvEnums.ColumnHeadersHeight = 35;
			this.gvEnums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gvEnums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnumSelect,
            this.EnumName});
			this.gvEnums.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvEnums.Location = new System.Drawing.Point(3, 3);
			this.gvEnums.Name = "gvEnums";
			this.gvEnums.RowHeadersVisible = false;
			this.gvEnums.Size = new System.Drawing.Size(615, 390);
			this.gvEnums.TabIndex = 0;
			this.gvEnums.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEnums_CellContentClick);
			this.gvEnums.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEnums_CellValueChanged);
			// 
			// EnumSelect
			// 
			this.EnumSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.EnumSelect.DataPropertyName = "EnumSelect";
			this.EnumSelect.HeaderText = "";
			this.EnumSelect.Name = "EnumSelect";
			this.EnumSelect.Width = 20;
			// 
			// EnumName
			// 
			this.EnumName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EnumName.DataPropertyName = "EnumName";
			this.EnumName.HeaderText = "Name";
			this.EnumName.MinimumWidth = 150;
			this.EnumName.Name = "EnumName";
			this.EnumName.ReadOnly = true;
			// 
			// tpStoredProcedures
			// 
			this.tpStoredProcedures.Controls.Add(this.gvStoredProcedures);
			this.tpStoredProcedures.Location = new System.Drawing.Point(4, 22);
			this.tpStoredProcedures.Name = "tpStoredProcedures";
			this.tpStoredProcedures.Padding = new System.Windows.Forms.Padding(3);
			this.tpStoredProcedures.Size = new System.Drawing.Size(621, 396);
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
			this.gvStoredProcedures.Size = new System.Drawing.Size(615, 390);
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
			this.tpTables.Controls.Add(this.gvTables);
			this.tpTables.Controls.Add(this.gbTables);
			this.tpTables.Location = new System.Drawing.Point(4, 22);
			this.tpTables.Name = "tpTables";
			this.tpTables.Padding = new System.Windows.Forms.Padding(3);
			this.tpTables.Size = new System.Drawing.Size(621, 396);
			this.tpTables.TabIndex = 0;
			this.tpTables.Text = "Tables";
			this.tpTables.UseVisualStyleBackColor = true;
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
			this.gvTables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvTables.Location = new System.Drawing.Point(3, 85);
			this.gvTables.Name = "gvTables";
			this.gvTables.RowHeadersVisible = false;
			this.gvTables.ShowEditingIcon = false;
			this.gvTables.Size = new System.Drawing.Size(615, 308);
			this.gvTables.TabIndex = 2;
			this.gvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellContentClick);
			this.gvTables.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellValueChanged);
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
			this.gbTables.Size = new System.Drawing.Size(615, 82);
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
			// tpSettings
			// 
			this.tpSettings.Controls.Add(this.ddlIncludeComments);
			this.tpSettings.Controls.Add(this.label7);
			this.tpSettings.Controls.Add(this.txtConfigurationClassName);
			this.tpSettings.Controls.Add(this.textBox1);
			this.tpSettings.Controls.Add(this.txtContextInterfaceBaseClass);
			this.tpSettings.Controls.Add(this.txtContextBaseClass);
			this.tpSettings.Controls.Add(this.txtDbContextName);
			this.tpSettings.Controls.Add(this.label5);
			this.tpSettings.Controls.Add(this.label2);
			this.tpSettings.Controls.Add(this.flowLayoutPanel1);
			this.tpSettings.Controls.Add(this.label4);
			this.tpSettings.Controls.Add(this.label3);
			this.tpSettings.Controls.Add(this.flowLayoutPanel2);
			this.tpSettings.Controls.Add(this.label1);
			this.tpSettings.Location = new System.Drawing.Point(4, 22);
			this.tpSettings.Name = "tpSettings";
			this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tpSettings.Size = new System.Drawing.Size(643, 429);
			this.tpSettings.TabIndex = 4;
			this.tpSettings.Text = "Settings";
			this.tpSettings.UseVisualStyleBackColor = true;
			// 
			// ddlIncludeComments
			// 
			this.ddlIncludeComments.FormattingEnabled = true;
			this.ddlIncludeComments.Location = new System.Drawing.Point(506, 60);
			this.ddlIncludeComments.Name = "ddlIncludeComments";
			this.ddlIncludeComments.Size = new System.Drawing.Size(121, 21);
			this.ddlIncludeComments.TabIndex = 35;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(386, 63);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 15);
			this.label7.TabIndex = 34;
			this.label7.Text = "Include Comments:";
			// 
			// txtConfigurationClassName
			// 
			this.txtConfigurationClassName.Location = new System.Drawing.Point(203, 61);
			this.txtConfigurationClassName.Name = "txtConfigurationClassName";
			this.txtConfigurationClassName.Size = new System.Drawing.Size(122, 20);
			this.txtConfigurationClassName.TabIndex = 31;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(203, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(122, 20);
			this.textBox1.TabIndex = 29;
			// 
			// txtContextInterfaceBaseClass
			// 
			this.txtContextInterfaceBaseClass.Location = new System.Drawing.Point(506, 32);
			this.txtContextInterfaceBaseClass.Name = "txtContextInterfaceBaseClass";
			this.txtContextInterfaceBaseClass.Size = new System.Drawing.Size(122, 20);
			this.txtContextInterfaceBaseClass.TabIndex = 8;
			// 
			// txtContextBaseClass
			// 
			this.txtContextBaseClass.Location = new System.Drawing.Point(507, 5);
			this.txtContextBaseClass.Name = "txtContextBaseClass";
			this.txtContextBaseClass.Size = new System.Drawing.Size(121, 20);
			this.txtContextBaseClass.TabIndex = 7;
			// 
			// txtDbContextName
			// 
			this.txtDbContextName.Location = new System.Drawing.Point(203, 5);
			this.txtDbContextName.Name = "txtDbContextName";
			this.txtDbContextName.Size = new System.Drawing.Size(122, 20);
			this.txtDbContextName.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(44, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 15);
			this.label5.TabIndex = 30;
			this.label5.Text = "Configuration Class Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 15);
			this.label2.TabIndex = 28;
			this.label2.Text = "Database Context Interface Name:";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.cbxUseCamelCase);
			this.flowLayoutPanel1.Controls.Add(this.cbxDisableGeographyTypes);
			this.flowLayoutPanel1.Controls.Add(this.cbxNullableShortHand);
			this.flowLayoutPanel1.Controls.Add(this.cbxPrependSchema);
			this.flowLayoutPanel1.Controls.Add(this.cbxIncludeQueryTraceOn);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(327, 129);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 251);
			this.flowLayoutPanel1.TabIndex = 26;
			// 
			// cbxUseCamelCase
			// 
			this.cbxUseCamelCase.AutoSize = true;
			this.cbxUseCamelCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUseCamelCase.Location = new System.Drawing.Point(3, 3);
			this.cbxUseCamelCase.Name = "cbxUseCamelCase";
			this.cbxUseCamelCase.Size = new System.Drawing.Size(118, 19);
			this.cbxUseCamelCase.TabIndex = 12;
			this.cbxUseCamelCase.Text = "Use Camel Case";
			this.cbxUseCamelCase.UseVisualStyleBackColor = true;
			// 
			// cbxDisableGeographyTypes
			// 
			this.cbxDisableGeographyTypes.AutoSize = true;
			this.cbxDisableGeographyTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDisableGeographyTypes.Location = new System.Drawing.Point(3, 28);
			this.cbxDisableGeographyTypes.Name = "cbxDisableGeographyTypes";
			this.cbxDisableGeographyTypes.Size = new System.Drawing.Size(166, 19);
			this.cbxDisableGeographyTypes.TabIndex = 11;
			this.cbxDisableGeographyTypes.Text = "Disable Geography Types";
			this.cbxDisableGeographyTypes.UseVisualStyleBackColor = true;
			// 
			// cbxNullableShortHand
			// 
			this.cbxNullableShortHand.AutoSize = true;
			this.cbxNullableShortHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxNullableShortHand.Location = new System.Drawing.Point(3, 53);
			this.cbxNullableShortHand.Name = "cbxNullableShortHand";
			this.cbxNullableShortHand.Size = new System.Drawing.Size(137, 19);
			this.cbxNullableShortHand.TabIndex = 20;
			this.cbxNullableShortHand.Text = "Nullable Short Hand";
			this.cbxNullableShortHand.UseVisualStyleBackColor = true;
			// 
			// cbxPrependSchema
			// 
			this.cbxPrependSchema.AutoSize = true;
			this.cbxPrependSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPrependSchema.Location = new System.Drawing.Point(3, 78);
			this.cbxPrependSchema.Name = "cbxPrependSchema";
			this.cbxPrependSchema.Size = new System.Drawing.Size(122, 19);
			this.cbxPrependSchema.TabIndex = 21;
			this.cbxPrependSchema.Text = "Prepend Schema";
			this.cbxPrependSchema.UseVisualStyleBackColor = true;
			// 
			// cbxIncludeQueryTraceOn
			// 
			this.cbxIncludeQueryTraceOn.AutoSize = true;
			this.cbxIncludeQueryTraceOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxIncludeQueryTraceOn.Location = new System.Drawing.Point(3, 103);
			this.cbxIncludeQueryTraceOn.Name = "cbxIncludeQueryTraceOn";
			this.cbxIncludeQueryTraceOn.Size = new System.Drawing.Size(212, 19);
			this.cbxIncludeQueryTraceOn.TabIndex = 22;
			this.cbxIncludeQueryTraceOn.Text = "Include Query Trace On 9481 Flag";
			this.cbxIncludeQueryTraceOn.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(386, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Context Base Class:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(336, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Context Interface Base Class:";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.cbxPartialClasses);
			this.flowLayoutPanel2.Controls.Add(this.cbxPartialInterfaces);
			this.flowLayoutPanel2.Controls.Add(this.cbxPartialContextInterface);
			this.flowLayoutPanel2.Controls.Add(this.cbxUseDataAnnotations);
			this.flowLayoutPanel2.Controls.Add(this.cbxGenerateContextClass);
			this.flowLayoutPanel2.Controls.Add(this.cbxGenerateUnitOfWorkInterface);
			this.flowLayoutPanel2.Controls.Add(this.cbxVirtualReverseNavProperty);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(26, 129);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(264, 251);
			this.flowLayoutPanel2.TabIndex = 27;
			// 
			// cbxPartialClasses
			// 
			this.cbxPartialClasses.AutoSize = true;
			this.cbxPartialClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPartialClasses.Location = new System.Drawing.Point(3, 3);
			this.cbxPartialClasses.Name = "cbxPartialClasses";
			this.cbxPartialClasses.Size = new System.Drawing.Size(107, 19);
			this.cbxPartialClasses.TabIndex = 10;
			this.cbxPartialClasses.Text = "Partial Classes";
			this.cbxPartialClasses.UseVisualStyleBackColor = true;
			// 
			// cbxPartialInterfaces
			// 
			this.cbxPartialInterfaces.AutoSize = true;
			this.cbxPartialInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPartialInterfaces.Location = new System.Drawing.Point(3, 28);
			this.cbxPartialInterfaces.Name = "cbxPartialInterfaces";
			this.cbxPartialInterfaces.Size = new System.Drawing.Size(117, 19);
			this.cbxPartialInterfaces.TabIndex = 16;
			this.cbxPartialInterfaces.Text = "Partial Interfaces";
			this.cbxPartialInterfaces.UseVisualStyleBackColor = true;
			// 
			// cbxPartialContextInterface
			// 
			this.cbxPartialContextInterface.AutoSize = true;
			this.cbxPartialContextInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPartialContextInterface.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cbxPartialContextInterface.Location = new System.Drawing.Point(3, 53);
			this.cbxPartialContextInterface.Name = "cbxPartialContextInterface";
			this.cbxPartialContextInterface.Size = new System.Drawing.Size(155, 19);
			this.cbxPartialContextInterface.TabIndex = 15;
			this.cbxPartialContextInterface.Text = "Partial Context Interface";
			this.cbxPartialContextInterface.UseVisualStyleBackColor = true;
			// 
			// cbxUseDataAnnotations
			// 
			this.cbxUseDataAnnotations.AutoSize = true;
			this.cbxUseDataAnnotations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUseDataAnnotations.Location = new System.Drawing.Point(3, 78);
			this.cbxUseDataAnnotations.Name = "cbxUseDataAnnotations";
			this.cbxUseDataAnnotations.Size = new System.Drawing.Size(144, 19);
			this.cbxUseDataAnnotations.TabIndex = 13;
			this.cbxUseDataAnnotations.Text = "Use Data Annotations";
			this.cbxUseDataAnnotations.UseVisualStyleBackColor = true;
			// 
			// cbxGenerateContextClass
			// 
			this.cbxGenerateContextClass.AutoSize = true;
			this.cbxGenerateContextClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxGenerateContextClass.Location = new System.Drawing.Point(3, 103);
			this.cbxGenerateContextClass.Name = "cbxGenerateContextClass";
			this.cbxGenerateContextClass.Size = new System.Drawing.Size(154, 19);
			this.cbxGenerateContextClass.TabIndex = 1;
			this.cbxGenerateContextClass.Text = "Generate Context Class";
			this.cbxGenerateContextClass.UseVisualStyleBackColor = true;
			// 
			// cbxGenerateUnitOfWorkInterface
			// 
			this.cbxGenerateUnitOfWorkInterface.AutoSize = true;
			this.cbxGenerateUnitOfWorkInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxGenerateUnitOfWorkInterface.Location = new System.Drawing.Point(3, 128);
			this.cbxGenerateUnitOfWorkInterface.Name = "cbxGenerateUnitOfWorkInterface";
			this.cbxGenerateUnitOfWorkInterface.Size = new System.Drawing.Size(198, 19);
			this.cbxGenerateUnitOfWorkInterface.TabIndex = 25;
			this.cbxGenerateUnitOfWorkInterface.Text = "Generate Unit Of Work Interface";
			this.cbxGenerateUnitOfWorkInterface.UseVisualStyleBackColor = true;
			// 
			// cbxVirtualReverseNavProperty
			// 
			this.cbxVirtualReverseNavProperty.AutoSize = true;
			this.cbxVirtualReverseNavProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxVirtualReverseNavProperty.Location = new System.Drawing.Point(3, 153);
			this.cbxVirtualReverseNavProperty.Name = "cbxVirtualReverseNavProperty";
			this.cbxVirtualReverseNavProperty.Size = new System.Drawing.Size(228, 19);
			this.cbxVirtualReverseNavProperty.TabIndex = 26;
			this.cbxVirtualReverseNavProperty.Text = "Virtual Reverse Navigation Properties";
			this.cbxVirtualReverseNavProperty.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Database Context Name:";
			// 
			// tcDatabaseObjects
			// 
			this.tcDatabaseObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcDatabaseObjects.Controls.Add(this.tpSettings);
			this.tcDatabaseObjects.Controls.Add(this.tpProjectSettings);
			this.tcDatabaseObjects.Controls.Add(this.tpTables);
			this.tcDatabaseObjects.Controls.Add(this.tpStoredProcedures);
			this.tcDatabaseObjects.Controls.Add(this.tpEnums);
			this.tcDatabaseObjects.Location = new System.Drawing.Point(0, 0);
			this.tcDatabaseObjects.Name = "tcDatabaseObjects";
			this.tcDatabaseObjects.SelectedIndex = 0;
			this.tcDatabaseObjects.Size = new System.Drawing.Size(651, 455);
			this.tcDatabaseObjects.TabIndex = 0;
			// 
			// tpProjectSettings
			// 
			this.tpProjectSettings.Controls.Add(this.panel1);
			this.tpProjectSettings.Controls.Add(this.gbNamespaces);
			this.tpProjectSettings.Location = new System.Drawing.Point(4, 22);
			this.tpProjectSettings.Name = "tpProjectSettings";
			this.tpProjectSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tpProjectSettings.Size = new System.Drawing.Size(643, 429);
			this.tpProjectSettings.TabIndex = 5;
			this.tpProjectSettings.Text = "Project Settings";
			this.tpProjectSettings.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.gbProjectFolders);
			this.panel1.Controls.Add(this.gbProjectNames);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(637, 293);
			this.panel1.TabIndex = 3;
			// 
			// gbProjectFolders
			// 
			this.gbProjectFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbProjectFolders.Controls.Add(this.flowLayoutPanel7);
			this.gbProjectFolders.Controls.Add(this.flowLayoutPanel6);
			this.gbProjectFolders.Location = new System.Drawing.Point(308, 3);
			this.gbProjectFolders.Name = "gbProjectFolders";
			this.gbProjectFolders.Size = new System.Drawing.Size(326, 287);
			this.gbProjectFolders.TabIndex = 1;
			this.gbProjectFolders.TabStop = false;
			this.gbProjectFolders.Text = "Project Folders";
			// 
			// flowLayoutPanel7
			// 
			this.flowLayoutPanel7.Controls.Add(this.txtContextFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtModelFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtModelDtoFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtModelInterfaceFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtRepositoryFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtRepositoryInterfaceFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtServiceFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtServiceInterfaceFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtSpecificationFolder);
			this.flowLayoutPanel7.Controls.Add(this.txtConfigurationFolder);
			this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel7.Location = new System.Drawing.Point(148, 16);
			this.flowLayoutPanel7.Name = "flowLayoutPanel7";
			this.flowLayoutPanel7.Size = new System.Drawing.Size(175, 268);
			this.flowLayoutPanel7.TabIndex = 11;
			// 
			// txtContextFolder
			// 
			this.txtContextFolder.Location = new System.Drawing.Point(3, 3);
			this.txtContextFolder.Name = "txtContextFolder";
			this.txtContextFolder.Size = new System.Drawing.Size(169, 20);
			this.txtContextFolder.TabIndex = 0;
			// 
			// txtModelFolder
			// 
			this.txtModelFolder.Location = new System.Drawing.Point(3, 29);
			this.txtModelFolder.Name = "txtModelFolder";
			this.txtModelFolder.Size = new System.Drawing.Size(169, 20);
			this.txtModelFolder.TabIndex = 1;
			// 
			// txtModelDtoFolder
			// 
			this.txtModelDtoFolder.Location = new System.Drawing.Point(3, 55);
			this.txtModelDtoFolder.Name = "txtModelDtoFolder";
			this.txtModelDtoFolder.Size = new System.Drawing.Size(169, 20);
			this.txtModelDtoFolder.TabIndex = 2;
			// 
			// txtModelInterfaceFolder
			// 
			this.txtModelInterfaceFolder.Location = new System.Drawing.Point(3, 81);
			this.txtModelInterfaceFolder.Name = "txtModelInterfaceFolder";
			this.txtModelInterfaceFolder.Size = new System.Drawing.Size(169, 20);
			this.txtModelInterfaceFolder.TabIndex = 3;
			// 
			// txtRepositoryFolder
			// 
			this.txtRepositoryFolder.Location = new System.Drawing.Point(3, 107);
			this.txtRepositoryFolder.Name = "txtRepositoryFolder";
			this.txtRepositoryFolder.Size = new System.Drawing.Size(169, 20);
			this.txtRepositoryFolder.TabIndex = 4;
			// 
			// txtRepositoryInterfaceFolder
			// 
			this.txtRepositoryInterfaceFolder.Location = new System.Drawing.Point(3, 133);
			this.txtRepositoryInterfaceFolder.Name = "txtRepositoryInterfaceFolder";
			this.txtRepositoryInterfaceFolder.Size = new System.Drawing.Size(169, 20);
			this.txtRepositoryInterfaceFolder.TabIndex = 5;
			// 
			// txtServiceFolder
			// 
			this.txtServiceFolder.Location = new System.Drawing.Point(3, 159);
			this.txtServiceFolder.Name = "txtServiceFolder";
			this.txtServiceFolder.Size = new System.Drawing.Size(169, 20);
			this.txtServiceFolder.TabIndex = 6;
			// 
			// txtServiceInterfaceFolder
			// 
			this.txtServiceInterfaceFolder.Location = new System.Drawing.Point(3, 185);
			this.txtServiceInterfaceFolder.Name = "txtServiceInterfaceFolder";
			this.txtServiceInterfaceFolder.Size = new System.Drawing.Size(169, 20);
			this.txtServiceInterfaceFolder.TabIndex = 7;
			// 
			// txtSpecificationFolder
			// 
			this.txtSpecificationFolder.Location = new System.Drawing.Point(3, 211);
			this.txtSpecificationFolder.Name = "txtSpecificationFolder";
			this.txtSpecificationFolder.Size = new System.Drawing.Size(169, 20);
			this.txtSpecificationFolder.TabIndex = 8;
			// 
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel6.Controls.Add(this.label24);
			this.flowLayoutPanel6.Controls.Add(this.label25);
			this.flowLayoutPanel6.Controls.Add(this.label26);
			this.flowLayoutPanel6.Controls.Add(this.label27);
			this.flowLayoutPanel6.Controls.Add(this.label28);
			this.flowLayoutPanel6.Controls.Add(this.label29);
			this.flowLayoutPanel6.Controls.Add(this.label30);
			this.flowLayoutPanel6.Controls.Add(this.label31);
			this.flowLayoutPanel6.Controls.Add(this.label32);
			this.flowLayoutPanel6.Controls.Add(this.label36);
			this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(5);
			this.flowLayoutPanel6.Size = new System.Drawing.Size(144, 268);
			this.flowLayoutPanel6.TabIndex = 10;
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(8, 8);
			this.label24.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label24.Name = "label24";
			this.label24.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label24.Size = new System.Drawing.Size(118, 20);
			this.label24.TabIndex = 0;
			this.label24.Text = "Context:";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(8, 33);
			this.label25.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label25.Name = "label25";
			this.label25.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label25.Size = new System.Drawing.Size(118, 20);
			this.label25.TabIndex = 8;
			this.label25.Text = "Model:";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(8, 58);
			this.label26.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label26.Name = "label26";
			this.label26.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label26.Size = new System.Drawing.Size(118, 20);
			this.label26.TabIndex = 6;
			this.label26.Text = "Model DTO:";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(8, 83);
			this.label27.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label27.Name = "label27";
			this.label27.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label27.Size = new System.Drawing.Size(118, 20);
			this.label27.TabIndex = 7;
			this.label27.Text = "Model Interface:";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(8, 108);
			this.label28.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label28.Name = "label28";
			this.label28.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label28.Size = new System.Drawing.Size(118, 20);
			this.label28.TabIndex = 5;
			this.label28.Text = "Repository:";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(8, 133);
			this.label29.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label29.Name = "label29";
			this.label29.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label29.Size = new System.Drawing.Size(118, 20);
			this.label29.TabIndex = 4;
			this.label29.Text = "Repository Interface:";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(8, 158);
			this.label30.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label30.Name = "label30";
			this.label30.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label30.Size = new System.Drawing.Size(118, 20);
			this.label30.TabIndex = 2;
			this.label30.Text = "Service:";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label31
			// 
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(8, 183);
			this.label31.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label31.Name = "label31";
			this.label31.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label31.Size = new System.Drawing.Size(118, 20);
			this.label31.TabIndex = 1;
			this.label31.Text = "Service Interface:";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(8, 208);
			this.label32.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label32.Name = "label32";
			this.label32.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label32.Size = new System.Drawing.Size(118, 20);
			this.label32.TabIndex = 3;
			this.label32.Text = "Specification:";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbProjectNames
			// 
			this.gbProjectNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gbProjectNames.Controls.Add(this.flowLayoutPanel5);
			this.gbProjectNames.Controls.Add(this.flowLayoutPanel4);
			this.gbProjectNames.Location = new System.Drawing.Point(3, 3);
			this.gbProjectNames.Name = "gbProjectNames";
			this.gbProjectNames.Size = new System.Drawing.Size(302, 287);
			this.gbProjectNames.TabIndex = 0;
			this.gbProjectNames.TabStop = false;
			this.gbProjectNames.Text = "Project Names";
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.Controls.Add(this.ddlContextProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlModelProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlModelDtoProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlModelInterfaceProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlRepositoryProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlRepositoryInterfaceProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlServiceProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlServiceInterfaceProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlSpecificationProject);
			this.flowLayoutPanel5.Controls.Add(this.ddlConfigurationProject);
			this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.flowLayoutPanel5.Location = new System.Drawing.Point(142, 16);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(157, 268);
			this.flowLayoutPanel5.TabIndex = 10;
			// 
			// ddlContextProject
			// 
			this.ddlContextProject.FormattingEnabled = true;
			this.ddlContextProject.Location = new System.Drawing.Point(3, 3);
			this.ddlContextProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlContextProject.Name = "ddlContextProject";
			this.ddlContextProject.Size = new System.Drawing.Size(151, 21);
			this.ddlContextProject.TabIndex = 1;
			// 
			// ddlModelProject
			// 
			this.ddlModelProject.FormattingEnabled = true;
			this.ddlModelProject.Location = new System.Drawing.Point(3, 29);
			this.ddlModelProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlModelProject.Name = "ddlModelProject";
			this.ddlModelProject.Size = new System.Drawing.Size(151, 21);
			this.ddlModelProject.TabIndex = 0;
			// 
			// ddlModelDtoProject
			// 
			this.ddlModelDtoProject.FormattingEnabled = true;
			this.ddlModelDtoProject.Location = new System.Drawing.Point(3, 55);
			this.ddlModelDtoProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlModelDtoProject.Name = "ddlModelDtoProject";
			this.ddlModelDtoProject.Size = new System.Drawing.Size(151, 21);
			this.ddlModelDtoProject.TabIndex = 2;
			// 
			// ddlModelInterfaceProject
			// 
			this.ddlModelInterfaceProject.FormattingEnabled = true;
			this.ddlModelInterfaceProject.Location = new System.Drawing.Point(3, 81);
			this.ddlModelInterfaceProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlModelInterfaceProject.Name = "ddlModelInterfaceProject";
			this.ddlModelInterfaceProject.Size = new System.Drawing.Size(151, 21);
			this.ddlModelInterfaceProject.TabIndex = 3;
			// 
			// ddlRepositoryProject
			// 
			this.ddlRepositoryProject.FormattingEnabled = true;
			this.ddlRepositoryProject.Location = new System.Drawing.Point(3, 107);
			this.ddlRepositoryProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlRepositoryProject.Name = "ddlRepositoryProject";
			this.ddlRepositoryProject.Size = new System.Drawing.Size(151, 21);
			this.ddlRepositoryProject.TabIndex = 4;
			// 
			// ddlRepositoryInterfaceProject
			// 
			this.ddlRepositoryInterfaceProject.FormattingEnabled = true;
			this.ddlRepositoryInterfaceProject.Location = new System.Drawing.Point(3, 133);
			this.ddlRepositoryInterfaceProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlRepositoryInterfaceProject.Name = "ddlRepositoryInterfaceProject";
			this.ddlRepositoryInterfaceProject.Size = new System.Drawing.Size(151, 21);
			this.ddlRepositoryInterfaceProject.TabIndex = 5;
			// 
			// ddlServiceProject
			// 
			this.ddlServiceProject.FormattingEnabled = true;
			this.ddlServiceProject.Location = new System.Drawing.Point(3, 159);
			this.ddlServiceProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlServiceProject.Name = "ddlServiceProject";
			this.ddlServiceProject.Size = new System.Drawing.Size(151, 21);
			this.ddlServiceProject.TabIndex = 6;
			// 
			// ddlServiceInterfaceProject
			// 
			this.ddlServiceInterfaceProject.FormattingEnabled = true;
			this.ddlServiceInterfaceProject.Location = new System.Drawing.Point(3, 185);
			this.ddlServiceInterfaceProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlServiceInterfaceProject.Name = "ddlServiceInterfaceProject";
			this.ddlServiceInterfaceProject.Size = new System.Drawing.Size(151, 21);
			this.ddlServiceInterfaceProject.TabIndex = 7;
			// 
			// ddlSpecificationProject
			// 
			this.ddlSpecificationProject.FormattingEnabled = true;
			this.ddlSpecificationProject.Location = new System.Drawing.Point(3, 211);
			this.ddlSpecificationProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlSpecificationProject.Name = "ddlSpecificationProject";
			this.ddlSpecificationProject.Size = new System.Drawing.Size(151, 21);
			this.ddlSpecificationProject.TabIndex = 8;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel4.Controls.Add(this.label6);
			this.flowLayoutPanel4.Controls.Add(this.label15);
			this.flowLayoutPanel4.Controls.Add(this.label13);
			this.flowLayoutPanel4.Controls.Add(this.label14);
			this.flowLayoutPanel4.Controls.Add(this.label12);
			this.flowLayoutPanel4.Controls.Add(this.label11);
			this.flowLayoutPanel4.Controls.Add(this.label9);
			this.flowLayoutPanel4.Controls.Add(this.label8);
			this.flowLayoutPanel4.Controls.Add(this.label10);
			this.flowLayoutPanel4.Controls.Add(this.label35);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(5);
			this.flowLayoutPanel4.Size = new System.Drawing.Size(136, 268);
			this.flowLayoutPanel4.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 8);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label6.Size = new System.Drawing.Size(118, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Context:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(8, 33);
			this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label15.Name = "label15";
			this.label15.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label15.Size = new System.Drawing.Size(118, 20);
			this.label15.TabIndex = 8;
			this.label15.Text = "Model:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(8, 58);
			this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label13.Name = "label13";
			this.label13.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label13.Size = new System.Drawing.Size(118, 20);
			this.label13.TabIndex = 6;
			this.label13.Text = "Model DTO:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(8, 83);
			this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label14.Name = "label14";
			this.label14.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label14.Size = new System.Drawing.Size(118, 20);
			this.label14.TabIndex = 7;
			this.label14.Text = "Model Interface:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(8, 108);
			this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label12.Name = "label12";
			this.label12.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label12.Size = new System.Drawing.Size(118, 20);
			this.label12.TabIndex = 5;
			this.label12.Text = "Repository:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(8, 133);
			this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label11.Name = "label11";
			this.label11.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label11.Size = new System.Drawing.Size(118, 20);
			this.label11.TabIndex = 4;
			this.label11.Text = "Repository Interface:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 158);
			this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label9.Size = new System.Drawing.Size(118, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Service:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 183);
			this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label8.Size = new System.Drawing.Size(118, 20);
			this.label8.TabIndex = 1;
			this.label8.Text = "Service Interface:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(8, 208);
			this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label10.Name = "label10";
			this.label10.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label10.Size = new System.Drawing.Size(118, 20);
			this.label10.TabIndex = 3;
			this.label10.Text = "Specification:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbNamespaces
			// 
			this.gbNamespaces.Controls.Add(this.txtConfigurationNamespace);
			this.gbNamespaces.Controls.Add(this.label34);
			this.gbNamespaces.Controls.Add(this.txtSpecificationNamespace);
			this.gbNamespaces.Controls.Add(this.label33);
			this.gbNamespaces.Controls.Add(this.txtServiceInterfaceNamespace);
			this.gbNamespaces.Controls.Add(this.txtServiceNamespace);
			this.gbNamespaces.Controls.Add(this.label23);
			this.gbNamespaces.Controls.Add(this.label22);
			this.gbNamespaces.Controls.Add(this.txtRepositoryInterfaceNamespace);
			this.gbNamespaces.Controls.Add(this.label21);
			this.gbNamespaces.Controls.Add(this.txtRepositoryNamespace);
			this.gbNamespaces.Controls.Add(this.label20);
			this.gbNamespaces.Controls.Add(this.txtModelDtoNamespace);
			this.gbNamespaces.Controls.Add(this.label19);
			this.gbNamespaces.Controls.Add(this.txtModelInterfaceNamespace);
			this.gbNamespaces.Controls.Add(this.label18);
			this.gbNamespaces.Controls.Add(this.txtModelNamespace);
			this.gbNamespaces.Controls.Add(this.label17);
			this.gbNamespaces.Controls.Add(this.txtContextNamespace);
			this.gbNamespaces.Controls.Add(this.label16);
			this.gbNamespaces.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gbNamespaces.Location = new System.Drawing.Point(3, 302);
			this.gbNamespaces.Name = "gbNamespaces";
			this.gbNamespaces.Size = new System.Drawing.Size(637, 124);
			this.gbNamespaces.TabIndex = 2;
			this.gbNamespaces.TabStop = false;
			this.gbNamespaces.Text = "Namespaces";
			// 
			// txtConfigurationNamespace
			// 
			this.txtConfigurationNamespace.Location = new System.Drawing.Point(80, 69);
			this.txtConfigurationNamespace.Name = "txtConfigurationNamespace";
			this.txtConfigurationNamespace.Size = new System.Drawing.Size(127, 20);
			this.txtConfigurationNamespace.TabIndex = 19;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(3, 72);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(72, 13);
			this.label34.TabIndex = 18;
			this.label34.Text = "Configuration:";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSpecificationNamespace
			// 
			this.txtSpecificationNamespace.Location = new System.Drawing.Point(80, 43);
			this.txtSpecificationNamespace.Name = "txtSpecificationNamespace";
			this.txtSpecificationNamespace.Size = new System.Drawing.Size(127, 20);
			this.txtSpecificationNamespace.TabIndex = 17;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(3, 47);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(71, 13);
			this.label33.TabIndex = 16;
			this.label33.Text = "Specification:";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtServiceInterfaceNamespace
			// 
			this.txtServiceInterfaceNamespace.Location = new System.Drawing.Point(481, 55);
			this.txtServiceInterfaceNamespace.Name = "txtServiceInterfaceNamespace";
			this.txtServiceInterfaceNamespace.Size = new System.Drawing.Size(147, 20);
			this.txtServiceInterfaceNamespace.TabIndex = 15;
			// 
			// txtServiceNamespace
			// 
			this.txtServiceNamespace.Location = new System.Drawing.Point(279, 43);
			this.txtServiceNamespace.Name = "txtServiceNamespace";
			this.txtServiceNamespace.Size = new System.Drawing.Size(135, 20);
			this.txtServiceNamespace.TabIndex = 14;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(422, 47);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(53, 35);
			this.label23.TabIndex = 13;
			this.label23.Text = "Service Interface:";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(213, 46);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(59, 14);
			this.label22.TabIndex = 12;
			this.label22.Text = "Service:";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRepositoryInterfaceNamespace
			// 
			this.txtRepositoryInterfaceNamespace.Location = new System.Drawing.Point(481, 17);
			this.txtRepositoryInterfaceNamespace.Name = "txtRepositoryInterfaceNamespace";
			this.txtRepositoryInterfaceNamespace.Size = new System.Drawing.Size(147, 20);
			this.txtRepositoryInterfaceNamespace.TabIndex = 11;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(414, 9);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(63, 35);
			this.label21.TabIndex = 10;
			this.label21.Text = "Repository Interface:";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRepositoryNamespace
			// 
			this.txtRepositoryNamespace.Location = new System.Drawing.Point(279, 17);
			this.txtRepositoryNamespace.Name = "txtRepositoryNamespace";
			this.txtRepositoryNamespace.Size = new System.Drawing.Size(135, 20);
			this.txtRepositoryNamespace.TabIndex = 9;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(213, 20);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(60, 13);
			this.label20.TabIndex = 8;
			this.label20.Text = "Repository:";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtModelDtoNamespace
			// 
			this.txtModelDtoNamespace.Location = new System.Drawing.Point(279, 95);
			this.txtModelDtoNamespace.Name = "txtModelDtoNamespace";
			this.txtModelDtoNamespace.Size = new System.Drawing.Size(135, 20);
			this.txtModelDtoNamespace.TabIndex = 7;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(213, 98);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(59, 13);
			this.label19.TabIndex = 6;
			this.label19.Text = "Model Dto:";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtModelInterfaceNamespace
			// 
			this.txtModelInterfaceNamespace.Location = new System.Drawing.Point(481, 91);
			this.txtModelInterfaceNamespace.Name = "txtModelInterfaceNamespace";
			this.txtModelInterfaceNamespace.Size = new System.Drawing.Size(147, 20);
			this.txtModelInterfaceNamespace.TabIndex = 5;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(414, 84);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(61, 33);
			this.label18.TabIndex = 4;
			this.label18.Text = "Model Interface:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtModelNamespace
			// 
			this.txtModelNamespace.Location = new System.Drawing.Point(279, 69);
			this.txtModelNamespace.Name = "txtModelNamespace";
			this.txtModelNamespace.Size = new System.Drawing.Size(135, 20);
			this.txtModelNamespace.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(213, 72);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(59, 13);
			this.label17.TabIndex = 2;
			this.label17.Text = "Model:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContextNamespace
			// 
			this.txtContextNamespace.Location = new System.Drawing.Point(80, 17);
			this.txtContextNamespace.Name = "txtContextNamespace";
			this.txtContextNamespace.Size = new System.Drawing.Size(127, 20);
			this.txtContextNamespace.TabIndex = 1;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(3, 20);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(71, 17);
			this.label16.TabIndex = 0;
			this.label16.Text = "Context:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label35
			// 
			this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(8, 233);
			this.label35.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label35.Name = "label35";
			this.label35.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label35.Size = new System.Drawing.Size(118, 20);
			this.label35.TabIndex = 9;
			this.label35.Text = "Configuration:";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(8, 233);
			this.label36.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.label36.Name = "label36";
			this.label36.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label36.Size = new System.Drawing.Size(118, 20);
			this.label36.TabIndex = 10;
			this.label36.Text = "Configuration:";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ddlConfigurationProject
			// 
			this.ddlConfigurationProject.FormattingEnabled = true;
			this.ddlConfigurationProject.Location = new System.Drawing.Point(3, 237);
			this.ddlConfigurationProject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
			this.ddlConfigurationProject.Name = "ddlConfigurationProject";
			this.ddlConfigurationProject.Size = new System.Drawing.Size(151, 21);
			this.ddlConfigurationProject.TabIndex = 9;
			// 
			// txtConfigurationFolder
			// 
			this.txtConfigurationFolder.Location = new System.Drawing.Point(3, 237);
			this.txtConfigurationFolder.Name = "txtConfigurationFolder";
			this.txtConfigurationFolder.Size = new System.Drawing.Size(169, 20);
			this.txtConfigurationFolder.TabIndex = 9;
			// 
			// DatabaseObjectSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 488);
			this.ControlBox = false;
			this.Controls.Add(this.flowLayoutPanel3);
			this.Controls.Add(this.tcDatabaseObjects);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "DatabaseObjectSelector";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Database Object Selector";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatabaseObjectSelector_FormClosing);
			this.Load += new System.EventHandler(this.DatabaseObjectSelector_Load);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.tpEnums.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvEnums)).EndInit();
			this.tpStoredProcedures.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvStoredProcedures)).EndInit();
			this.tpTables.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvTables)).EndInit();
			this.gbTables.ResumeLayout(false);
			this.gbTables.PerformLayout();
			this.tpSettings.ResumeLayout(false);
			this.tpSettings.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.tcDatabaseObjects.ResumeLayout(false);
			this.tpProjectSettings.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.gbProjectFolders.ResumeLayout(false);
			this.flowLayoutPanel7.ResumeLayout(false);
			this.flowLayoutPanel7.PerformLayout();
			this.flowLayoutPanel6.ResumeLayout(false);
			this.gbProjectNames.ResumeLayout(false);
			this.flowLayoutPanel5.ResumeLayout(false);
			this.flowLayoutPanel4.ResumeLayout(false);
			this.gbNamespaces.ResumeLayout(false);
			this.gbNamespaces.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TabPage tpEnums;
		private System.Windows.Forms.TabPage tpStoredProcedures;
		private System.Windows.Forms.DataGridView gvStoredProcedures;
		private System.Windows.Forms.TabPage tpTables;
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
		private System.Windows.Forms.TabPage tpSettings;
		private System.Windows.Forms.ComboBox ddlIncludeComments;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtConfigurationClassName;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtContextInterfaceBaseClass;
		private System.Windows.Forms.TextBox txtContextBaseClass;
		private System.Windows.Forms.TextBox txtDbContextName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.CheckBox cbxUseCamelCase;
		private System.Windows.Forms.CheckBox cbxDisableGeographyTypes;
		private System.Windows.Forms.CheckBox cbxNullableShortHand;
		private System.Windows.Forms.CheckBox cbxPrependSchema;
		private System.Windows.Forms.CheckBox cbxIncludeQueryTraceOn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.CheckBox cbxPartialClasses;
		private System.Windows.Forms.CheckBox cbxPartialInterfaces;
		private System.Windows.Forms.CheckBox cbxPartialContextInterface;
		private System.Windows.Forms.CheckBox cbxUseDataAnnotations;
		private System.Windows.Forms.CheckBox cbxGenerateContextClass;
		private System.Windows.Forms.CheckBox cbxGenerateUnitOfWorkInterface;
		private System.Windows.Forms.CheckBox cbxVirtualReverseNavProperty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tcDatabaseObjects;
		private System.Windows.Forms.DataGridView gvEnums;
		private System.Windows.Forms.DataGridViewCheckBoxColumn EnumSelect;
		private System.Windows.Forms.DataGridViewTextBoxColumn EnumName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn StoredProcSelect;
		private System.Windows.Forms.DataGridViewTextBoxColumn StoredProcName;
		private System.Windows.Forms.TabPage tpProjectSettings;
		private System.Windows.Forms.GroupBox gbProjectNames;
		private System.Windows.Forms.GroupBox gbProjectFolders;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox gbNamespaces;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.TextBox txtRepositoryInterfaceNamespace;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtRepositoryNamespace;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtModelDtoNamespace;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtModelInterfaceNamespace;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtModelNamespace;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtContextNamespace;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox txtConfigurationNamespace;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox txtSpecificationNamespace;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox txtServiceInterfaceNamespace;
		private System.Windows.Forms.TextBox txtServiceNamespace;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox ddlContextProject;
		private System.Windows.Forms.ComboBox ddlModelProject;
		private System.Windows.Forms.ComboBox ddlModelDtoProject;
		private System.Windows.Forms.ComboBox ddlModelInterfaceProject;
		private System.Windows.Forms.ComboBox ddlRepositoryProject;
		private System.Windows.Forms.ComboBox ddlRepositoryInterfaceProject;
		private System.Windows.Forms.ComboBox ddlServiceProject;
		private System.Windows.Forms.ComboBox ddlServiceInterfaceProject;
		private System.Windows.Forms.ComboBox ddlSpecificationProject;
		private System.Windows.Forms.TextBox txtContextFolder;
		private System.Windows.Forms.TextBox txtModelFolder;
		private System.Windows.Forms.TextBox txtModelDtoFolder;
		private System.Windows.Forms.TextBox txtModelInterfaceFolder;
		private System.Windows.Forms.TextBox txtRepositoryFolder;
		private System.Windows.Forms.TextBox txtRepositoryInterfaceFolder;
		private System.Windows.Forms.TextBox txtServiceFolder;
		private System.Windows.Forms.TextBox txtServiceInterfaceFolder;
		private System.Windows.Forms.TextBox txtSpecificationFolder;
		private System.Windows.Forms.TextBox txtConfigurationFolder;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.ComboBox ddlConfigurationProject;
		private System.Windows.Forms.Label label35;
	}
}