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
            this.updateDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGWDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
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
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDBToolStripMenuItem,
            this.setGWDateToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateDBToolStripMenuItem
            // 
            this.updateDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterToolStripMenuItem,
            this.summonsToolStripMenuItem,
            this.weaponsToolStripMenuItem});
            this.updateDBToolStripMenuItem.Name = "updateDBToolStripMenuItem";
            this.updateDBToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.updateDBToolStripMenuItem.Text = "UpdateDB";
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.characterToolStripMenuItem.Text = "Characters";
            this.characterToolStripMenuItem.Click += new System.EventHandler(this.characterToolStripMenuItem_Click);
            // 
            // summonsToolStripMenuItem
            // 
            this.summonsToolStripMenuItem.Name = "summonsToolStripMenuItem";
            this.summonsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.summonsToolStripMenuItem.Text = "Summons";
            this.summonsToolStripMenuItem.Click += new System.EventHandler(this.SummonUpdate);
            // 
            // weaponsToolStripMenuItem
            // 
            this.weaponsToolStripMenuItem.Name = "weaponsToolStripMenuItem";
            this.weaponsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.weaponsToolStripMenuItem.Text = "Weapons";
            this.weaponsToolStripMenuItem.Click += new System.EventHandler(this.WeaponUpdate);
            // 
            // setGWDateToolStripMenuItem
            // 
            this.setGWDateToolStripMenuItem.Name = "setGWDateToolStripMenuItem";
            this.setGWDateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.setGWDateToolStripMenuItem.Text = "Set GW Date";
            // 
            // setupsToolStripMenuItem
            // 
            this.setupsToolStripMenuItem.Name = "setupsToolStripMenuItem";
            this.setupsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.setupsToolStripMenuItem.Text = "Setups";
            this.setupsToolStripMenuItem.Click += new System.EventHandler(this.LoadSetupsForm);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1313, 426);
            this.mainPanel.TabIndex = 2;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.ReturnHome);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.Controls.Add(this.mainPanel);
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
        private Panel mainPanel;
        private ToolStripMenuItem updateDBToolStripMenuItem;
        private ToolStripMenuItem characterToolStripMenuItem;
        private ToolStripMenuItem summonsToolStripMenuItem;
        private ToolStripMenuItem weaponsToolStripMenuItem;
        private ToolStripMenuItem setGWDateToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}