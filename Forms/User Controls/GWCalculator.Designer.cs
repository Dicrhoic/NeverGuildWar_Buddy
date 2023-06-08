namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    partial class GWCalculator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            optionsPanel = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label5 = new Label();
            numericUpDown4 = new NumericUpDown();
            label6 = new Label();
            numericUpDown5 = new NumericUpDown();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            meatNumeric = new NumericUpDown();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            numericUpDown3 = new NumericUpDown();
            filterPanel = new Panel();
            raidChoicePanel = new Panel();
            levelSelectPanel = new FlowLayoutPanel();
            cb90 = new CheckBox();
            cb95 = new CheckBox();
            cb100 = new CheckBox();
            cb150 = new CheckBox();
            cb200 = new CheckBox();
            meatFarmPanel = new Panel();
            exPOtpnRB = new RadioButton();
            exOtpnRB = new RadioButton();
            calculatorPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            optionsPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)meatNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            filterPanel.SuspendLayout();
            raidChoicePanel.SuspendLayout();
            levelSelectPanel.SuspendLayout();
            meatFarmPanel.SuspendLayout();
            calculatorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(optionsPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(filterPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1455, 134);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // optionsPanel
            // 
            optionsPanel.Controls.Add(flowLayoutPanel2);
            optionsPanel.Controls.Add(flowLayoutPanel1);
            optionsPanel.Dock = DockStyle.Fill;
            optionsPanel.Location = new Point(3, 3);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(1449, 74);
            optionsPanel.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(numericUpDown4);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(numericUpDown5);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 32);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(759, 42);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 8;
            label5.Text = "Target Box:";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(101, 3);
            numericUpDown4.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(128, 23);
            numericUpDown4.TabIndex = 9;
            numericUpDown4.Value = new decimal(new int[] { 43, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(235, 0);
            label6.Name = "label6";
            label6.Size = new Size(134, 21);
            label6.TabIndex = 10;
            label6.Text = "Target honour(s):";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(375, 3);
            numericUpDown5.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 50000, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(131, 23);
            numericUpDown5.TabIndex = 11;
            numericUpDown5.ThousandsSeparator = true;
            numericUpDown5.Value = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown5.ValueChanged += UpdateTargetHonours;
            // 
            // button1
            // 
            button1.Location = new Point(512, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateData;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(meatNumeric);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(numericUpDown1);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(numericUpDown2);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(numericUpDown3);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1449, 32);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Current Meat:";
            // 
            // meatNumeric
            // 
            meatNumeric.Location = new Point(120, 3);
            meatNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            meatNumeric.Name = "meatNumeric";
            meatNumeric.Size = new Size(120, 23);
            meatNumeric.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(246, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 2;
            label2.Text = "Current Tokens:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(375, 3);
            numericUpDown1.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(501, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 4;
            label3.Text = "Current Box:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(608, 3);
            numericUpDown2.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(734, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 6;
            label4.Text = "Current honour(s):";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(883, 3);
            numericUpDown3.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 7;
            numericUpDown3.ThousandsSeparator = true;
            numericUpDown3.ValueChanged += UpdateCurrentHonours;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(raidChoicePanel);
            filterPanel.Dock = DockStyle.Fill;
            filterPanel.Location = new Point(3, 83);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1449, 48);
            filterPanel.TabIndex = 4;
            // 
            // raidChoicePanel
            // 
            raidChoicePanel.Controls.Add(levelSelectPanel);
            raidChoicePanel.Controls.Add(meatFarmPanel);
            raidChoicePanel.Dock = DockStyle.Fill;
            raidChoicePanel.Location = new Point(0, 0);
            raidChoicePanel.Name = "raidChoicePanel";
            raidChoicePanel.Size = new Size(1449, 48);
            raidChoicePanel.TabIndex = 1;
            raidChoicePanel.Paint += raidChoicePanel_Paint;
            // 
            // levelSelectPanel
            // 
            levelSelectPanel.Controls.Add(cb90);
            levelSelectPanel.Controls.Add(cb95);
            levelSelectPanel.Controls.Add(cb100);
            levelSelectPanel.Controls.Add(cb150);
            levelSelectPanel.Controls.Add(cb200);
            levelSelectPanel.Dock = DockStyle.Left;
            levelSelectPanel.Location = new Point(91, 0);
            levelSelectPanel.Name = "levelSelectPanel";
            levelSelectPanel.Size = new Size(668, 48);
            levelSelectPanel.TabIndex = 2;
            // 
            // cb90
            // 
            cb90.AutoSize = true;
            cb90.Enabled = false;
            cb90.Location = new Point(3, 3);
            cb90.Name = "cb90";
            cb90.Size = new Size(58, 19);
            cb90.TabIndex = 0;
            cb90.Text = "NM90";
            cb90.UseVisualStyleBackColor = true;
            cb90.CheckedChanged += UpdateCalculatorList;
            // 
            // cb95
            // 
            cb95.AutoSize = true;
            cb95.Enabled = false;
            cb95.Location = new Point(67, 3);
            cb95.Name = "cb95";
            cb95.Size = new Size(58, 19);
            cb95.TabIndex = 1;
            cb95.Text = "NM95";
            cb95.UseVisualStyleBackColor = true;
            cb95.CheckedChanged += UpdateCalculatorList;
            // 
            // cb100
            // 
            cb100.AutoSize = true;
            cb100.Enabled = false;
            cb100.Location = new Point(131, 3);
            cb100.Name = "cb100";
            cb100.Size = new Size(64, 19);
            cb100.TabIndex = 2;
            cb100.Text = "NM100";
            cb100.UseVisualStyleBackColor = true;
            cb100.CheckedChanged += UpdateCalculatorList;
            // 
            // cb150
            // 
            cb150.AutoSize = true;
            cb150.Location = new Point(201, 3);
            cb150.Name = "cb150";
            cb150.Size = new Size(64, 19);
            cb150.TabIndex = 3;
            cb150.Text = "NM150";
            cb150.UseVisualStyleBackColor = true;
            cb150.CheckedChanged += UpdateCalculatorList;
            // 
            // cb200
            // 
            cb200.AutoSize = true;
            cb200.Location = new Point(271, 3);
            cb200.Name = "cb200";
            cb200.Size = new Size(64, 19);
            cb200.TabIndex = 4;
            cb200.Text = "NM200";
            cb200.UseVisualStyleBackColor = true;
            cb200.CheckedChanged += UpdateCalculatorList;
            // 
            // meatFarmPanel
            // 
            meatFarmPanel.Controls.Add(exPOtpnRB);
            meatFarmPanel.Controls.Add(exOtpnRB);
            meatFarmPanel.Dock = DockStyle.Left;
            meatFarmPanel.Location = new Point(0, 0);
            meatFarmPanel.Name = "meatFarmPanel";
            meatFarmPanel.Size = new Size(91, 48);
            meatFarmPanel.TabIndex = 1;
            // 
            // exPOtpnRB
            // 
            exPOtpnRB.AutoSize = true;
            exPOtpnRB.Checked = true;
            exPOtpnRB.Dock = DockStyle.Top;
            exPOtpnRB.Location = new Point(0, 19);
            exPOtpnRB.Name = "exPOtpnRB";
            exPOtpnRB.Size = new Size(91, 19);
            exPOtpnRB.TabIndex = 1;
            exPOtpnRB.TabStop = true;
            exPOtpnRB.Text = "EX+";
            exPOtpnRB.UseVisualStyleBackColor = true;
            // 
            // exOtpnRB
            // 
            exOtpnRB.AutoSize = true;
            exOtpnRB.Dock = DockStyle.Top;
            exOtpnRB.Enabled = false;
            exOtpnRB.Location = new Point(0, 0);
            exOtpnRB.Name = "exOtpnRB";
            exOtpnRB.Size = new Size(91, 19);
            exOtpnRB.TabIndex = 0;
            exOtpnRB.Text = "EX";
            exOtpnRB.UseVisualStyleBackColor = true;
            // 
            // calculatorPanel
            // 
            calculatorPanel.Controls.Add(tableLayoutPanel1);
            calculatorPanel.Dock = DockStyle.Fill;
            calculatorPanel.Location = new Point(0, 0);
            calculatorPanel.Name = "calculatorPanel";
            calculatorPanel.Size = new Size(1455, 134);
            calculatorPanel.TabIndex = 3;
            // 
            // GWCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(calculatorPanel);
            Name = "GWCalculator";
            Size = new Size(1455, 134);
            tableLayoutPanel1.ResumeLayout(false);
            optionsPanel.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)meatNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            filterPanel.ResumeLayout(false);
            raidChoicePanel.ResumeLayout(false);
            levelSelectPanel.ResumeLayout(false);
            levelSelectPanel.PerformLayout();
            meatFarmPanel.ResumeLayout(false);
            meatFarmPanel.PerformLayout();
            calculatorPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel calculatorPanel;
        private Panel optionsPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label5;
        private NumericUpDown numericUpDown4;
        private Label label6;
        private NumericUpDown numericUpDown5;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private NumericUpDown meatNumeric;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private NumericUpDown numericUpDown3;
        private Panel filterPanel;
        private Panel raidChoicePanel;
        private FlowLayoutPanel levelSelectPanel;
        private CheckBox cb90;
        private CheckBox cb95;
        private CheckBox cb100;
        private CheckBox cb150;
        private CheckBox cb200;
        private Panel meatFarmPanel;
        private RadioButton exPOtpnRB;
        private RadioButton exOtpnRB;
    }
}
