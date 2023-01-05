namespace NeverGuildWar_Buddy.Forms
{
    partial class HomePageComponent
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPanel2 = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSetupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSetupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGWDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tabControl1);
            this.mainPanel.Controls.Add(this.timerLabel);
            this.mainPanel.Controls.Add(this.menuStrip1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1904, 598);
            this.mainPanel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1904, 521);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1896, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Honour/Box Calculator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1890, 487);
            this.panel1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabPanel2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1896, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GW Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPanel2
            // 
            this.tabPanel2.AutoScroll = true;
            this.tabPanel2.AutoSize = true;
            this.tabPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tabPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel2.Location = new System.Drawing.Point(3, 3);
            this.tabPanel2.Name = "tabPanel2";
            this.tabPanel2.Size = new System.Drawing.Size(1890, 487);
            this.tabPanel2.TabIndex = 0;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(0, 24);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(120, 30);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "Countdown";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.setupsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setGWDateToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setGWDateToolStripMenuItem
            // 
            this.setGWDateToolStripMenuItem.Name = "setGWDateToolStripMenuItem";
            this.setGWDateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.setGWDateToolStripMenuItem.Text = "Set GW Date";
            // 
            // HomePageComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 598);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageComponent";
            this.Text = "HomePageComponent";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private TabPage tabPage2;
        private Panel tabPanel2;
        private Label timerLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem setupsToolStripMenuItem;
        private ToolStripMenuItem viewSetupsToolStripMenuItem;
        private ToolStripMenuItem createSetupsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem setGWDateToolStripMenuItem;
        private System.Windows.Forms.Timer countdownTimer;
    }
}