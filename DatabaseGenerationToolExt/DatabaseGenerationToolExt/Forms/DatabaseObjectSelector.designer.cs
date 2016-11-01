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
			this.tcDatabaseObjects = new System.Windows.Forms.TabControl();
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.ddlIncludeComments = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtConfigurationClassName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cbxUseCamelCase = new System.Windows.Forms.CheckBox();
			this.cbxDisableGeographyTypes = new System.Windows.Forms.CheckBox();
			this.cbxNullableShortHand = new System.Windows.Forms.CheckBox();
			this.cbxPrivateSetterForComputedColumns = new System.Windows.Forms.CheckBox();
			this.cbxPrependSchema = new System.Windows.Forms.CheckBox();
			this.cbxIncludeQueryTraceOn = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtContextInterfaceBaseClass = new System.Windows.Forms.TextBox();
			this.txtContextBaseClass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.cbxPartialClasses = new System.Windows.Forms.CheckBox();
			this.cbxPartialInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxPartialContextInterface = new System.Windows.Forms.CheckBox();
			this.cbxUseDataAnnotations = new System.Windows.Forms.CheckBox();
			this.cbxGenerateContextClass = new System.Windows.Forms.CheckBox();
			this.cbxGenerateUnitOfWorkInterface = new System.Windows.Forms.CheckBox();
			this.cbxVirtualReverseNavProperty = new System.Windows.Forms.CheckBox();
			this.txtDbContextName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tpTables = new System.Windows.Forms.TabPage();
			this.gvTables = new System.Windows.Forms.DataGridView();
			this.gbTables = new System.Windows.Forms.GroupBox();
			this.cbxServiceInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxServices = new System.Windows.Forms.CheckBox();
			this.cbxRepositoryInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxRepositories = new System.Windows.Forms.CheckBox();
			this.cbxModelInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxModels = new System.Windows.Forms.CheckBox();
			this.tpViews = new System.Windows.Forms.TabPage();
			this.gvViews = new System.Windows.Forms.DataGridView();
			this.ViewSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpStoredProcedures = new System.Windows.Forms.TabPage();
			this.gvStoredProcedures = new System.Windows.Forms.DataGridView();
			this.tpEnums = new System.Windows.Forms.TabPage();
			this.gvEnums = new System.Windows.Forms.DataGridView();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.TableSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableModel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableIModel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableRepository = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableIRepository = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Service = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ServiceInterface = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tcDatabaseObjects.SuspendLayout();
			this.tpSettings.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.tpTables.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvTables)).BeginInit();
			this.gbTables.SuspendLayout();
			this.tpViews.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvViews)).BeginInit();
			this.tpStoredProcedures.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvStoredProcedures)).BeginInit();
			this.tpEnums.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvEnums)).BeginInit();
			this.flowLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcDatabaseObjects
			// 
			this.tcDatabaseObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcDatabaseObjects.Controls.Add(this.tpSettings);
			this.tcDatabaseObjects.Controls.Add(this.tpTables);
			this.tcDatabaseObjects.Controls.Add(this.tpViews);
			this.tcDatabaseObjects.Controls.Add(this.tpStoredProcedures);
			this.tcDatabaseObjects.Controls.Add(this.tpEnums);
			this.tcDatabaseObjects.Location = new System.Drawing.Point(0, 0);
			this.tcDatabaseObjects.Name = "tcDatabaseObjects";
			this.tcDatabaseObjects.SelectedIndex = 0;
			this.tcDatabaseObjects.Size = new System.Drawing.Size(642, 412);
			this.tcDatabaseObjects.TabIndex = 0;
			this.tcDatabaseObjects.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcDatabaseObjects_Selected);
			// 
			// tpSettings
			// 
			this.tpSettings.Controls.Add(this.ddlIncludeComments);
			this.tpSettings.Controls.Add(this.label7);
			this.tpSettings.Controls.Add(this.txtConfigurationClassName);
			this.tpSettings.Controls.Add(this.label5);
			this.tpSettings.Controls.Add(this.textBox1);
			this.tpSettings.Controls.Add(this.label2);
			this.tpSettings.Controls.Add(this.flowLayoutPanel1);
			this.tpSettings.Controls.Add(this.label4);
			this.tpSettings.Controls.Add(this.txtContextInterfaceBaseClass);
			this.tpSettings.Controls.Add(this.txtContextBaseClass);
			this.tpSettings.Controls.Add(this.label3);
			this.tpSettings.Controls.Add(this.flowLayoutPanel2);
			this.tpSettings.Controls.Add(this.txtDbContextName);
			this.tpSettings.Controls.Add(this.label1);
			this.tpSettings.Location = new System.Drawing.Point(4, 22);
			this.tpSettings.Name = "tpSettings";
			this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tpSettings.Size = new System.Drawing.Size(634, 386);
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(203, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(122, 20);
			this.textBox1.TabIndex = 29;
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
			this.flowLayoutPanel1.Controls.Add(this.cbxPrivateSetterForComputedColumns);
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
			// cbxPrivateSetterForComputedColumns
			// 
			this.cbxPrivateSetterForComputedColumns.AutoSize = true;
			this.cbxPrivateSetterForComputedColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPrivateSetterForComputedColumns.Location = new System.Drawing.Point(3, 78);
			this.cbxPrivateSetterForComputedColumns.Name = "cbxPrivateSetterForComputedColumns";
			this.cbxPrivateSetterForComputedColumns.Size = new System.Drawing.Size(253, 19);
			this.cbxPrivateSetterForComputedColumns.TabIndex = 19;
			this.cbxPrivateSetterForComputedColumns.Text = "Use Private Setter For Computer Columns";
			this.cbxPrivateSetterForComputedColumns.UseVisualStyleBackColor = true;
			// 
			// cbxPrependSchema
			// 
			this.cbxPrependSchema.AutoSize = true;
			this.cbxPrependSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPrependSchema.Location = new System.Drawing.Point(3, 103);
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
			this.cbxIncludeQueryTraceOn.Location = new System.Drawing.Point(3, 128);
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
			// txtDbContextName
			// 
			this.txtDbContextName.Location = new System.Drawing.Point(203, 5);
			this.txtDbContextName.Name = "txtDbContextName";
			this.txtDbContextName.Size = new System.Drawing.Size(122, 20);
			this.txtDbContextName.TabIndex = 5;
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
			// tpTables
			// 
			this.tpTables.Controls.Add(this.gvTables);
			this.tpTables.Controls.Add(this.gbTables);
			this.tpTables.Location = new System.Drawing.Point(4, 22);
			this.tpTables.Name = "tpTables";
			this.tpTables.Padding = new System.Windows.Forms.Padding(3);
			this.tpTables.Size = new System.Drawing.Size(634, 386);
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
            this.TableModel,
            this.TableIModel,
            this.TableRepository,
            this.TableIRepository,
            this.Service,
            this.ServiceInterface});
			this.gvTables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvTables.Location = new System.Drawing.Point(3, 85);
			this.gvTables.Name = "gvTables";
			this.gvTables.RowHeadersVisible = false;
			this.gvTables.ShowEditingIcon = false;
			this.gvTables.Size = new System.Drawing.Size(628, 298);
			this.gvTables.TabIndex = 2;
			this.gvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellContentClick);
			this.gvTables.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellValueChanged);
			// 
			// gbTables
			// 
			this.gbTables.Controls.Add(this.cbxServiceInterfaces);
			this.gbTables.Controls.Add(this.cbxServices);
			this.gbTables.Controls.Add(this.cbxRepositoryInterfaces);
			this.gbTables.Controls.Add(this.cbxRepositories);
			this.gbTables.Controls.Add(this.cbxModelInterfaces);
			this.gbTables.Controls.Add(this.cbxModels);
			this.gbTables.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTables.Location = new System.Drawing.Point(3, 3);
			this.gbTables.Name = "gbTables";
			this.gbTables.Size = new System.Drawing.Size(628, 82);
			this.gbTables.TabIndex = 0;
			this.gbTables.TabStop = false;
			this.gbTables.Text = "Table Settings";
			// 
			// cbxServiceInterfaces
			// 
			this.cbxServiceInterfaces.AutoSize = true;
			this.cbxServiceInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxServiceInterfaces.Location = new System.Drawing.Point(338, 51);
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
			this.cbxServices.Location = new System.Drawing.Point(338, 23);
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
			this.cbxRepositoryInterfaces.Location = new System.Drawing.Point(170, 51);
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
			this.cbxRepositories.Location = new System.Drawing.Point(170, 23);
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
			// cbxModels
			// 
			this.cbxModels.AutoSize = true;
			this.cbxModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxModels.Location = new System.Drawing.Point(7, 23);
			this.cbxModels.Name = "cbxModels";
			this.cbxModels.Size = new System.Drawing.Size(74, 17);
			this.cbxModels.TabIndex = 0;
			this.cbxModels.Text = "All Models";
			this.cbxModels.UseVisualStyleBackColor = true;
			this.cbxModels.CheckStateChanged += new System.EventHandler(this.cbxModels_CheckStateChanged);
			// 
			// tpViews
			// 
			this.tpViews.Controls.Add(this.gvViews);
			this.tpViews.Location = new System.Drawing.Point(4, 22);
			this.tpViews.Name = "tpViews";
			this.tpViews.Padding = new System.Windows.Forms.Padding(3);
			this.tpViews.Size = new System.Drawing.Size(634, 386);
			this.tpViews.TabIndex = 1;
			this.tpViews.Text = "Views";
			this.tpViews.UseVisualStyleBackColor = true;
			// 
			// gvViews
			// 
			this.gvViews.AllowUserToAddRows = false;
			this.gvViews.AllowUserToDeleteRows = false;
			this.gvViews.AllowUserToResizeRows = false;
			this.gvViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvViews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewSelect,
            this.ViewName});
			this.gvViews.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvViews.Location = new System.Drawing.Point(3, 3);
			this.gvViews.Name = "gvViews";
			this.gvViews.RowHeadersVisible = false;
			this.gvViews.Size = new System.Drawing.Size(628, 380);
			this.gvViews.TabIndex = 0;
			// 
			// ViewSelect
			// 
			this.ViewSelect.HeaderText = "";
			this.ViewSelect.Name = "ViewSelect";
			// 
			// ViewName
			// 
			this.ViewName.HeaderText = "View Name";
			this.ViewName.Name = "ViewName";
			this.ViewName.ReadOnly = true;
			// 
			// tpStoredProcedures
			// 
			this.tpStoredProcedures.Controls.Add(this.gvStoredProcedures);
			this.tpStoredProcedures.Location = new System.Drawing.Point(4, 22);
			this.tpStoredProcedures.Name = "tpStoredProcedures";
			this.tpStoredProcedures.Padding = new System.Windows.Forms.Padding(3);
			this.tpStoredProcedures.Size = new System.Drawing.Size(634, 386);
			this.tpStoredProcedures.TabIndex = 2;
			this.tpStoredProcedures.Text = "Stored Procedures";
			this.tpStoredProcedures.UseVisualStyleBackColor = true;
			// 
			// gvStoredProcedures
			// 
			this.gvStoredProcedures.AllowUserToAddRows = false;
			this.gvStoredProcedures.AllowUserToDeleteRows = false;
			this.gvStoredProcedures.AllowUserToOrderColumns = true;
			this.gvStoredProcedures.AllowUserToResizeRows = false;
			this.gvStoredProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvStoredProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvStoredProcedures.Location = new System.Drawing.Point(3, 3);
			this.gvStoredProcedures.Name = "gvStoredProcedures";
			this.gvStoredProcedures.RowHeadersVisible = false;
			this.gvStoredProcedures.Size = new System.Drawing.Size(628, 380);
			this.gvStoredProcedures.TabIndex = 0;
			// 
			// tpEnums
			// 
			this.tpEnums.Controls.Add(this.gvEnums);
			this.tpEnums.Location = new System.Drawing.Point(4, 22);
			this.tpEnums.Name = "tpEnums";
			this.tpEnums.Padding = new System.Windows.Forms.Padding(3);
			this.tpEnums.Size = new System.Drawing.Size(634, 386);
			this.tpEnums.TabIndex = 3;
			this.tpEnums.Text = "Enums";
			this.tpEnums.UseVisualStyleBackColor = true;
			// 
			// gvEnums
			// 
			this.gvEnums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvEnums.Location = new System.Drawing.Point(260, 195);
			this.gvEnums.Name = "gvEnums";
			this.gvEnums.Size = new System.Drawing.Size(240, 150);
			this.gvEnums.TabIndex = 0;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(486, 3);
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
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 411);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(645, 34);
			this.flowLayoutPanel3.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(567, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
			// TableModel
			// 
			this.TableModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TableModel.DataPropertyName = "GenerateModel";
			this.TableModel.HeaderText = "Model";
			this.TableModel.Name = "TableModel";
			this.TableModel.Width = 50;
			// 
			// TableIModel
			// 
			this.TableIModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TableIModel.DataPropertyName = "GenerateModelInterface";
			this.TableIModel.HeaderText = "Model Interface";
			this.TableIModel.Name = "TableIModel";
			this.TableIModel.Width = 60;
			// 
			// TableRepository
			// 
			this.TableRepository.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TableRepository.DataPropertyName = "GenerateRepository";
			this.TableRepository.HeaderText = "Repository";
			this.TableRepository.Name = "TableRepository";
			this.TableRepository.Width = 65;
			// 
			// TableIRepository
			// 
			this.TableIRepository.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TableIRepository.DataPropertyName = "GenerateRepositoryInterface";
			this.TableIRepository.HeaderText = "Repository Interface";
			this.TableIRepository.Name = "TableIRepository";
			this.TableIRepository.Width = 65;
			// 
			// Service
			// 
			this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Service.DataPropertyName = "GenerateService";
			this.Service.HeaderText = "Service";
			this.Service.Name = "Service";
			this.Service.Width = 50;
			// 
			// ServiceInterface
			// 
			this.ServiceInterface.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ServiceInterface.DataPropertyName = "GenerateServiceInterface";
			this.ServiceInterface.HeaderText = "Service Interface";
			this.ServiceInterface.Name = "ServiceInterface";
			this.ServiceInterface.Width = 65;
			// 
			// DatabaseObjectSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 445);
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
			this.tcDatabaseObjects.ResumeLayout(false);
			this.tpSettings.ResumeLayout(false);
			this.tpSettings.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.tpTables.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvTables)).EndInit();
			this.gbTables.ResumeLayout(false);
			this.gbTables.PerformLayout();
			this.tpViews.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvViews)).EndInit();
			this.tpStoredProcedures.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvStoredProcedures)).EndInit();
			this.tpEnums.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvEnums)).EndInit();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcDatabaseObjects;
		private System.Windows.Forms.TabPage tpTables;
		private System.Windows.Forms.TabPage tpViews;
		private System.Windows.Forms.DataGridView gvViews;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ViewSelect;
		private System.Windows.Forms.DataGridViewTextBoxColumn ViewName;
		private System.Windows.Forms.TabPage tpStoredProcedures;
		private System.Windows.Forms.DataGridView gvStoredProcedures;
		private System.Windows.Forms.TabPage tpEnums;
		private System.Windows.Forms.DataGridView gvEnums;
		private System.Windows.Forms.TabPage tpSettings;
		private System.Windows.Forms.CheckBox cbxGenerateContextClass;
		private System.Windows.Forms.DataGridView gvTables;
		private System.Windows.Forms.GroupBox gbTables;
		private System.Windows.Forms.CheckBox cbxRepositoryInterfaces;
		private System.Windows.Forms.CheckBox cbxRepositories;
		private System.Windows.Forms.CheckBox cbxModelInterfaces;
		private System.Windows.Forms.CheckBox cbxModels;
		private System.Windows.Forms.CheckBox cbxPartialClasses;
		private System.Windows.Forms.CheckBox cbxPartialInterfaces;
		private System.Windows.Forms.CheckBox cbxPartialContextInterface;
		private System.Windows.Forms.CheckBox cbxUseDataAnnotations;
		private System.Windows.Forms.CheckBox cbxUseCamelCase;
		private System.Windows.Forms.CheckBox cbxDisableGeographyTypes;
		private System.Windows.Forms.CheckBox cbxNullableShortHand;
		private System.Windows.Forms.CheckBox cbxPrivateSetterForComputedColumns;
		private System.Windows.Forms.CheckBox cbxGenerateUnitOfWorkInterface;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtContextInterfaceBaseClass;
		private System.Windows.Forms.TextBox txtContextBaseClass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDbContextName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbxPrependSchema;
		private System.Windows.Forms.CheckBox cbxIncludeQueryTraceOn;
		private System.Windows.Forms.TextBox txtConfigurationClassName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox ddlIncludeComments;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox cbxVirtualReverseNavProperty;
        private System.Windows.Forms.CheckBox cbxServiceInterfaces;
        private System.Windows.Forms.CheckBox cbxServices;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableSelect;
		private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableModel;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableIModel;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableRepository;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableIRepository;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Service;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ServiceInterface;
	}
}