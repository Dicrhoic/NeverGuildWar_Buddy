using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverGuildWar_Buddy.Classes
{
    internal class FormManager
    {
        public void LoadForm(object form, Panel mainPanel)
        {
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.Clear();
            }
            Form? f = form as Form;
            if (f != null)
            {
                f.TopLevel = false;
                f.AutoScroll = false;
                mainPanel.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Tag = f;
                f.Show();
            }
        }
    }
}
