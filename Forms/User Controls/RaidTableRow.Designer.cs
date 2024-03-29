﻿namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    partial class RaidTableRow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.potLabel = new System.Windows.Forms.Label();
            this.honourTotalLabel = new System.Windows.Forms.Label();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.meatCostLabel = new System.Windows.Forms.Label();
            this.battleLabel = new System.Windows.Forms.Label();
            this.honourLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.meatLabel = new System.Windows.Forms.Label();
            this.hpm = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.Controls.Add(this.potLabel, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.honourTotalLabel, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.tokenLabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.meatCostLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.battleLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.honourLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.meatLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.hpm, 8, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1417, 36);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // potLabel
            // 
            this.potLabel.AutoSize = true;
            this.potLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.potLabel.Location = new System.Drawing.Point(1180, 0);
            this.potLabel.Name = "potLabel";
            this.potLabel.Size = new System.Drawing.Size(46, 30);
            this.potLabel.TabIndex = 7;
            this.potLabel.Tag = "pot";
            this.potLabel.Text = "999";
            this.potLabel.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // honourTotalLabel
            // 
            this.honourTotalLabel.AutoSize = true;
            this.honourTotalLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.honourTotalLabel.Location = new System.Drawing.Point(1025, 0);
            this.honourTotalLabel.Name = "honourTotalLabel";
            this.honourTotalLabel.Size = new System.Drawing.Size(138, 30);
            this.honourTotalLabel.TabIndex = 6;
            this.honourTotalLabel.Tag = "honourTotal";
            this.honourTotalLabel.Text = "1,004,120,000";
            this.honourTotalLabel.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tokenLabel.Location = new System.Drawing.Point(892, 0);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(73, 30);
            this.tokenLabel.TabIndex = 5;
            this.tokenLabel.Tag = "token";
            this.tokenLabel.Text = "90,248";
            this.tokenLabel.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // meatCostLabel
            // 
            this.meatCostLabel.AutoSize = true;
            this.meatCostLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.meatCostLabel.Location = new System.Drawing.Point(737, 0);
            this.meatCostLabel.Name = "meatCostLabel";
            this.meatCostLabel.Size = new System.Drawing.Size(70, 30);
            this.meatCostLabel.TabIndex = 4;
            this.meatCostLabel.Tag = "meatCost";
            this.meatCostLabel.Text = "-2,850";
            this.meatCostLabel.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // battleLabel
            // 
            this.battleLabel.AutoSize = true;
            this.battleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.battleLabel.Location = new System.Drawing.Point(630, 0);
            this.battleLabel.Name = "battleLabel";
            this.battleLabel.Size = new System.Drawing.Size(57, 30);
            this.battleLabel.TabIndex = 3;
            this.battleLabel.Tag = "battles";
            this.battleLabel.Text = "5000";
            this.battleLabel.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // honourLabel
            // 
            this.honourLabel.AutoSize = true;
            this.honourLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.honourLabel.Location = new System.Drawing.Point(341, 0);
            this.honourLabel.Name = "honourLabel";
            this.honourLabel.Size = new System.Drawing.Size(101, 30);
            this.honourLabel.TabIndex = 1;
            this.honourLabel.Tag = "honourEarn";
            this.honourLabel.Text = "10200000";
            this.honourLabel.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 30);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Tag = "name";
            this.nameLabel.Text = "NM 200";
            this.nameLabel.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // meatLabel
            // 
            this.meatLabel.AutoSize = true;
            this.meatLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.meatLabel.Location = new System.Drawing.Point(465, 0);
            this.meatLabel.Name = "meatLabel";
            this.meatLabel.Size = new System.Drawing.Size(68, 30);
            this.meatLabel.TabIndex = 2;
            this.meatLabel.Tag = "meat";
            this.meatLabel.Text = "-meat";
            this.meatLabel.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // hpm
            // 
            this.hpm.AutoSize = true;
            this.hpm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hpm.Location = new System.Drawing.Point(1272, 0);
            this.hpm.Name = "hpm";
            this.hpm.Size = new System.Drawing.Size(51, 30);
            this.hpm.TabIndex = 8;
            this.hpm.Tag = "honrpermin";
            this.hpm.Text = "N/A";
            this.hpm.MouseHover += new System.EventHandler(this.DisplaysDetail);
            // 
            // RaidTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RaidTableRow";
            this.Size = new System.Drawing.Size(1417, 36);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label potLabel;
        private Label honourTotalLabel;
        private Label tokenLabel;
        private Label meatCostLabel;
        private Label battleLabel;
        private Label honourLabel;
        private Label nameLabel;
        private Label meatLabel;
        private Label hpm;
    }
}
