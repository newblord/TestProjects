namespace Pathit_Nes
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbBytes = new ListBox();
            toolStrip1 = new ToolStrip();
            btnLoadRom = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbBytes
            // 
            lbBytes.Dock = DockStyle.Right;
            lbBytes.FormattingEnabled = true;
            lbBytes.ItemHeight = 15;
            lbBytes.Location = new Point(716, 0);
            lbBytes.Name = "lbBytes";
            lbBytes.Size = new Size(84, 450);
            lbBytes.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLoadRom });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(716, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadRom
            // 
            btnLoadRom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnLoadRom.ImageTransparentColor = Color.Magenta;
            btnLoadRom.Name = "btnLoadRom";
            btnLoadRom.Size = new Size(65, 22);
            btnLoadRom.Text = "Load Rom";
            btnLoadRom.Click += btnLoadRom_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(lbBytes);
            Name = "MainWindow";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbBytes;
        private ToolStrip toolStrip1;
        private ToolStripButton btnLoadRom;
    }
}