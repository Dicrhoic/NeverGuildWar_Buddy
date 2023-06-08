namespace NeverGuildWar_Buddy.Forms
{
    partial class Settings
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            sidePanel = new Panel();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            dateBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 277);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sidePanel);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dates";
            // 
            // sidePanel
            // 
            sidePanel.Controls.Add(label2);
            sidePanel.Controls.Add(dateTimePicker2);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(dateBtn);
            sidePanel.Controls.Add(dateTimePicker1);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(3, 19);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(453, 184);
            sidePanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 82);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "\"dd/mm/yyyy hh:mm\"";
            dateTimePicker2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(0, 100);
            dateTimePicker2.MinDate = new DateTime(2022, 11, 2, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(356, 35);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.Value = new DateTime(2022, 11, 2, 2, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Start Date:";
            // 
            // dateBtn
            // 
            dateBtn.Location = new Point(-3, 141);
            dateBtn.Name = "dateBtn";
            dateBtn.Size = new Size(139, 35);
            dateBtn.TabIndex = 1;
            dateBtn.Text = "Change Date";
            dateBtn.UseVisualStyleBackColor = true;
            dateBtn.Click += ChangeDate;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(0, 27);
            dateTimePicker1.MinDate = new DateTime(2022, 11, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(356, 35);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2022, 11, 1, 21, 0, 0, 0);
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 277);
            Controls.Add(panel1);
            Name = "Settings";
            Text = "Settings";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel sidePanel;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button dateBtn;
        private DateTimePicker dateTimePicker1;
    }
}