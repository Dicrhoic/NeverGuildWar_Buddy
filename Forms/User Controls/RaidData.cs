using NeverGuildWar_Buddy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    public partial class RaidData : UserControl
    {
        RaidInfo raid;
        RaidComparer raidComparer;
        public RaidData(string raidName, RaidComparer comparer)
        {
            InitializeComponent();
            nameLabel.Text = raidName;
            reviveNRB.Checked = true;
            raid = new(raidName, averageTime.Value.ToString());
            switch (raidName)
            {
                case "NM90":
                    raid.cost = (int)raidCost.NM90;
                    raid.honours = (int)raidHonours.NM90;
                    break;
                case "NM95":
                    raid.cost = (int)raidCost.NM95;
                    raid.honours = (int)raidHonours.NM95;
                    break;
                case "NM100":
                    raid.cost = (int)raidCost.NM100;
                    raid.honours = (int)raidHonours.NM100;
                    break;
                case "NM150":
                    raid.cost = (int)raidCost.NM150;
                    raid.honours = (int)raidHonours.NM150;
                    break;
                case "NM200":
                    raid.cost = (int)raidCost.NM200;
                    raid.honours = (int)raidHonours.NM200;
                    break;
            }
            raidComparer = comparer;
            comparer.ValidateRaid(raidName, raid);
            comparer.AddNumeric(raidName, numericUpDown1);
        }

        private void AllowNumTimes(object sender, EventArgs e)
        {
            switch (reviveYRB.Checked)
            {
                case true:
                    reviveNum.Enabled = true;
                    break;
                case false:
                    reviveNum.Enabled = false;
                    break;
            }
        }

        private void UpdateAverage(object sender, EventArgs e)
        {
            if (fastTime.Value > 0 && slowTime.Value > 0)
            {
                decimal sum = fastTime.Value + slowTime.Value;
                decimal average = Decimal.Divide(sum, 2);
                average = Math.Round(average, 2);
                TimeSpan time = TimeSpan.FromMinutes((double)average);
                string conv = $"{time.Minutes}.{time.Seconds}";
                decimal result = 0;
                decimal.TryParse(conv, out result);
                if (Decimal.TryParse(conv, out result))
                    Console.WriteLine(result.ToString("0.##"));
                Debug.WriteLine($"Average: {time} con: {conv}");
                averageTime.Value = result;
                raid.time = conv;
                SetEffScore();
            }
        }

        private void UpdateRevTimes(object sender, EventArgs e)
        {
            int revs = (int)reviveNum.Value;
            raid.revive = revs;
            SetEffScore();
        }

        private void SetEffScore()
        {
            string name = nameLabel.Text;
            decimal time = averageTime.Value;
            raidComparer.UpdateEffScore(name, time);

        }

        private void BalancePercentages(object sender, EventArgs e)
        {
            raidComparer.BalanceNumerics(numericUpDown1);
        }
    }
}
