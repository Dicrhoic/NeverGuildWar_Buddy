using NeverGuildWar_Buddy.Classes;
using System.Diagnostics;

namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    public partial class GWCalculator : UserControl
    {   
        List<string> levels = new List<string>();
        CalculatorClass calculator = new CalculatorClass();
        public GWCalculator()
        {
            InitializeComponent();
        }

        public int CheckboxesChecked()
        {
            List<string> list = new List<string>();
            int count = 0;
            foreach (Control c in levelSelectPanel.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox box = (CheckBox)c; 
                    if(box.Checked)
                    {
                        list.Add(box.Text);
                        count++;
                    }
                }
            }
            levels = list;
            return count;
        }

        private void UpdateCalculatorList(object sender, EventArgs e)
        {
            int count = CheckboxesChecked();
            Debug.WriteLine($"{count} cbs checked");
        }

        private List<int> ConvertedToInt()
        {   
            List<int> list = new List<int>();
            foreach(string level in levels) 
            {
                switch(level)
                {
                    case "NM90":
                        list.Add((int)raids.NM90);
                        break;
                    case "NM95":
                        list.Add((int)raids.NM95);
                        break;
                    case "NM100":
                        list.Add((int)raids.NM100);
                        break;
                    case "NM150":
                        list.Add((int)raids.NM150);
                        break;
                    case "NM200":
                        Debug.WriteLine($"Adding {(int)raids.NM200}");
                        list.Add((int)raids.NM200);
                        break;
                }
            }
            return list;
        }
        private void CreateRows(List<int> data)
        {
          
            if(numericUpDown5.Value > 0)
            {                
                Decimal target = numericUpDown5.Value;
                Debug.WriteLine(target);
                if (numericUpDown3.Value != 0)
                {
                    target = target - numericUpDown3.Value;
                }
                foreach (int c in data)
                {
                    Createrow(c, target);

                }

            }
          
        }

        private void Createrow(int type, decimal target)
        {
            Debug.WriteLine($"Type: {type}");
            switch (type)
            {   
                case (int)raids.NM90:
                    break;
                case (int)raids.NM95:
                    break;
                case (int)raids.NM100:
                    break;
                case (int)raids.NM150:
                    break;
                case (int)raids.NM200:
                    Debug.WriteLine("NM200");
                    NM200 m200 = new(false, 0, 0, target);
                    m200.ResizeTable(tableLayoutPanel1);
                    switch (exPOtpnRB.Checked)
                    {
                        case true:
                            EXPlus exP = new();
                            m200.SetMeatFarm(exP);
                            break;
                        case false:
                            EX ex = new();
                            m200.SetMeatFarm(ex);
                            break;
                    }
                    List<RaidTableRow> rows = m200.RequiredNumbers();
                    foreach (RaidTableRow row in rows)
                    {
                        //m200.ResizeTable(tableLayoutPanel1);
                        tableLayoutPanel1.Controls.Add(row);
                    }
                    break;
            }
        }

        private void CreateData(object sender, EventArgs e)
        {
            List<int> rows = ConvertedToInt();
            CreateRows(rows);   
        }

        private void raidChoicePanel_Paint(object sender, PaintEventArgs e)
        {

        }

         
    }
}
