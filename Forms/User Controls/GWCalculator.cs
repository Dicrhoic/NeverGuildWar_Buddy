using NeverGuildWar_Buddy.Classes;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    public partial class GWCalculator : UserControl
    {
        List<string> levels = new List<string>();
        List<string> previousLevels = new List<string>();
        CalculatorClass calculator = new CalculatorClass();
        RaidComparer raidComparer = new RaidComparer();
        private int days = 0;
        public GWCalculator()
        {
            InitializeComponent();
            TimeSpan daysPast = DateTime.Now.Subtract(Properties.Settings.Default.StartDate);
            days = daysPast.Days;
            Debug.WriteLine(days);
            //LockCBS();
            SetupCheckBoxes();
            UnlockCBS();
            numericUpDown3.Value = Properties.Settings.Default.CurrentHon;
            numericUpDown5.Value = Properties.Settings.Default.TargetHon;
        }

        private void UnlockCBS()
        {
            cb90.Enabled = true;
            cb95.Enabled = true;
            cb100.Enabled = true;
            cb150.Enabled = true;
            cb200.Enabled = true;
        }


        private void LockCBS()
        {
            cb90.Enabled = false;
            cb95.Enabled = false;
            cb100.Enabled = false;
            cb150.Enabled = false;
            cb200.Enabled = false;
        }

        private void SetupCheckBoxes()
        {
            switch (days)
            {
                case 0:
                    cb90.Enabled = true;
                    break;
                case 2:
                    cb90.Enabled = true;
                    cb95.Enabled = true;
                    break;
                case 3:
                    cb90.Enabled = true;
                    cb95.Enabled = true;
                    cb100.Enabled = true;
                    cb150.Enabled = true;
                    break;
                case 4:
                    cb90.Enabled = true;
                    cb95.Enabled = true;
                    cb100.Enabled = true;
                    cb150.Enabled = true;
                    cb200.Enabled = true;
                    break;
                default:
                    cb90.Enabled = true;
                    cb95.Enabled = true;
                    cb100.Enabled = true;
                    cb150.Enabled = true;
                    cb200.Enabled = true;
                    break;

            }
        }

        public int CheckboxesChecked()
        {

            List<string> list = new List<string>();
            int count = 0;
            Control[] raidPanel = tableLayoutPanel1.Controls.Find("RaidDatas", true);
            if (raidPanel.Length != 0)
            {
                tableLayoutPanel1.Controls.Remove(raidPanel[0]);

            }
            foreach (Control c in levelSelectPanel.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox box = (CheckBox)c;
                    if (box.Checked)
                    {
                        list.Add(box.Text);
                        count++;
                    }
                }
            }
            Debug.WriteLine(previousLevels.Count);
            levels = list;
            if (previousLevels.Count > 0)
            {
                var distinct = previousLevels.Except(levels).ToList();
                foreach (var level in distinct)
                {
                    Debug.WriteLine($"Distinct Level: {level}");
                    raidComparer.RemoveRaid(level);
                }

            }
            raidComparer.PrintList();
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 1;
            panel.RowCount = 0;
            panel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            panel.AutoSize = true;
            GWRaids gWRaids = new GWRaids();
            gWRaids.ResizeTable(tableLayoutPanel1);
            panel.Name = "RaidDatas";
            panel.AutoScroll = true;
            tableLayoutPanel1.Controls.Add(panel);
            CreateRaidPanels(list);
            previousLevels = list;
            return count;
        }

        private void CreateRaidPanels(List<string> list)
        {
            List<string> raids = list.Distinct().ToList();
            Control[] raidPanel = tableLayoutPanel1.Controls.Find("RaidDatas", true);
            if (raidPanel != null)
            {
                foreach (string raid in raids)
                {
                    RaidData data = new(raid, raidComparer);
                    data.Width = tableLayoutPanel1.Width;
                    //Debug.WriteLine($"Adding  {raid}");
                    raidPanel[0].Controls.Add(data);
                }
            }

        }

        private void UpdateCalculatorList(object sender, EventArgs e)
        {
            int count = CheckboxesChecked();
            //Debug.WriteLine($"{count} cbs checked");
        }

        private List<int> ConvertedToInt()
        {
            List<int> list = new List<int>();
            foreach (string level in levels)
            {
                switch (level)
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

            if (numericUpDown5.Value > 0)
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
            decimal ration = 0;
            decimal time = 0;
            switch (type)
            {
                case (int)raids.NM90:
                    ration = raidComparer.HonourValues(target, "NM90");
                    time = raidComparer.AvgClearTime("NM90");
                    Debug.WriteLine($"NM200 ration: {ration}");
                    NM90 m90 = new(false, 0, 0, ration);
                    m90.hpm = time;
                    m90.ResizeTable(tableLayoutPanel1);
                    switch (exPOtpnRB.Checked)
                    {
                        case true:
                            EXPlus exP = new();
                            m90.SetMeatFarm(exP);
                            break;
                        case false:
                            EX ex = new();
                            m90.SetMeatFarm(ex);
                            break;
                    }
                    List<RaidTableRow> rows = m90.RequiredNumbers();
                    foreach (RaidTableRow row in rows)
                    {
                        //m200.ResizeTable(tableLayoutPanel1);
                        tableLayoutPanel1.Controls.Add(row);
                    }
                    break;
                case (int)raids.NM95:
                    ration = raidComparer.HonourValues(target, "NM95");
                    Debug.WriteLine($"NM200 ration: {ration}");
                    NM95 m95 = new(false, 0, 0, ration);
                    time = raidComparer.AvgClearTime("NM95");
                    m95.hpm = time;
                    m95.ResizeTable(tableLayoutPanel1);
                    switch (exPOtpnRB.Checked)
                    {
                        case true:
                            EXPlus exP = new();
                            m95.SetMeatFarm(exP);
                            break;
                        case false:
                            EX ex = new();
                            m95.SetMeatFarm(ex);
                            break;
                    }
                    List<RaidTableRow> rows1 = m95.RequiredNumbers();
                    foreach (RaidTableRow row in rows1)
                    {
                        //m200.ResizeTable(tableLayoutPanel1);
                        tableLayoutPanel1.Controls.Add(row);
                    }
                    break;
                case (int)raids.NM100:
                    ration = raidComparer.HonourValues(target, "NM100");
                    Debug.WriteLine($"NM100 ration: {ration}");
                    NM100 m100 = new(false, 0, 0, ration);
                    time = raidComparer.AvgClearTime("NM100");
                    m100.hpm = time;
                    m100.ResizeTable(tableLayoutPanel1);
                    switch (exPOtpnRB.Checked)
                    {
                        case true:
                            EXPlus exP = new();
                            m100.SetMeatFarm(exP);
                            break;
                        case false:
                            EX ex = new();
                            m100.SetMeatFarm(ex);
                            break;
                    }
                    List<RaidTableRow> rows2 = m100.RequiredNumbers();
                    foreach (RaidTableRow row in rows2)
                    {
                        //m200.ResizeTable(tableLayoutPanel1);
                        tableLayoutPanel1.Controls.Add(row);
                    }
                    break;
                case (int)raids.NM150:
                    ration = raidComparer.HonourValues(target, "NM150");
                    Debug.WriteLine($"NM200 ration: {ration}");
                    NM150 m150 = new(false, 0, 0, ration);
                    time = raidComparer.AvgClearTime("NM150");
                    m150.hpm = time;
                    m150.ResizeTable(tableLayoutPanel1);
                    switch (exPOtpnRB.Checked)
                    {
                        case true:
                            EXPlus exP = new();
                            m150.SetMeatFarm(exP);
                            break;
                        case false:
                            EX ex = new();
                            m150.SetMeatFarm(ex);
                            break;
                    }
                    List<RaidTableRow> rows3 = m150.RequiredNumbers();
                    foreach (RaidTableRow row in rows3)
                    {
                        //m200.ResizeTable(tableLayoutPanel1);
                        tableLayoutPanel1.Controls.Add(row);
                    }
                    break;
                case (int)raids.NM200:
                    ration = raidComparer.HonourValues(target, "NM200");
                    Debug.WriteLine($"NM200 ration: {ration}");
                    NM200 m200 = new(false, 0, 0, ration);
                    time = raidComparer.AvgClearTime("NM200");
                    m200.hpm = time;
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
                    List<RaidTableRow> rows4 = m200.RequiredNumbers();
                    foreach (RaidTableRow row in rows4)
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
        private void UpdateCurrentHonours(object sender, EventArgs e)
        {
            long t = (long)numericUpDown3.Value;
            Properties.Settings.Default.CurrentHon = t;
            Properties.Settings.Default.Save();
        }


        private void UpdateTargetHonours(object sender, EventArgs e)
        {
            long t = (long)numericUpDown5.Value;
            Properties.Settings.Default.TargetHon = t;
            Properties.Settings.Default.Save();
        }
    }
}
