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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            updateDBToolStripMenuItem = new ToolStripMenuItem();
            characterToolStripMenuItem = new ToolStripMenuItem();
            summonsToolStripMenuItem = new ToolStripMenuItem();
            weaponsToolStripMenuItem = new ToolStripMenuItem();
            setGWDateToolStripMenuItem = new ToolStripMenuItem();
            setupsToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, fileToolStripMenuItem, setupsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1313, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += ReturnHome;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateDBToolStripMenuItem, setGWDateToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // updateDBToolStripMenuItem
            // 
            updateDBToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { characterToolStripMenuItem, summonsToolStripMenuItem, weaponsToolStripMenuItem });
            updateDBToolStripMenuItem.Name = "updateDBToolStripMenuItem";
            updateDBToolStripMenuItem.Size = new Size(180, 22);
            updateDBToolStripMenuItem.Text = "UpdateDB";
            // 
            // characterToolStripMenuItem
            // 
            characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            characterToolStripMenuItem.Size = new Size(130, 22);
            characterToolStripMenuItem.Text = "Characters";
            characterToolStripMenuItem.Click += characterToolStripMenuItem_Click;
            // 
            // summonsToolStripMenuItem
            // 
            summonsToolStripMenuItem.Name = "summonsToolStripMenuItem";
            summonsToolStripMenuItem.Size = new Size(130, 22);
            summonsToolStripMenuItem.Text = "Summons";
            summonsToolStripMenuItem.Click += SummonUpdate;
            // 
            // weaponsToolStripMenuItem
            // 
            weaponsToolStripMenuItem.Name = "weaponsToolStripMenuItem";
            weaponsToolStripMenuItem.Size = new Size(130, 22);
            weaponsToolStripMenuItem.Text = "Weapons";
            weaponsToolStripMenuItem.Click += WeaponUpdate;
            // 
            // setGWDateToolStripMenuItem
            // 
            setGWDateToolStripMenuItem.Name = "setGWDateToolStripMenuItem";
            setGWDateToolStripMenuItem.Size = new Size(180, 22);
            setGWDateToolStripMenuItem.Text = "Set GW Date";
            setGWDateToolStripMenuItem.Click += OpenSettings;
            // 
            // setupsToolStripMenuItem
            // 
            setupsToolStripMenuItem.Name = "setupsToolStripMenuItem";
            setupsToolStripMenuItem.Size = new Size(54, 20);
            setupsToolStripMenuItem.Text = "Setups";
            setupsToolStripMenuItem.Click += LoadSetupsForm;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 24);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1313, 426);
            mainPanel.TabIndex = 2;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 450);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            Name = "HomePage";
            Text = "Home";
            Load += HomePage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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