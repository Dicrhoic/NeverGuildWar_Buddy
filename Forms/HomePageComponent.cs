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
using NeverGuildWar_Buddy.Classes;
using NeverGuildWar_Buddy.Forms.User_Controls;

namespace NeverGuildWar_Buddy.Forms
{
    public partial class HomePageComponent : Form
    {
        FormManager formManager = new FormManager();
        DateTime endTime = new DateTime(2023, 4, 28, 02, 00, 00);
        DateTime startTime = new DateTime(2023, 4, 21, 21, 00, 00);
        public HomePageComponent()
        {
            DateTime settingsEnd = Properties.Settings.Default.EndDate;
            DateTime settingsStart = Properties.Settings.Default.StartDate;
            endTime = settingsEnd;
            startTime = settingsStart;
            InitializeComponent();
            LoadCalculator();
            LoadTimer();
            LoadLog();
        }

        private void LoadLog()
        {
            GWLog log = new GWLog();
            log.Dock = DockStyle.Fill;
            Debug.WriteLine(log.Height);
            log.Height = tabPanel2.Height;
            Debug.WriteLine(tabPanel2.Height);
            tabPanel2.Controls.Add(log);
        }

        private void LoadFormDetails(object sender, EventArgs e)
        {

        }

        private void InitialiseLayout(object sender, EventArgs e)
        {

        }

        void LoadCalculator()
        {
            GWCalculator calculator = new GWCalculator();
            panel1.Controls.Add(calculator);
        }

        void LoadTimer()
        {
            Label time = (Label)mainPanel.Controls["timerLabel"];
            if (time is null)
            {
                timerLabel = new Label();
                mainPanel.Controls.Add(timerLabel);
            }
            countdownTimer.Start();
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            //Debug.WriteLine("Ticking");
            DateTime now = DateTime.Now;
            //Debug.WriteLine($"{startTime}-{now}\n{endTime}-{now}");
            TimeSpan ts = endTime.Subtract(now);
            TimeSpan ts1 = startTime - (now);
            //Debug.WriteLine($"{ts.Days} compared to {ts1.Days}");
            int endDay = Math.Abs(ts.Days);
            int startDay = Math.Abs(ts1.Days);
            //Debug.WriteLine($"{startDay} compared to {endDay}");
            if (startDay > 0 && endDay < 0)
            {
                string time = $"{ts1.Days} day(s) until next GW";
                timerLabel.Text = time;
            }
            if (startDay == 1)
            {
                string time = $"{ts1.Hours}:{ts1.Minutes}:{ts1.Seconds} until next GW";
                //Debug.WriteLine($"Time is  {ts1.Hours}:{ts1.Minutes}:{ts1.Seconds} less than 24 hours");
                timerLabel.Text = time;
            }
            if (startDay == 0 && endDay > 0)
            {
                string layout = $"GW ends in";
                string time = $"{layout} {ts.Days} day(s)";
                timerLabel.Text = time;
            }
            if (startDay == 0 && endDay < 0)
            {
                string layout = $"GW ends in";
                string time = $"{layout} {ts.Hours}:{ts.Minutes}:{ts.Seconds}";
                timerLabel.Text = time;
            }





        }

        private void UpdateChildren(object sender, EventArgs e)
        {
            //Debug.WriteLine("Size Changed");
            foreach (Control c in panel1.Controls)
            {
                c.Height = panel1.Height;
                c.Width = panel1.Width;
                //.WriteLine(c.Height);
            }
        }
    }
}
