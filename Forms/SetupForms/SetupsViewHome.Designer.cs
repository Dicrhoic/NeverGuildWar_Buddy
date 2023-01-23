namespace NeverGuildWar_Buddy.Forms.SetupForms
{
    partial class SetupsViewHome
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataTable = new System.Windows.Forms.TableLayoutPanel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createNewSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 378);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortListView);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LoadRaidDetails);
            this.listView1.Click += new System.EventHandler(this.LoadSetupData);
            // 
            // dataTable
            // 
            this.dataTable.AutoScroll = true;
            this.dataTable.ColumnCount = 1;
            this.dataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(431, 31);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowCount = 1;
            this.dataTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dataTable.Size = new System.Drawing.Size(630, 380);
            this.dataTable.TabIndex = 4;
            // 
            // filterPanel
            // 
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.listView1);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterPanel.Location = new System.Drawing.Point(0, 31);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(431, 380);
            this.filterPanel.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.dataTable);
            this.mainPanel.Controls.Add(this.filterPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1061, 411);
            this.mainPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1061, 31);
            this.topPanel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewSetupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createNewSetupToolStripMenuItem
            // 
            this.createNewSetupToolStripMenuItem.Name = "createNewSetupToolStripMenuItem";
            this.createNewSetupToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.createNewSetupToolStripMenuItem.Text = "Create New Setup";
            this.createNewSetupToolStripMenuItem.Click += new System.EventHandler(this.CreateForm);
            // 
            // SetupsViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 411);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetupsViewHome";
            this.Text = "SetupsViewHome";
            this.Load += new System.EventHandler(this.SetupsViewHome_Load);
            this.filterPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private TableLayoutPanel dataTable;
        private Panel filterPanel;
        private Panel mainPanel;
        private Panel topPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem createNewSetupToolStripMenuItem;
    }
}