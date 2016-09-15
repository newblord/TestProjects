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
			this.lblHeader = new System.Windows.Forms.Label();
			this.tvDBComponents = new System.Windows.Forms.TreeView();
			this.btnSelect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeader.Location = new System.Drawing.Point(13, 13);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(472, 17);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Select Tables, Views and Stored Procedures to Add or Update from Database";
			// 
			// tvDBComponents
			// 
			this.tvDBComponents.CheckBoxes = true;
			this.tvDBComponents.Location = new System.Drawing.Point(13, 34);
			this.tvDBComponents.Name = "tvDBComponents";
			this.tvDBComponents.Size = new System.Drawing.Size(517, 307);
			this.tvDBComponents.TabIndex = 1;
			this.tvDBComponents.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvDBComponents_AfterCheck);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(455, 347);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// UpdateFromDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 380);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.tvDBComponents);
			this.Controls.Add(this.lblHeader);
			this.Name = "UpdateFromDatabase";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UpdateFromDatabase";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.TreeView tvDBComponents;
		private System.Windows.Forms.Button btnSelect;
	}
}