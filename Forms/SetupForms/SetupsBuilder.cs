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
using static GBF_Never_Buddy.Classes.GameDataClasses;
using NeverGuildWar_Buddy.Classes;
using static GBF_Never_Buddy.Classes.GameDataClasses.Weapon;
using NeverGuildWar_Buddy.Classes.SQLite;

namespace NeverGuildWar_Buddy.Forms.SetupForms
{
    public partial class SetupsBuilder : Form
    {
        SetupsHelper setupsHelper = new();
        SetupSQLiteHelper setupSQLHelper = new();
        public List<Tuple<int, Character>> partySetup = new();
        bool revive = false;
        public SetupsBuilder()
        {
            InitializeComponent();
        }

        private void LoadItemSelector(object sender, EventArgs e)
        {
            string title = $"Add ";
            PictureBox picture = (PictureBox)sender;
            Debug.WriteLine(picture.Tag);
            if ((string)picture.Tag == "char")
            {
                SelectorForm selector = new(0, picture, setupsHelper);
                selector.Text = title + (string)picture.Tag;
                selector.ShowDialog();
            }
            if ((string)picture.Tag == "summon")
            {
                SelectorForm selector = new(1, picture, setupsHelper);
                selector.Text = title + (string)picture.Tag;
                selector.ShowDialog();
            }
            if ((string)picture.Tag == "weap")
            {
                SelectorForm selector = new(2, picture, setupsHelper);
                selector.Text = title + (string)picture.Tag;
                selector.ShowDialog();
            }

        }

        private void LoadJobSelector(object sender, EventArgs e)
        {
            ClassSelector selector = new(setupsHelper, sender);
            selector.ShowDialog();
        }

        private void AddPartyToDB(object sender, EventArgs e)
        {
            int count = setupSQLHelper.SetupsCount();
            string time = "00:" + timeTB.Text;
            string difficulty = levelCB.Text;
            string element = elementCB.Text;
            string type = typeCB.Text;
            string revive = "N";
            string desc = descriptionTB.Text;
            if (descriptionTB.Text.Length < 1)
            {
                desc = "NA";
            }
            int times = 0;
            if (reviveYRB.Checked)
            {
                revive = "Y";
                decimal num = reviveCounter.Value;
                times = (int)num;
            }
            GWBattleDetails details = new(difficulty, time, element, revive, times, type, desc);
            Debug.WriteLine($"There are {count} setups in the db");
            if (difficulty != null && time != null)
            {
                setupsHelper.AddSetUpToDB(details);
                string message = "Party and Grid Setup saved.";
                string caption = "Data Added";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            levelCB.Text = "";
            timeTB.Text = "";
            partySetup.Clear();
            setupsHelper.currentParty.Clear();
            setupsHelper.currentSummonGrid.Clear();
            setupsHelper.currentWeapGrid.Clear();
            setupsHelper.currentJob = null;
            ClearControls();

        }

        private void ResetFormValues(object sender, EventArgs e)
        {
            levelCB.Text = "";
            timeTB.Text = "";
            partySetup.Clear();
            setupsHelper.currentParty.Clear();
            setupsHelper.currentSummonGrid.Clear();
            setupsHelper.currentWeapGrid.Clear();
            setupsHelper.currentJob = null;
            ClearControls();
        }

        private void UpdateReviveStatus(object sender, EventArgs e)
        {
            switch (reviveYRB.Checked)
            {
                case true:
                    Debug.WriteLine("Revive used");
                    revive = true;
                    reviveCounter.Enabled = true;
                    break;
                case false:
                    Debug.WriteLine("No Revive used");
                    revive = false;
                    reviveCounter.Enabled = false;
                    break;
            }
        }

        private void ClearControls()
        {
            Panel partyPanel = (Panel)mainPanel.Controls["partyPanel"];
            TableLayoutPanel frontline = (TableLayoutPanel)partyPanel.Controls["frontlineTP"];
            TableLayoutPanel backline = (TableLayoutPanel)partyPanel.Controls["backlineTP"];

            Panel gridPanel = (Panel)mainPanel.Controls["weaponPanel"];
            Panel mhWeapPanel = (Panel)gridPanel.Controls["mainHandPanel"];
            TableLayoutPanel weapGrid = (TableLayoutPanel)gridPanel.Controls["weaponGridTP"];

            Panel summonPanel = (Panel)mainPanel.Controls["summonPanel"];
            Panel mainSummon = (Panel)summonPanel.Controls["mainSummonPanel"];
            TableLayoutPanel summonGrid = (TableLayoutPanel)summonPanel.Controls["mainSummonTP"];
            TableLayoutPanel subSummonGrid = (TableLayoutPanel)summonPanel.Controls["mainSummonTP"];


            foreach (Control control in mhWeapPanel.Controls)
            {
                Debug.WriteLine($"Weapon Panel: {control.Name}");
                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Image = null;
                }
            }

            foreach (Control control in mainSummon.Controls)
            {
                Debug.WriteLine($"summon Panel: {control.Name}");
                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Image = null;
                }
            }

            foreach (Control control in frontline.Controls)
            {
                Debug.WriteLine(control.Name);
                foreach (Control c in control.Controls)
                {
                    Debug.WriteLine($"Inner: {c.GetType()}");
                    if (c is PictureBox)
                    {
                        PictureBox pictureBox = (PictureBox)c;
                        pictureBox.Image = null;
                    }
                }
            }
            foreach (Control control in backline.Controls)
            {
                Debug.WriteLine(control.Name);
                foreach (Control c in control.Controls)
                {
                    Debug.WriteLine($"Inner: {c.GetType()}");
                    if (c is PictureBox)
                    {
                        PictureBox pictureBox = (PictureBox)c;
                        pictureBox.Image = null;
                    }
                }
            }

            foreach (Control control in weapGrid.Controls)
            {
                Debug.WriteLine(control.Name);
                foreach (Control c in control.Controls)
                {
                    Debug.WriteLine($"Inner: {c.GetType()}");
                    if (c is PictureBox)
                    {
                        PictureBox pictureBox = (PictureBox)c;
                        pictureBox.Image = null;
                    }
                }
            }
            foreach (Control control in summonGrid.Controls)
            {
                Debug.WriteLine(control.Name);
                foreach (Control c in control.Controls)
                {
                    Debug.WriteLine($"Inner: {c.GetType()}");
                    if (c is PictureBox)
                    {
                        PictureBox pictureBox = (PictureBox)c;
                        pictureBox.Image = null;
                    }
                }
            }
            foreach (Control control in subSummonGrid.Controls)
            {
                Debug.WriteLine(control.Name);
                foreach (Control c in control.Controls)
                {
                    Debug.WriteLine($"Inner: {c.GetType()}");
                    if (c is PictureBox)
                    {
                        PictureBox pictureBox = (PictureBox)c;
                        pictureBox.Image = null;
                    }
                }
            }
        }

        private void CallCheck(object sender, EventArgs e)
        {
            Debug.WriteLine("PB clicked");
        }
    }
}
