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

namespace NeverGuildWar_Buddy.Forms
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
        }

        public void SetMinMaxProg(int min, int max, int prog)
        {
            progressBar1.Minimum = min;
            progressBar1.Maximum = max;
            progressBar1.Step = prog;
        }

        public void SetCaption(string caption)
        {
            this.caption.Text = caption;
        }

        public void UpdateBarProgress(int percentage)
        {
            Decimal per;
            int conv = percentage;
            if (progressBar1.Maximum > 100)
            {
                per = Decimal.Divide(progressBar1.Maximum, 100);
                per = Math.Round(per);
                decimal div = Decimal.Divide(percentage, per);
                div = Math.Round(div);
                conv = (int)div;
            }
            Debug.WriteLine($"{conv}%");
            string valueString = conv.ToString() + "%";
            progressPercentageLabel.Text = (valueString);
            progressBar1.Value = percentage;
        }

        public void BarStepUp()
        {
            progressBar1.PerformStep();
        }
    }
}
