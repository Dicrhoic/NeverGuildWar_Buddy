using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverGuildWar_Buddy.Classes
{
    internal class MBHelper
    {
        public void ErrorMB(string message, string caption)
        {
            string msg = message;
            string cap = caption;
            MessageBox.Show(message, caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
        }
        public void SuccessMB(string message, string caption)
        {
            string msg = message;
            string cap = caption;
            MessageBox.Show(message, caption,
                                MessageBoxButtons.OK
                                );
        }
    }
}
