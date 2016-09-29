namespace Tiger.Dal
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tcDatabaseObjects = new System.Windows.Forms.TabControl();
			this.tpTables = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbTables = new System.Windows.Forms.GroupBox();
			this.cbxRepositoryInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxRepositories = new System.Windows.Forms.CheckBox();
			this.cbxPocoInterfaces = new System.Windows.Forms.CheckBox();
			this.cbxPocos = new System.Windows.Forms.CheckBox();
			this.gvTables = new System.Windows.Forms.DataGridView();
			this.tpViews = new System.Windows.Forms.TabPage();
			this.gvViews = new System.Windows.Forms.DataGridView();
			this.ViewSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpStoredProcedures = new System.Windows.Forms.TabPage();
			this.gvStoredProcedures = new System.Windows.Forms.DataGridView();
			this.tpEnums = new System.Windows.Forms.TabPage();
			this.gvEnums = new System.Windows.Forms.DataGridView();
			this.pGlobalSettings = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxContext = new System.Windows.Forms.CheckBox();
			this.TableSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TablePoco = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableIPoco = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableRepository = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TableIRepository = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tcDatabaseObjects.SuspendLayout();
			this.tpTables.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbTables.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvTables)).BeginInit();
			this.tpViews.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvViews)).BeginInit();
			this.tpStoredProcedures.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvStoredProcedures)).BeginInit();
			this.tpEnums.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvEnums)).BeginInit();
			this.pGlobalSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tcDatabaseObjects);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pGlobalSettings);
			this.splitContainer1.Size = new System.Drawing.Size(771, 503);
			this.splitContainer1.SplitterDistance = 529;
			this.splitContainer1.TabIndex = 0;
			// 
			// tcDatabaseObjects
			// 
			this.tcDatabaseObjects.Controls.Add(this.tpTables);
			this.tcDatabaseObjects.Controls.Add(this.tpViews);
			this.tcDatabaseObjects.Controls.Add(this.tpStoredProcedures);
			this.tcDatabaseObjects.Controls.Add(this.tpEnums);
			this.tcDatabaseObjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcDatabaseObjects.Location = new System.Drawing.Point(5, 5);
			this.tcDatabaseObjects.Name = "tcDatabaseObjects";
			this.tcDatabaseObjects.SelectedIndex = 0;
			this.tcDatabaseObjects.Size = new System.Drawing.Size(519, 493);
			this.tcDatabaseObjects.TabIndex = 0;
			this.tcDatabaseObjects.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcDatabaseObjects_Selected);
			// 
			// tpTables
			// 
			this.tpTables.Controls.Add(this.panel1);
			this.tpTables.Controls.Add(this.gvTables);
			this.tpTables.Location = new System.Drawing.Point(4, 22);
			this.tpTables.Name = "tpTables";
			this.tpTables.Padding = new System.Windows.Forms.Padding(3);
			this.tpTables.Size = new System.Drawing.Size(511, 467);
			this.tpTables.TabIndex = 0;
			this.tpTables.Text = "Tables";
			this.tpTables.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gbTables);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(505, 101);
			this.panel1.TabIndex = 1;
			// 
			// gbTables
			// 
			this.gbTables.Controls.Add(this.cbxRepositoryInterfaces);
			this.gbTables.Controls.Add(this.cbxRepositories);
			this.gbTables.Controls.Add(this.cbxPocoInterfaces);
			this.gbTables.Controls.Add(this.cbxPocos);
			this.gbTables.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTables.Location = new System.Drawing.Point(0, 0);
			this.gbTables.Name = "gbTables";
			this.gbTables.Size = new System.Drawing.Size(505, 101);
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
			this.cbxRepositoryInterfaces.UseVisualStyleBackColor = true;
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
			this.cbxPocoInterfaces.UseVisualStyleBackColor = true;
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
			this.cbxPocos.UseVisualStyleBackColor = true;
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
			this.gvTables.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gvTables.Location = new System.Drawing.Point(3, 103);
			this.gvTables.Name = "gvTables";
			this.gvTables.RowHeadersVisible = false;
			this.gvTables.ShowEditingIcon = false;
			this.gvTables.Size = new System.Drawing.Size(505, 361);
			this.gvTables.TabIndex = 0;
			this.gvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellContentClick);
			this.gvTables.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTables_CellValueChanged);
			// 
			// tpViews
			// 
			this.tpViews.Controls.Add(this.gvViews);
			this.tpViews.Location = new System.Drawing.Point(4, 22);
			this.tpViews.Name = "tpViews";
			this.tpViews.Padding = new System.Windows.Forms.Padding(3);
			this.tpViews.Size = new System.Drawing.Size(511, 467);
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
			this.gvViews.Size = new System.Drawing.Size(505, 461);
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
			this.tpStoredProcedures.Size = new System.Drawing.Size(511, 467);
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
			this.gvStoredProcedures.Size = new System.Drawing.Size(505, 461);
			this.gvStoredProcedures.TabIndex = 0;
			// 
			// tpEnums
			// 
			this.tpEnums.Controls.Add(this.gvEnums);
			this.tpEnums.Location = new System.Drawing.Point(4, 22);
			this.tpEnums.Name = "tpEnums";
			this.tpEnums.Padding = new System.Windows.Forms.Padding(3);
			this.tpEnums.Size = new System.Drawing.Size(511, 467);
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
			// pGlobalSettings
			// 
			this.pGlobalSettings.Controls.Add(this.label1);
			this.pGlobalSettings.Controls.Add(this.cbxContext);
			this.pGlobalSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pGlobalSettings.Location = new System.Drawing.Point(0, 0);
			this.pGlobalSettings.Name = "pGlobalSettings";
			this.pGlobalSettings.Size = new System.Drawing.Size(238, 503);
			this.pGlobalSettings.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Global Settings";
			// 
			// cbxContext
			// 
			this.cbxContext.AutoSize = true;
			this.cbxContext.Location = new System.Drawing.Point(6, 39);
			this.cbxContext.Name = "cbxContext";
			this.cbxContext.Size = new System.Drawing.Size(137, 17);
			this.cbxContext.TabIndex = 1;
			this.cbxContext.Text = "Generate Context Class";
			this.cbxContext.UseVisualStyleBackColor = true;
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
			// UpdateFromDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 503);
			this.Controls.Add(this.splitContainer1);
			this.Name = "UpdateFromDatabase";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UpdateFromDatabase";
			this.Load += new System.EventHandler(this.UpdateFromDatabase_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tcDatabaseObjects.ResumeLayout(false);
			this.tpTables.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.gbTables.ResumeLayout(false);
			this.gbTables.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvTables)).EndInit();
			this.tpViews.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvViews)).EndInit();
			this.tpStoredProcedures.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvStoredProcedures)).EndInit();
			this.tpEnums.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvEnums)).EndInit();
			this.pGlobalSettings.ResumeLayout(false);
			this.pGlobalSettings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tcDatabaseObjects;
		private System.Windows.Forms.TabPage tpTables;
		private System.Windows.Forms.TabPage tpViews;
		private System.Windows.Forms.TabPage tpStoredProcedures;
		private System.Windows.Forms.TabPage tpEnums;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gvTables;
		private System.Windows.Forms.DataGridView gvViews;
		private System.Windows.Forms.DataGridView gvStoredProcedures;
		private System.Windows.Forms.DataGridView gvEnums;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ViewSelect;
		private System.Windows.Forms.DataGridViewTextBoxColumn ViewName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbTables;
		private System.Windows.Forms.CheckBox cbxPocoInterfaces;
		private System.Windows.Forms.CheckBox cbxPocos;
		private System.Windows.Forms.CheckBox cbxRepositoryInterfaces;
		private System.Windows.Forms.CheckBox cbxRepositories;
		private System.Windows.Forms.Panel pGlobalSettings;
		private System.Windows.Forms.CheckBox cbxContext;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableSelect;
		private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TablePoco;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableIPoco;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableRepository;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TableIRepository;
	}
}