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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd MMM yyyy hh:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd MMM yyyy hh:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Value = Properties.Settings.Default.StartDate;
            dateTimePicker2.Value = Properties.Settings.Default.EndDate;
        }

        private void ChangeDate(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            bool pass = ValidDates(start, end);
            if (pass)
            {
                Properties.Settings.Default.EndDate = end;
                Properties.Settings.Default.StartDate = start;
                Properties.Settings.Default.Save();
            }
        }

        private bool ValidDates(DateTime start, DateTime end)
        {
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now.Subtract(start);
            TimeSpan ts = end.Subtract(start);
            Debug.WriteLine(ts);
            if (ts < TimeSpan.Zero)
            {
                Debug.WriteLine($"Invalid date selected\nEnd date is before start date");
            }
            if (ts > TimeSpan.Zero)
            {
                return true;
            }

            return false;

        }
    }
}
