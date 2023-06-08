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
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            tabPanel2 = new Panel();
            tabPage3 = new TabPage();
            timerLabel = new Label();
            countdownTimer = new System.Windows.Forms.Timer(components);
            mainPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(tabControl1);
            mainPanel.Controls.Add(timerLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1904, 598);
            mainPanel.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1904, 568);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += LoadFormDetails;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1896, 540);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Honour/Box Calculator";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1890, 534);
            panel1.TabIndex = 2;
            panel1.SizeChanged += UpdateChildren;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabPanel2);
            tabPage2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1896, 540);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "GW Results";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPanel2
            // 
            tabPanel2.AutoScroll = true;
            tabPanel2.AutoSize = true;
            tabPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tabPanel2.BorderStyle = BorderStyle.Fixed3D;
            tabPanel2.Dock = DockStyle.Fill;
            tabPanel2.Location = new Point(3, 3);
            tabPanel2.Name = "tabPanel2";
            tabPanel2.Size = new Size(1890, 534);
            tabPanel2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1896, 540);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "GW Rank Cutoff";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Dock = DockStyle.Top;
            timerLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timerLabel.Location = new Point(0, 0);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(120, 30);
            timerLabel.TabIndex = 0;
            timerLabel.Text = "Countdown";
            // 
            // countdownTimer
            // 
            countdownTimer.Tick += UpdateTime;
            // 
            // HomePageComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1904, 598);
            ControlBox = false;
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePageComponent";
            Text = "HomePageComponent";
            Load += InitialiseLayout;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private TabPage tabPage2;
        private Panel tabPanel2;
        private Label timerLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private TabPage tabPage3;
    }
}