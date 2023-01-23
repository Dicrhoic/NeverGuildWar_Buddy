namespace NeverGuildWar_Buddy.Forms.SetupForms
{
    partial class ClassSelector
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.jobSlotPB = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobSlotPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.jobSlotPB);
            this.panel1.Controls.Add(this.searchTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 258);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectedJob);
            // 
            // jobSlotPB
            // 
            this.jobSlotPB.Location = new System.Drawing.Point(117, 64);
            this.jobSlotPB.MaximumSize = new System.Drawing.Size(207, 94);
            this.jobSlotPB.MinimumSize = new System.Drawing.Size(207, 94);
            this.jobSlotPB.Name = "jobSlotPB";
            this.jobSlotPB.Size = new System.Drawing.Size(207, 94);
            this.jobSlotPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jobSlotPB.TabIndex = 6;
            this.jobSlotPB.TabStop = false;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTB.Location = new System.Drawing.Point(12, 12);
            this.searchTB.Name = "searchTB";
            this.searchTB.PlaceholderText = "Enter Job Name";
            this.searchTB.Size = new System.Drawing.Size(443, 29);
            this.searchTB.TabIndex = 5;
            this.searchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindJob);
            // 
            // ClassSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 258);
            this.Controls.Add(this.panel1);
            this.Name = "ClassSelector";
            this.Text = "ClassSelector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobSlotPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox jobSlotPB;
        private TextBox searchTB;
    }
}