namespace NeverGuildWar_Buddy.Forms
{
    partial class ProgressBar
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
            this.progressPercentageLabel = new System.Windows.Forms.Label();
            this.caption = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressPercentageLabel
            // 
            this.progressPercentageLabel.AutoSize = true;
            this.progressPercentageLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressPercentageLabel.Location = new System.Drawing.Point(1241, 97);
            this.progressPercentageLabel.Name = "progressPercentageLabel";
            this.progressPercentageLabel.Size = new System.Drawing.Size(77, 40);
            this.progressPercentageLabel.TabIndex = 8;
            this.progressPercentageLabel.Text = "---%";
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caption.Location = new System.Drawing.Point(48, 46);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(66, 30);
            this.caption.TabIndex = 7;
            this.caption.Text = "lorem";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 95);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1159, 42);
            this.progressBar1.TabIndex = 6;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 183);
            this.ControlBox = false;
            this.Controls.Add(this.progressPercentageLabel);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressBar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label progressPercentageLabel;
        private Label caption;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}