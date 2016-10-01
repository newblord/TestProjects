﻿namespace Tiger.Dal
{
	partial class UpdateFromDatabase
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cbxUseCamelCase = new System.Windows.Forms.CheckBox();
			this.cbxDisableGeographyTypes = new System.Windows.Forms.CheckBox();
			this.cbxPrivateSetterForComputedColumns = new System.Windows.Forms.CheckBox();
			this.cbxNullableShortHand = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtContextInterfaceBaseClass = new System.Windows.Forms.TextBox();
			this.txtContextBaseClass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.cbxPartialClasses = new System.Windows.Forms.CheckBox();
			this.cbxPartialInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxPartialContextInterface = new System.Windows.Forms.CheckBox();
			this.cbxGenerateSeparateFiles = new System.Windows.Forms.CheckBox();
			this.cbxUseDataAnnotations = new System.Windows.Forms.CheckBox();
			this.cbxGenerateContextClass = new System.Windows.Forms.CheckBox();
			this.cbxGenerateUnitOfWork = new System.Windows.Forms.CheckBox();
			this.txtDbContextName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tpTables = new System.Windows.Forms.TabPage();
			this.gvTables = new System.Windows.Forms.DataGridView();
			this.TableSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TablePoco = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableIPoco = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableRepository = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableIRepository = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.gbTables = new System.Windows.Forms.GroupBox();
			this.cbxRepositoryInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxRepositories = new System.Windows.Forms.CheckBox();
			this.cbxPocoInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxPocos = new System.Windows.Forms.CheckBox();
			this.tpViews = new System.Windows.Forms.TabPage();
			this.gvViews = new System.Windows.Forms.DataGridView();
			this.ViewSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpStoredProcedures = new System.Windows.Forms.TabPage();
			this.gvStoredProcedures = new System.Windows.Forms.DataGridView();
			this.tpEnums = new System.Windows.Forms.TabPage();
			this.gvEnums = new System.Windows.Forms.DataGridView();
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
			this.SuspendLayout();
			// 
			// tcDatabaseObjects
			// 
			this.tcDatabaseObjects.Controls.Add(this.tpSettings);
			this.tcDatabaseObjects.Controls.Add(this.tpTables);
			this.tcDatabaseObjects.Controls.Add(this.tpViews);
			this.tcDatabaseObjects.Controls.Add(this.tpStoredProcedures);
			this.tcDatabaseObjects.Controls.Add(this.tpEnums);
			this.tcDatabaseObjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcDatabaseObjects.Location = new System.Drawing.Point(0, 0);
			this.tcDatabaseObjects.Name = "tcDatabaseObjects";
			this.tcDatabaseObjects.SelectedIndex = 0;
			this.tcDatabaseObjects.Size = new System.Drawing.Size(592, 431);
			this.tcDatabaseObjects.TabIndex = 0;
			this.tcDatabaseObjects.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcDatabaseObjects_Selected);
			// 
			// tpSettings
			// 
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
			this.tpSettings.Size = new System.Drawing.Size(584, 405);
			this.tpSettings.TabIndex = 4;
			this.tpSettings.Text = "Settings";
			this.tpSettings.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.cbxUseCamelCase);
			this.flowLayoutPanel1.Controls.Add(this.cbxDisableGeographyTypes);
			this.flowLayoutPanel1.Controls.Add(this.cbxNullableShortHand);
			this.flowLayoutPanel1.Controls.Add(this.cbxPrivateSetterForComputedColumns);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(305, 81);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 321);
			this.flowLayoutPanel1.TabIndex = 26;
			// 
			// cbxUseCamelCase
			// 
			this.cbxUseCamelCase.AutoSize = true;
			this.cbxUseCamelCase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxUseCamelCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUseCamelCase.Location = new System.Drawing.Point(145, 3);
			this.cbxUseCamelCase.Name = "cbxUseCamelCase";
			this.cbxUseCamelCase.Size = new System.Drawing.Size(121, 19);
			this.cbxUseCamelCase.TabIndex = 12;
			this.cbxUseCamelCase.Text = "Use Camel Case:";
			this.cbxUseCamelCase.UseVisualStyleBackColor = true;
			// 
			// cbxDisableGeographyTypes
			// 
			this.cbxDisableGeographyTypes.AutoSize = true;
			this.cbxDisableGeographyTypes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxDisableGeographyTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDisableGeographyTypes.Location = new System.Drawing.Point(97, 28);
			this.cbxDisableGeographyTypes.Name = "cbxDisableGeographyTypes";
			this.cbxDisableGeographyTypes.Size = new System.Drawing.Size(169, 19);
			this.cbxDisableGeographyTypes.TabIndex = 11;
			this.cbxDisableGeographyTypes.Text = "Disable Geography Types:";
			this.cbxDisableGeographyTypes.UseVisualStyleBackColor = true;
			// 
			// cbxPrivateSetterForComputedColumns
			// 
			this.cbxPrivateSetterForComputedColumns.AutoSize = true;
			this.cbxPrivateSetterForComputedColumns.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxPrivateSetterForComputedColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPrivateSetterForComputedColumns.Location = new System.Drawing.Point(10, 78);
			this.cbxPrivateSetterForComputedColumns.Name = "cbxPrivateSetterForComputedColumns";
			this.cbxPrivateSetterForComputedColumns.Size = new System.Drawing.Size(256, 19);
			this.cbxPrivateSetterForComputedColumns.TabIndex = 19;
			this.cbxPrivateSetterForComputedColumns.Text = "Use Private Setter For Computer Columns:";
			this.cbxPrivateSetterForComputedColumns.UseVisualStyleBackColor = true;
			// 
			// cbxNullableShortHand
			// 
			this.cbxNullableShortHand.AutoSize = true;
			this.cbxNullableShortHand.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxNullableShortHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxNullableShortHand.Location = new System.Drawing.Point(126, 53);
			this.cbxNullableShortHand.Name = "cbxNullableShortHand";
			this.cbxNullableShortHand.Size = new System.Drawing.Size(140, 19);
			this.cbxNullableShortHand.TabIndex = 20;
			this.cbxNullableShortHand.Text = "Nullable Short Hand:";
			this.cbxNullableShortHand.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Context Base Class:";
			// 
			// txtContextInterfaceBaseClass
			// 
			this.txtContextInterfaceBaseClass.Location = new System.Drawing.Point(174, 38);
			this.txtContextInterfaceBaseClass.Name = "txtContextInterfaceBaseClass";
			this.txtContextInterfaceBaseClass.Size = new System.Drawing.Size(122, 20);
			this.txtContextInterfaceBaseClass.TabIndex = 8;
			// 
			// txtContextBaseClass
			// 
			this.txtContextBaseClass.Location = new System.Drawing.Point(124, 6);
			this.txtContextBaseClass.Name = "txtContextBaseClass";
			this.txtContextBaseClass.Size = new System.Drawing.Size(121, 20);
			this.txtContextBaseClass.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 39);
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
			this.flowLayoutPanel2.Controls.Add(this.cbxGenerateSeparateFiles);
			this.flowLayoutPanel2.Controls.Add(this.cbxUseDataAnnotations);
			this.flowLayoutPanel2.Controls.Add(this.cbxGenerateContextClass);
			this.flowLayoutPanel2.Controls.Add(this.cbxGenerateUnitOfWork);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 81);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(289, 321);
			this.flowLayoutPanel2.TabIndex = 27;
			// 
			// cbxPartialClasses
			// 
			this.cbxPartialClasses.AutoSize = true;
			this.cbxPartialClasses.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxPartialClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPartialClasses.Location = new System.Drawing.Point(142, 3);
			this.cbxPartialClasses.Name = "cbxPartialClasses";
			this.cbxPartialClasses.Size = new System.Drawing.Size(144, 19);
			this.cbxPartialClasses.TabIndex = 10;
			this.cbxPartialClasses.Text = "Make Classes Partial:";
			this.cbxPartialClasses.UseVisualStyleBackColor = true;
			// 
			// cbxPartialInterfaces
			// 
			this.cbxPartialInterfaces.AutoSize = true;
			this.cbxPartialInterfaces.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxPartialInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPartialInterfaces.Location = new System.Drawing.Point(132, 28);
			this.cbxPartialInterfaces.Name = "cbxPartialInterfaces";
			this.cbxPartialInterfaces.Size = new System.Drawing.Size(154, 19);
			this.cbxPartialInterfaces.TabIndex = 16;
			this.cbxPartialInterfaces.Text = "Make Interfaces Partial:";
			this.cbxPartialInterfaces.UseVisualStyleBackColor = true;
			// 
			// cbxPartialContextInterface
			// 
			this.cbxPartialContextInterface.AutoSize = true;
			this.cbxPartialContextInterface.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxPartialContextInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPartialContextInterface.Location = new System.Drawing.Point(38, 53);
			this.cbxPartialContextInterface.Name = "cbxPartialContextInterface";
			this.cbxPartialContextInterface.Size = new System.Drawing.Size(248, 19);
			this.cbxPartialContextInterface.TabIndex = 15;
			this.cbxPartialContextInterface.Text = "Make Database Context Interface Partial:";
			this.cbxPartialContextInterface.UseVisualStyleBackColor = true;
			// 
			// cbxGenerateSeparateFiles
			// 
			this.cbxGenerateSeparateFiles.AutoSize = true;
			this.cbxGenerateSeparateFiles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxGenerateSeparateFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxGenerateSeparateFiles.Location = new System.Drawing.Point(124, 78);
			this.cbxGenerateSeparateFiles.Name = "cbxGenerateSeparateFiles";
			this.cbxGenerateSeparateFiles.Size = new System.Drawing.Size(162, 19);
			this.cbxGenerateSeparateFiles.TabIndex = 14;
			this.cbxGenerateSeparateFiles.Text = "Generate Separate Files:";
			this.cbxGenerateSeparateFiles.UseVisualStyleBackColor = true;
			// 
			// cbxUseDataAnnotations
			// 
			this.cbxUseDataAnnotations.AutoSize = true;
			this.cbxUseDataAnnotations.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxUseDataAnnotations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUseDataAnnotations.Location = new System.Drawing.Point(139, 103);
			this.cbxUseDataAnnotations.Name = "cbxUseDataAnnotations";
			this.cbxUseDataAnnotations.Size = new System.Drawing.Size(147, 19);
			this.cbxUseDataAnnotations.TabIndex = 13;
			this.cbxUseDataAnnotations.Text = "Use Data Annotations:";
			this.cbxUseDataAnnotations.UseVisualStyleBackColor = true;
			// 
			// cbxGenerateContextClass
			// 
			this.cbxGenerateContextClass.AutoSize = true;
			this.cbxGenerateContextClass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxGenerateContextClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxGenerateContextClass.Location = new System.Drawing.Point(129, 128);
			this.cbxGenerateContextClass.Name = "cbxGenerateContextClass";
			this.cbxGenerateContextClass.Size = new System.Drawing.Size(157, 19);
			this.cbxGenerateContextClass.TabIndex = 1;
			this.cbxGenerateContextClass.Text = "Generate Context Class:";
			this.cbxGenerateContextClass.UseVisualStyleBackColor = true;
			// 
			// cbxGenerateUnitOfWork
			// 
			this.cbxGenerateUnitOfWork.AutoSize = true;
			this.cbxGenerateUnitOfWork.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbxGenerateUnitOfWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxGenerateUnitOfWork.Location = new System.Drawing.Point(135, 153);
			this.cbxGenerateUnitOfWork.Name = "cbxGenerateUnitOfWork";
			this.cbxGenerateUnitOfWork.Size = new System.Drawing.Size(151, 19);
			this.cbxGenerateUnitOfWork.TabIndex = 25;
			this.cbxGenerateUnitOfWork.Text = "Generate Unit Of Work:";
			this.cbxGenerateUnitOfWork.UseVisualStyleBackColor = true;
			// 
			// txtDbContextName
			// 
			this.txtDbContextName.Location = new System.Drawing.Point(401, 7);
			this.txtDbContextName.Name = "txtDbContextName";
			this.txtDbContextName.Size = new System.Drawing.Size(122, 20);
			this.txtDbContextName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(251, 8);
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
			this.tpTables.Size = new System.Drawing.Size(584, 405);
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
            this.TablePoco,
            this.TableIPoco,
            this.TableRepository,
            this.TableIRepository});
			this.gvTables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvTables.Location = new System.Drawing.Point(3, 101);
			this.gvTables.Name = "gvTables";
			this.gvTables.RowHeadersVisible = false;
			this.gvTables.ShowEditingIcon = false;
			this.gvTables.Size = new System.Drawing.Size(578, 301);
			this.gvTables.TabIndex = 2;
			this.gvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellContentClick);
			this.gvTables.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellValueChanged);
			// 
			// TableSelect
			// 
			this.TableSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.TableSelect.DataPropertyName = "TableSelect";
			this.TableSelect.HeaderText = "";
			this.TableSelect.Name = "TableSelect";
			this.TableSelect.ThreeState = true;
			this.TableSelect.Width = 5;
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
			// TablePoco
			// 
			this.TablePoco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TablePoco.DataPropertyName = "GeneratePoco";
			this.TablePoco.HeaderText = "POCO";
			this.TablePoco.Name = "TablePoco";
			this.TablePoco.Width = 50;
			// 
			// TableIPoco
			// 
			this.TableIPoco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TableIPoco.DataPropertyName = "GeneratePocoInterface";
			this.TableIPoco.HeaderText = "POCO Interface";
			this.TableIPoco.Name = "TableIPoco";
			this.TableIPoco.Width = 60;
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
			// gbTables
			// 
			this.gbTables.Controls.Add(this.cbxRepositoryInterfaces);
			this.gbTables.Controls.Add(this.cbxRepositories);
			this.gbTables.Controls.Add(this.cbxPocoInterfaces);
			this.gbTables.Controls.Add(this.cbxPocos);
			this.gbTables.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTables.Location = new System.Drawing.Point(3, 3);
			this.gbTables.Name = "gbTables";
			this.gbTables.Size = new System.Drawing.Size(578, 98);
			this.gbTables.TabIndex = 0;
			this.gbTables.TabStop = false;
			this.gbTables.Text = "Table Settings";
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
			this.cbxRepositoryInterfaces.ThreeState = true;
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
			this.cbxRepositories.ThreeState = true;
			this.cbxRepositories.UseVisualStyleBackColor = true;
			this.cbxRepositories.CheckStateChanged += new System.EventHandler(this.cbxRepositories_CheckStateChanged);
			// 
			// cbxPocoInterfaces
			// 
			this.cbxPocoInterfaces.AutoSize = true;
			this.cbxPocoInterfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPocoInterfaces.Location = new System.Drawing.Point(7, 51);
			this.cbxPocoInterfaces.Name = "cbxPocoInterfaces";
			this.cbxPocoInterfaces.Size = new System.Drawing.Size(120, 17);
			this.cbxPocoInterfaces.TabIndex = 1;
			this.cbxPocoInterfaces.Text = "All POCO Interfaces";
			this.cbxPocoInterfaces.ThreeState = true;
			this.cbxPocoInterfaces.UseVisualStyleBackColor = true;
			this.cbxPocoInterfaces.CheckStateChanged += new System.EventHandler(this.cbxPocoInterfaces_CheckStateChanged);
			// 
			// cbxPocos
			// 
			this.cbxPocos.AutoSize = true;
			this.cbxPocos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPocos.Location = new System.Drawing.Point(7, 23);
			this.cbxPocos.Name = "cbxPocos";
			this.cbxPocos.Size = new System.Drawing.Size(109, 17);
			this.cbxPocos.TabIndex = 0;
			this.cbxPocos.Text = "All POCO Classes";
			this.cbxPocos.ThreeState = true;
			this.cbxPocos.UseVisualStyleBackColor = true;
			this.cbxPocos.CheckStateChanged += new System.EventHandler(this.cbxPocos_CheckStateChanged);
			// 
			// tpViews
			// 
			this.tpViews.Controls.Add(this.gvViews);
			this.tpViews.Location = new System.Drawing.Point(4, 22);
			this.tpViews.Name = "tpViews";
			this.tpViews.Padding = new System.Windows.Forms.Padding(3);
			this.tpViews.Size = new System.Drawing.Size(584, 405);
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
			this.gvViews.Size = new System.Drawing.Size(578, 399);
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
			this.tpStoredProcedures.Size = new System.Drawing.Size(584, 405);
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
			this.gvStoredProcedures.Size = new System.Drawing.Size(578, 399);
			this.gvStoredProcedures.TabIndex = 0;
			// 
			// tpEnums
			// 
			this.tpEnums.Controls.Add(this.gvEnums);
			this.tpEnums.Location = new System.Drawing.Point(4, 22);
			this.tpEnums.Name = "tpEnums";
			this.tpEnums.Padding = new System.Windows.Forms.Padding(3);
			this.tpEnums.Size = new System.Drawing.Size(584, 405);
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
			// UpdateFromDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 431);
			this.Controls.Add(this.tcDatabaseObjects);
			this.Name = "UpdateFromDatabase";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UpdateFromDatabase";
			this.Load += new System.EventHandler(this.UpdateFromDatabase_Load);
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
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableSelect;
		private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TablePoco;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableIPoco;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableRepository;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableIRepository;
		private System.Windows.Forms.GroupBox gbTables;
		private System.Windows.Forms.CheckBox cbxRepositoryInterfaces;
		private System.Windows.Forms.CheckBox cbxRepositories;
		private System.Windows.Forms.CheckBox cbxPocoInterfaces;
		private System.Windows.Forms.CheckBox cbxPocos;
		private System.Windows.Forms.CheckBox cbxPartialClasses;
		private System.Windows.Forms.CheckBox cbxPartialInterfaces;
		private System.Windows.Forms.CheckBox cbxPartialContextInterface;
		private System.Windows.Forms.CheckBox cbxGenerateSeparateFiles;
		private System.Windows.Forms.CheckBox cbxUseDataAnnotations;
		private System.Windows.Forms.CheckBox cbxUseCamelCase;
		private System.Windows.Forms.CheckBox cbxDisableGeographyTypes;
		private System.Windows.Forms.CheckBox cbxNullableShortHand;
		private System.Windows.Forms.CheckBox cbxPrivateSetterForComputedColumns;
		private System.Windows.Forms.CheckBox cbxGenerateUnitOfWork;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtContextInterfaceBaseClass;
		private System.Windows.Forms.TextBox txtContextBaseClass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDbContextName;
		private System.Windows.Forms.Label label1;
	}
}