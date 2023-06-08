namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    partial class RaidData
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
            nameLabel = new Label();
            label1 = new Label();
            revivePanel = new Panel();
            reviveTimePanel = new Panel();
            label8 = new Label();
            reviveNum = new NumericUpDown();
            panel2 = new Panel();
            reviveNRB = new RadioButton();
            reviveYRB = new RadioButton();
            label7 = new Label();
            label2 = new Label();
            slowTime = new NumericUpDown();
            label3 = new Label();
            averageTime = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            fastTime = new NumericUpDown();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            mainPanel = new Panel();
            revivePanel.SuspendLayout();
            reviveTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reviveNum).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slowTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)averageTime).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fastTime).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(3, 3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(90, 21);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Raid Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 8;
            label1.Text = "Fastest Clear Time:";
            // 
            // revivePanel
            // 
            revivePanel.BorderStyle = BorderStyle.FixedSingle;
            revivePanel.Controls.Add(reviveTimePanel);
            revivePanel.Controls.Add(panel2);
            revivePanel.Dock = DockStyle.Left;
            revivePanel.Location = new Point(0, 73);
            revivePanel.Name = "revivePanel";
            revivePanel.Size = new Size(878, 33);
            revivePanel.TabIndex = 6;
            // 
            // reviveTimePanel
            // 
            reviveTimePanel.Controls.Add(label8);
            reviveTimePanel.Controls.Add(reviveNum);
            reviveTimePanel.Cursor = Cursors.IBeam;
            reviveTimePanel.Dock = DockStyle.Fill;
            reviveTimePanel.Location = new Point(374, 0);
            reviveTimePanel.Name = "reviveTimePanel";
            reviveTimePanel.Size = new Size(502, 31);
            reviveTimePanel.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 6;
            label8.Text = "Revive Times";
            // 
            // reviveNum
            // 
            reviveNum.Enabled = false;
            reviveNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reviveNum.Location = new Point(107, 0);
            reviveNum.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            reviveNum.Name = "reviveNum";
            reviveNum.Size = new Size(120, 29);
            reviveNum.TabIndex = 7;
            reviveNum.ValueChanged += UpdateRevTimes;
            // 
            // panel2
            // 
            panel2.Controls.Add(reviveNRB);
            panel2.Controls.Add(reviveYRB);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 31);
            panel2.TabIndex = 4;
            // 
            // reviveNRB
            // 
            reviveNRB.AutoSize = true;
            reviveNRB.Dock = DockStyle.Left;
            reviveNRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reviveNRB.Location = new Point(110, 0);
            reviveNRB.Name = "reviveNRB";
            reviveNRB.Size = new Size(49, 31);
            reviveNRB.TabIndex = 5;
            reviveNRB.TabStop = true;
            reviveNRB.Text = "No";
            reviveNRB.UseVisualStyleBackColor = true;
            // 
            // reviveYRB
            // 
            reviveYRB.AutoSize = true;
            reviveYRB.Dock = DockStyle.Left;
            reviveYRB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reviveYRB.Location = new Point(59, 0);
            reviveYRB.Name = "reviveYRB";
            reviveYRB.Size = new Size(51, 31);
            reviveYRB.TabIndex = 4;
            reviveYRB.TabStop = true;
            reviveYRB.Text = "Yes";
            reviveYRB.UseVisualStyleBackColor = true;
            reviveYRB.CheckedChanged += AllowNumTimes;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 3;
            label7.Text = "Revive:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 38);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 10;
            label2.Text = "Slowest Clear Time:";
            // 
            // slowTime
            // 
            slowTime.DecimalPlaces = 2;
            slowTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            slowTime.Location = new Point(156, 38);
            slowTime.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            slowTime.Name = "slowTime";
            slowTime.Size = new Size(120, 29);
            slowTime.TabIndex = 11;
            slowTime.ValueChanged += UpdateAverage;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 12;
            label3.Text = "Average Clear Time:";
            // 
            // averageTime
            // 
            averageTime.DecimalPlaces = 2;
            averageTime.Enabled = false;
            averageTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            averageTime.Location = new Point(157, 3);
            averageTime.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            averageTime.Name = "averageTime";
            averageTime.ReadOnly = true;
            averageTime.Size = new Size(120, 29);
            averageTime.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(averageTime);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(285, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(494, 73);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(slowTime);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(fastTime);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(99, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(779, 73);
            panel3.TabIndex = 1;
            // 
            // fastTime
            // 
            fastTime.DecimalPlaces = 2;
            fastTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fastTime.Location = new Point(156, 3);
            fastTime.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            fastTime.Name = "fastTime";
            fastTime.Size = new Size(120, 29);
            fastTime.TabIndex = 9;
            fastTime.ValueChanged += UpdateAverage;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(nameLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 73);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 27);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 10;
            label5.Text = "Ratio (%):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 31);
            label4.Name = "label4";
            label4.Size = new Size(10, 13);
            label4.TabIndex = 9;
            label4.Text = " ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Bottom;
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(0, 44);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(99, 29);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ValueChanged += BalancePercentages;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(revivePanel);
            mainPanel.Controls.Add(panel1);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(878, 106);
            mainPanel.TabIndex = 1;
            // 
            // RaidData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(mainPanel);
            Name = "RaidData";
            Size = new Size(881, 109);
            revivePanel.ResumeLayout(false);
            reviveTimePanel.ResumeLayout(false);
            reviveTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reviveNum).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slowTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)averageTime).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fastTime).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label nameLabel;
        private Label label1;
        private Panel revivePanel;
        private Panel reviveTimePanel;
        private Label label8;
        private NumericUpDown reviveNum;
        private Panel panel2;
        private RadioButton reviveNRB;
        private RadioButton reviveYRB;
        private Label label7;
        private Label label2;
        private NumericUpDown slowTime;
        private Label label3;
        private NumericUpDown averageTime;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private NumericUpDown fastTime;
        private Panel panel1;
        private Panel mainPanel;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label5;
    }
}
