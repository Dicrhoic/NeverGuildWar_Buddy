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
    }
}
