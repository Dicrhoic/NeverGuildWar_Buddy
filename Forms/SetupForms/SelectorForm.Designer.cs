namespace NeverGuildWar_Buddy.Forms.SetupForms
{
    partial class SelectorForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterRB = new System.Windows.Forms.RadioButton();
            this.allRB = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fireCB = new System.Windows.Forms.CheckBox();
            this.waterCB = new System.Windows.Forms.CheckBox();
            this.windCB = new System.Windows.Forms.CheckBox();
            this.earthCB = new System.Windows.Forms.CheckBox();
            this.lightCB = new System.Windows.Forms.CheckBox();
            this.darkCB = new System.Windows.Forms.CheckBox();
            this.resultsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.doneBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.filterPanel);
            this.mainPanel.Controls.Add(this.resultsPanel);
            this.mainPanel.Controls.Add(this.doneBtn);
            this.mainPanel.Controls.Add(this.searchTB);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 283);
            this.mainPanel.TabIndex = 2;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.panel2);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(800, 58);
            this.filterPanel.TabIndex = 6;
            this.filterPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filterRB);
            this.panel2.Controls.Add(this.allRB);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 58);
            this.panel2.TabIndex = 2;
            // 
            // filterRB
            // 
            this.filterRB.AutoSize = true;
            this.filterRB.Location = new System.Drawing.Point(117, 3);
            this.filterRB.Name = "filterRB";
            this.filterRB.Size = new System.Drawing.Size(97, 19);
            this.filterRB.TabIndex = 2;
            this.filterRB.Text = "Filter Element";
            this.filterRB.UseVisualStyleBackColor = true;
            // 
            // allRB
            // 
            this.allRB.AutoSize = true;
            this.allRB.Checked = true;
            this.allRB.Location = new System.Drawing.Point(3, 3);
            this.allRB.Name = "allRB";
            this.allRB.Size = new System.Drawing.Size(39, 19);
            this.allRB.TabIndex = 1;
            this.allRB.TabStop = true;
            this.allRB.Text = "All";
            this.allRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allRB.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fireCB);
            this.flowLayoutPanel1.Controls.Add(this.waterCB);
            this.flowLayoutPanel1.Controls.Add(this.windCB);
            this.flowLayoutPanel1.Controls.Add(this.earthCB);
            this.flowLayoutPanel1.Controls.Add(this.lightCB);
            this.flowLayoutPanel1.Controls.Add(this.darkCB);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Enabled = false;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fireCB
            // 
            this.fireCB.AutoSize = true;
            this.fireCB.Location = new System.Drawing.Point(3, 3);
            this.fireCB.Name = "fireCB";
            this.fireCB.Size = new System.Drawing.Size(45, 19);
            this.fireCB.TabIndex = 9;
            this.fireCB.Text = "Fire";
            this.fireCB.UseVisualStyleBackColor = true;
            // 
            // waterCB
            // 
            this.waterCB.AutoSize = true;
            this.waterCB.Location = new System.Drawing.Point(54, 3);
            this.waterCB.Name = "waterCB";
            this.waterCB.Size = new System.Drawing.Size(57, 19);
            this.waterCB.TabIndex = 8;
            this.waterCB.Text = "Water";
            this.waterCB.UseVisualStyleBackColor = true;
            // 
            // windCB
            // 
            this.windCB.AutoSize = true;
            this.windCB.Location = new System.Drawing.Point(117, 3);
            this.windCB.Name = "windCB";
            this.windCB.Size = new System.Drawing.Size(54, 19);
            this.windCB.TabIndex = 7;
            this.windCB.Text = "Wind";
            this.windCB.UseVisualStyleBackColor = true;
            // 
            // earthCB
            // 
            this.earthCB.AutoSize = true;
            this.earthCB.Location = new System.Drawing.Point(177, 3);
            this.earthCB.Name = "earthCB";
            this.earthCB.Size = new System.Drawing.Size(53, 19);
            this.earthCB.TabIndex = 6;
            this.earthCB.Text = "Earth";
            this.earthCB.UseVisualStyleBackColor = true;
            // 
            // lightCB
            // 
            this.lightCB.AutoSize = true;
            this.lightCB.Location = new System.Drawing.Point(236, 3);
            this.lightCB.Name = "lightCB";
            this.lightCB.Size = new System.Drawing.Size(53, 19);
            this.lightCB.TabIndex = 5;
            this.lightCB.Text = "Light";
            this.lightCB.UseVisualStyleBackColor = true;
            // 
            // darkCB
            // 
            this.darkCB.AutoSize = true;
            this.darkCB.Location = new System.Drawing.Point(295, 3);
            this.darkCB.Name = "darkCB";
            this.darkCB.Size = new System.Drawing.Size(50, 19);
            this.darkCB.TabIndex = 10;
            this.darkCB.Text = "Dark";
            this.darkCB.UseVisualStyleBackColor = true;
            // 
            // resultsPanel
            // 
            this.resultsPanel.Location = new System.Drawing.Point(44, 118);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(700, 106);
            this.resultsPanel.TabIndex = 5;
            // 
            // doneBtn
            // 
            this.doneBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doneBtn.Location = new System.Drawing.Point(301, 230);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(178, 37);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "Add to Setup";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTB.Location = new System.Drawing.Point(44, 64);
            this.searchTB.Name = "searchTB";
            this.searchTB.PlaceholderText = "Enter a character Name here";
            this.searchTB.Size = new System.Drawing.Size(700, 33);
            this.searchTB.TabIndex = 0;
            this.searchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForDataItem);
            // 
            // SelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.mainPanel);
            this.Name = "SelectorForm";
            this.Text = "SelectorForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private FlowLayoutPanel resultsPanel;
        private Button doneBtn;
        private TextBox searchTB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel filterPanel;
        private Panel panel2;
        private RadioButton filterRB;
        private RadioButton allRB;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox fireCB;
        private CheckBox waterCB;
        private CheckBox windCB;
        private CheckBox earthCB;
        private CheckBox lightCB;
        private CheckBox darkCB;
    }
}