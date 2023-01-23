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
        DateTime endTime = new DateTime(2022, 11, 14, 02, 00, 00);
        DateTime startTime = new DateTime(2022, 11, 6, 21, 00, 00);
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
            TimeSpan ts = endTime.Subtract(now);
            TimeSpan ts1 = startTime.Subtract(now);
            //Debug.WriteLine($"{ts.Days} compared to {ts1.Days}");
           
                if (startTime < now.AddHours(24))
                {
                    //Debug.WriteLine($"Time is less than 24 hours");
                    string time = $"{ts1.Hours}:{ts1.Minutes}:{ts1.Seconds} until next GW";
                    //Debug.WriteLine($"Time is  {ts1.Hours}:{ts1.Minutes}:{ts1.Seconds} less than 24 hours");
                    timerLabel.Text = time;
                }
                if(startTime > now.AddDays(1))  
                {
                    string time = $"{ts1.Days} day(s) until next GW";
                    timerLabel.Text = time;
                }
            

            if (startTime < now)
            {
                //Debug.WriteLine("Passed Start time");
                string word = "ends";         
                string layout = $"GW {word} in";

                if (endTime < now.AddHours(24))
                {
                    //Debug.WriteLine($"Time is less than 24 hours");
                    string time = $"{layout} {ts.Hours}:{ts.Minutes}:{ts.Seconds}";
                    timerLabel.Text = time;
                }
                else
                {
                    string time = $"{layout} {ts.Days} days {ts.Hours}(hrs):{ts.Minutes}(mins)";
                    timerLabel.Text = time;
                }
            }




        }

    }
}
