namespace NeverGuildWar_Buddy.Forms
{
    partial class DataForm
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
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 28);
            panel1.TabIndex = 2;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Dock = DockStyle.Left;
            radioButton2.Location = new Point(76, 0);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 28);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Summon";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Left;
            radioButton1.Location = new Point(0, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 28);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Character";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 291);
            panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Data";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Dock = DockStyle.Left;
            radioButton3.Location = new Point(150, 0);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(69, 28);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Weapon";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(792, 256);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Data";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "wind", "fire", "water", "earth", "light", "dark" });
            comboBox2.Location = new Point(23, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(729, 23);
            comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Wind", "Fire", "Water", "Earth", "Light", "Dark" });
            comboBox1.Location = new Point(23, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(729, 23);
            comboBox1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(273, 196);
            button1.Name = "button1";
            button1.Size = new Size(207, 42);
            button1.TabIndex = 15;
            button1.Text = "Add Data";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 129);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter Image Link";
            textBox4.Size = new Size(731, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 158);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter Link";
            textBox5.Size = new Size(731, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 43);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Name";
            textBox2.Size = new Size(731, 23);
            textBox2.TabIndex = 12;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 291);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DataForm";
            Text = "DataForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox2;
    }
}