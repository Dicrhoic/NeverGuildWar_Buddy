namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    partial class GWLog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.daySelector = new System.Windows.Forms.ComboBox();
            this.gwCB = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.toolbarPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.Location = new System.Drawing.Point(277, 165);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(917, 452);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.listView1);
            this.mainPanel.Controls.Add(this.toolbarPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1194, 617);
            this.mainPanel.TabIndex = 1;
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.Controls.Add(this.button1);
            this.toolbarPanel.Controls.Add(this.groupBox1);
            this.toolbarPanel.Controls.Add(this.addBtn);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(1194, 165);
            this.toolbarPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Update Results";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.daySelector);
            this.groupBox1.Controls.Add(this.gwCB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1194, 129);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Day:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 37);
            this.label8.TabIndex = 19;
            this.label8.Text = "GW Event:";
            // 
            // daySelector
            // 
            this.daySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daySelector.FormattingEnabled = true;
            this.daySelector.Location = new System.Drawing.Point(196, 92);
            this.daySelector.Name = "daySelector";
            this.daySelector.Size = new System.Drawing.Size(627, 33);
            this.daySelector.TabIndex = 18;
            // 
            // gwCB
            // 
            this.gwCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gwCB.FormattingEnabled = true;
            this.gwCB.Location = new System.Drawing.Point(196, 53);
            this.gwCB.Name = "gwCB";
            this.gwCB.Size = new System.Drawing.Size(627, 33);
            this.gwCB.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(6, 131);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(119, 31);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Add New Result";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // GWLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "GWLog";
            this.Size = new System.Drawing.Size(1194, 617);
            this.mainPanel.ResumeLayout(false);
            this.toolbarPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private Panel mainPanel;
        private Panel toolbarPanel;
        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label8;
        private ComboBox daySelector;
        private ComboBox gwCB;
        private Button addBtn;
    }
}
