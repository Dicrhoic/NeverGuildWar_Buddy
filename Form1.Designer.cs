namespace NeverGuildWar_Buddy
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSetupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSetupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setupsToolStripMenuItem
            // 
            this.setupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSetupsToolStripMenuItem,
            this.createSetupsToolStripMenuItem});
            this.setupsToolStripMenuItem.Name = "setupsToolStripMenuItem";
            this.setupsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.setupsToolStripMenuItem.Text = "Setups";
            // 
            // viewSetupsToolStripMenuItem
            // 
            this.viewSetupsToolStripMenuItem.Name = "viewSetupsToolStripMenuItem";
            this.viewSetupsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.viewSetupsToolStripMenuItem.Text = "View Setups";
            // 
            // createSetupsToolStripMenuItem
            // 
            this.createSetupsToolStripMenuItem.Name = "createSetupsToolStripMenuItem";
            this.createSetupsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.createSetupsToolStripMenuItem.Text = "Create Setups";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HomePage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem setupsToolStripMenuItem;
        private ToolStripMenuItem viewSetupsToolStripMenuItem;
        private ToolStripMenuItem createSetupsToolStripMenuItem;
    }
}