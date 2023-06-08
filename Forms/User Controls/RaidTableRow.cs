using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    public partial class RaidTableRow : UserControl
    {
        public RaidTableRow(string level, decimal honour, decimal meatCost, decimal battles,
           decimal totalMeat, decimal token, decimal totalHonour, decimal pot)
        {
            InitializeComponent();
            nameLabel.Text = level;
            honourLabel.Text = $"{honour}";
            meatLabel.Text = $"{meatCost}";
            battleLabel.Text = $"{battles}";
            meatCostLabel.Text = $"{totalMeat}";
            tokenLabel.Text = $"{token}";
            potLabel.Text = $"{pot}";
            honourTotalLabel.Text = $"{totalHonour}";

        }


        public void UpdateHonourPerMin(decimal str)
        {
            hpm.Text = $"{str}";
        }

        private void DisplaysDetail(object sender, EventArgs e)
        {
            if(sender is Control)
            {
                Label label = (Label)sender;
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                if (label is not null )
                {
                    switch(label.Tag)
                    {
                        case "name":
                            ToolTip1.SetToolTip(label, "Name of raid");
                            break;
                        case "honourEarn":
                            ToolTip1.SetToolTip(label, "Honours earned per raid");
                            break;
                        case "meat":
                            ToolTip1.SetToolTip(label, "Meat cost per raid");
                            break;
                        case "battles":
                            ToolTip1.SetToolTip(label, "Number of battles needed");
                            break;
                        case "meatCost":
                            ToolTip1.SetToolTip(label, "Total cost of meat");
                            break;
                        case "token":
                            ToolTip1.SetToolTip(label, "Tokens earned");
                            break;
                        case "honourTotal":
                            ToolTip1.SetToolTip(label, "Total honours earned");
                            break;
                        case "pot":
                            ToolTip1.SetToolTip(label, "Amount of potions needed*");
                            break;
                        case "honrpermin":
                            ToolTip1.SetToolTip(label, "Honours earned per minute");
                            break;
                    }
                }
            }

        }
    }
}
