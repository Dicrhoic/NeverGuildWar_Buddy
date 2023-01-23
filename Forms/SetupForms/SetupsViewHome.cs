using GBF_Never_Buddy.Classes;
using NeverGuildWar_Buddy.Classes;
using NeverGuildWar_Buddy.Classes.SQLite;
using NeverGuildWar_Buddy.Forms.User_Controls;
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
using static GBF_Never_Buddy.Classes.GameDataClasses.Weapon;

namespace NeverGuildWar_Buddy.Forms.SetupForms
{
    public partial class SetupsViewHome : Form
    {
        List<SetupSpecs> setupDetails;
        ItemComparer comparer;
        SetupSQLiteHelper databaseHelper = new();
        List<int> ids;
        int currentID = -1;

        public SetupsViewHome()
        {
            InitializeComponent();
            setupDetails = databaseHelper.GetSetupsData();
            LoadListViewData();
            comparer = new ItemComparer();
            listView1.ListViewItemSorter = comparer;
        }

        private void LoadListViewData()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;

            string[] idArry = setupDetails.Select(x => x.id.ToString()).ToArray();
            string[] arry1 = setupDetails.Select(x => x.GWRaidDetails.difficulty).ToArray();
            string[] arry2 = setupDetails.Select(x => x.GWRaidDetails.time).ToArray();
            string[] arry3 = setupDetails.Select(x => x.GWRaidDetails.element).ToArray();
            string[] arry4 = setupDetails.Select(x => x.GWRaidDetails.revive).ToArray();
            string[] arry5 = setupDetails.Select(x => x.GWRaidDetails.type).ToArray();
            string[] arry6 = setupDetails.Select(x => x.GWRaidDetails.desc).ToArray();
            List<ListViewItem> name = new List<ListViewItem>();
            for (int i = 0; i < arry1.Length; i++)
            {
                ListViewItem item = new ListViewItem(arry1[i], i);
                item.SubItems.Add(arry2[i]);
                item.SubItems.Add(arry3[i]);
                item.SubItems.Add(arry5[i]);
                item.SubItems.Add(arry4[i]);
                item.SubItems.Add(arry6[i]);
                item.SubItems.Add(idArry[i]);
                Debug.WriteLine($"Time is {arry2[i]}");
                name.Add(item);
            }
            listView1.Columns.Add("Difficulty", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Time", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Element", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Type", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Revived", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Description", -2, HorizontalAlignment.Center);
            listView1.Items.AddRange(name.ToArray());

        }

        private void SetupsViewHome_Load(object sender, EventArgs e)
        {

        }

        private void SortListView(object sender, ColumnClickEventArgs e)
        {
            Debug.WriteLine($"{e.Column} clicked");
            int columnIndex = e.Column;
            if (e.Column == comparer.SortColumn)
            {
                Debug.WriteLine("New column");
                if (comparer.SortColumn == columnIndex)
                {

                }
                // Reverse the current sort direction for this column.
                if (comparer.Order == SortOrder.Ascending)
                {
                    comparer.Order = SortOrder.Descending;
                }
                else
                {
                    comparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                Debug.WriteLine("New column");
                comparer.SortColumn = e.Column;
                comparer.Order = SortOrder.Ascending;
            }
            ListView parent = (ListView)sender;
            parent.Sort();
        }

        private void CreateForm(object sender, EventArgs e)
        {
            SetupsBuilder builder = new SetupsBuilder(); 
            builder.ShowDialog();   
        }

        private void LoadRaidDetails(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            dataTable.Controls.Clear();
            int index = e.ItemIndex;
            ListView parent = (ListView)sender;
            string str = parent.Items[index].SubItems[6].Text;
            int id = int.Parse(str);
            Debug.WriteLine($"ID is {id}");
            if (currentID != id)
            {
                int setupIndex = id;
                currentID = id;
            }
        }

        private void DisplaySetupData()
        {
            List<string> party = databaseHelper.TableStrData("PartyCharacter", currentID);
            List<string> weapon = databaseHelper.TableStrData("PartyWeaponGrid", currentID);
            List<string> summons = databaseHelper.TableStrData("PartySummons", currentID);
            List<string> details = databaseHelper.TableStrData("SetupDetails", currentID);
            Debug.WriteLine(details.Count);
            string difficulty = details[0];
            string time = details[1];
            string element = details[3];
            string revive = details[4];
            string reviveCount = details[5];
            string type = details[6];
            string desc = details[7];
            int con = Int32.Parse(reviveCount);
            foreach (string s in details) { Debug.WriteLine($"{s}"); }
            GWBattleDetails gWBattle = new(difficulty, time, element, revive, con, type, desc);
            SetupSpecs setup = new(currentID, party, weapon, summons, gWBattle);
            SetupDetails data = new(setup);
            dataTable.Controls.Add(data);

        }

        private void LoadSetupData(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;
            Debug.WriteLine($"{list} item activated, {e.ToString()}");
            DisplaySetupData();
        }
    }
}
