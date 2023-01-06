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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.revivePanel = new System.Windows.Forms.Panel();
            this.reviveTimePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.reviveNum = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reviveNRB = new System.Windows.Forms.RadioButton();
            this.reviveYRB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.revivePanel.SuspendLayout();
            this.reviveTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviveNum)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 73);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Raid Name:";
            // 
            // revivePanel
            // 
            this.revivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revivePanel.Controls.Add(this.panel2);
            this.revivePanel.Controls.Add(this.reviveTimePanel);
            this.revivePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.revivePanel.Location = new System.Drawing.Point(0, 73);
            this.revivePanel.Name = "revivePanel";
            this.revivePanel.Size = new System.Drawing.Size(878, 88);
            this.revivePanel.TabIndex = 4;
            // 
            // reviveTimePanel
            // 
            this.reviveTimePanel.Controls.Add(this.label8);
            this.reviveTimePanel.Controls.Add(this.reviveNum);
            this.reviveTimePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reviveTimePanel.Location = new System.Drawing.Point(0, 44);
            this.reviveTimePanel.Name = "reviveTimePanel";
            this.reviveTimePanel.Size = new System.Drawing.Size(876, 42);
            this.reviveTimePanel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Revive Times";
            // 
            // reviveNum
            // 
            this.reviveNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reviveNum.Location = new System.Drawing.Point(107, 3);
            this.reviveNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.reviveNum.Name = "reviveNum";
            this.reviveNum.Size = new System.Drawing.Size(120, 29);
            this.reviveNum.TabIndex = 7;
            this.reviveNum.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reviveNRB);
            this.panel2.Controls.Add(this.reviveYRB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 44);
            this.panel2.TabIndex = 4;
            // 
            // reviveNRB
            // 
            this.reviveNRB.AutoSize = true;
            this.reviveNRB.Dock = System.Windows.Forms.DockStyle.Left;
            this.reviveNRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reviveNRB.Location = new System.Drawing.Point(110, 0);
            this.reviveNRB.Name = "reviveNRB";
            this.reviveNRB.Size = new System.Drawing.Size(49, 44);
            this.reviveNRB.TabIndex = 5;
            this.reviveNRB.TabStop = true;
            this.reviveNRB.Text = "No";
            this.reviveNRB.UseVisualStyleBackColor = true;
            // 
            // reviveYRB
            // 
            this.reviveYRB.AutoSize = true;
            this.reviveYRB.Dock = System.Windows.Forms.DockStyle.Left;
            this.reviveYRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reviveYRB.Location = new System.Drawing.Point(59, 0);
            this.reviveYRB.Name = "reviveYRB";
            this.reviveYRB.Size = new System.Drawing.Size(51, 44);
            this.reviveYRB.TabIndex = 4;
            this.reviveYRB.TabStop = true;
            this.reviveYRB.Text = "Yes";
            this.reviveYRB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Revive:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.numericUpDown3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(99, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 73);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fastest Clear Time:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(156, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Slowest Clear Time:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown2.Location = new System.Drawing.Point(156, 38);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(334, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Average Clear Time:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown3.Location = new System.Drawing.Point(486, 38);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown3.TabIndex = 13;
            // 
            // RaidData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.revivePanel);
            this.Controls.Add(this.panel1);
            this.Name = "RaidData";
            this.Size = new System.Drawing.Size(878, 161);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.revivePanel.ResumeLayout(false);
            this.reviveTimePanel.ResumeLayout(false);
            this.reviveTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviveNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Panel revivePanel;
        private Panel reviveTimePanel;
        private Label label8;
        private NumericUpDown reviveNum;
        private Panel panel2;
        private RadioButton reviveNRB;
        private RadioButton reviveYRB;
        private Label label7;
        private Panel panel3;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown3;
    }
}
