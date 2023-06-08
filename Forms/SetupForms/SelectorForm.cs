using GBF_Never_Buddy.Classes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NeverGuildWar_Buddy.Classes;
using NeverGuildWar_Buddy.Classes.SQlite;
using NeverGuildWar_Buddy.Classes.SQLite;
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

namespace NeverGuildWar_Buddy.Forms.SetupForms
{
    public partial class SelectorForm : Form
    {
        CharacterSQLiteHelper characterHelper = new();
        SummonSQLiteHelper summonHelper = new();
        WeaponSQLHelper weaponHelper = new();
        PictureBox pictureBox1;
        int settingMode = 0;
        int slotNum = 0;
        private List<Tuple<int, Character>> partySetup = new();
        List<GameDataClasses.Character>? characterList;
        List<GameDataClasses.Summon>? summonsList;
        List<GameDataClasses.Weapon>? weaponList;
        SetupsHelper helper;
        public SelectorForm(int mode, object sender, SetupsHelper setupsHelper)
        {   
            helper = setupsHelper;
            settingMode = mode;
            pictureBox1 = (PictureBox)sender;
            InitializeComponent();
            switch (mode)
            {
                case 0:
                    characterList = characterHelper.CharacterList();
                    break;
                case 1:
                    summonsList = summonHelper.AllSummonList();    
                    break; 
                case 2:
                    weaponList = weaponHelper.weaponList();
                    filterPanel.Visible = true;    
                    break;
            }
            string id = SlotName(mode, pictureBox1);
            LoadDataSource();
            
        }



        private void LoadDataSource()
        {   
            if (characterList != null)
            {
                if (characterList.Count > 0)
                {
                    searchTB.PlaceholderText = "Enter character name";
                    Debug.WriteLine($"Adding db {characterList.Count} contents");
                    var source = new AutoCompleteStringCollection();

                    source.AddRange(characterList.Select(d => d.name).ToArray());
                    searchTB.AutoCompleteCustomSource = source;
                    searchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                    searchTB.AutoCompleteSource = AutoCompleteSource.CustomSource;

                }
            }
            if(summonsList != null )
            {
                if (summonsList.Count > 0)
                {
                    searchTB.PlaceholderText = "Enter summon name";
                    Debug.WriteLine($"Adding db {summonsList.Count} contents");
                    var source = new AutoCompleteStringCollection();

                    source.AddRange(summonsList.Select(d => d.name).ToArray());
                    searchTB.AutoCompleteCustomSource = source;
                    searchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                    searchTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
            if(weaponList != null)
            {
                if (weaponList.Count > 0)
                {
                    searchTB.PlaceholderText = "Enter weapon name";
                    Debug.WriteLine($"Adding db {weaponList.Count} contents");
                    var source = new AutoCompleteStringCollection();

                    source.AddRange(weaponList.Select(d => d.name).ToArray());
                    searchTB.AutoCompleteCustomSource = source;
                    searchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                    searchTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }
        }

        private void SearchForDataItem(object sender, KeyEventArgs e)
        {   

            if (e.KeyCode == Keys.Enter && settingMode == 0)
            {
                GameDataClasses.Character character = characterHelper.QueriedCharacter(searchTB.Text);
                PictureBox pictureBox = ObtainedItem(character);
                resultsPanel.Controls.Clear();
                resultsPanel.Controls.Add(pictureBox);
                CheckSlot(character, slotNum);

            }
            if (e.KeyCode == Keys.Enter && settingMode == 1)
            {
                GameDataClasses.Summon summon = summonHelper.QueriedSummon(searchTB.Text);
                PictureBox pictureBox = ObtainedItem(summon);
                resultsPanel.Controls.Clear();
                resultsPanel.Controls.Add(pictureBox);
                CheckSlot(summon, slotNum);
            }
            if (e.KeyCode == Keys.Enter && settingMode == 2)
            {
                Weapon wep = weaponHelper.Queriedweapon(searchTB.Text);
                PictureBox pictureBox = ObtainedItem(wep);
                resultsPanel.Controls.Clear();
                resultsPanel.Controls.Add(pictureBox);
                CheckSlot(wep, slotNum);

            }
        }



        private PictureBox ObtainedItem(GameDataClasses.Character character)
        {

            PictureBox obtainedChar = new PictureBox();
            obtainedChar.Size = new Size(168, 99);
            obtainedChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            string image = character.image;
            string name = character.name;
            string link = character.link;
            //Debug.WriteLine(image);
            obtainedChar.Name = name;
            try
            {
                obtainedChar.Load(image);
            }
            catch (Exception ex)
            {
                MBHelper mB = new MBHelper();
                mB.ErrorMB("No internet connection", "Error loading image");
            }
            //obtainedChar.MouseClick += (s, e) => { ImageClickFunction(obtainedChar, link); };
            return obtainedChar;
        }

        private PictureBox ObtainedItem(GameDataClasses.Summon summon)
        {

            PictureBox obtainedChar = new PictureBox();
            obtainedChar.Size = new Size(168, 99);
            obtainedChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            string image = summon.image;
            string name = summon.name;
            string link = summon.link;
            //Debug.WriteLine(image);
            obtainedChar.Name = name;
            try
            {
                obtainedChar.Load(image);
            }
            catch (Exception ex)
            {
                MBHelper mB = new MBHelper();
                mB.ErrorMB("No internet connection", "Error loading image");
            }
            //obtainedChar.MouseClick += (s, e) => { ImageClickFunction(obtainedChar, link); };           
            return obtainedChar;
        }

        private PictureBox ObtainedItem(Weapon summon)
        {

            PictureBox obtainedChar = new PictureBox();
            obtainedChar.Size = new Size(168, 99);
            obtainedChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            string image = summon.imageLink;
            string name = summon.name;
            string link = summon.link;
            //Debug.WriteLine(image);
            obtainedChar.Name = name;
            try
            {
                obtainedChar.Load(image);
            }
            catch (Exception ex)
            {
                MBHelper mB = new MBHelper();
                mB.ErrorMB("No internet connection", "Error loading image");
            }
            //obtainedChar.MouseClick += (s, e) => { ImageClickFunction(obtainedChar, link); };
            return obtainedChar;
        }

        private void ImageClickFunction(PictureBox imageHolder, string link)
        {
            Debug.WriteLine("Click");
            string url = link;
            Form form = Application.OpenForms["SetupsBuilder"];
            if (form != null)
            {
              
            }
            if (form == null)
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        private string SlotName(int mode, PictureBox pictureBox)
        {
            string name = "";
            if(mode == 0)
            {
                switch (pictureBox.Name)
                {
                    case "character2Pic":
                        Debug.WriteLine("Second character slot");
                        slotNum = 2;
                        break;
                    case "character3Pic":
                        Debug.WriteLine("Third character slot");
                        slotNum = 3;
                        break;
                    case "character4Pic":
                        Debug.WriteLine("Fourth character slot");
                        slotNum = 4;
                        break;
                    case "character5Pic":
                        Debug.WriteLine("Fifth character slot");
                        slotNum = 5;
                        break;
                    case "character6Pic":
                        Debug.WriteLine("Sixth character slot");
                        slotNum = 6;
                        break;
                }
            }
            if (mode == 1) 
            {
                switch (pictureBox.Name)
                {
                    case "mainSummon":
                        name = "mainSummon";
                        slotNum = 0;
                        break;
                    case "summonPB1":
                        name = "mainSummon";
                        slotNum = 1;
                        break;
                    case "summonPB2":
                        name = "summonPB2";
                        slotNum = 2;
                        break;
                    case "summonPB3":
                        name = "summonPB3";
                        slotNum = 3;
                        break;
                    case "summonPB4":
                        name = "summonPB4";
                        slotNum = 4;
                        break;
                    case "subSummonPB1":
                        name = "subSummonPB1";
                        slotNum = 5;
                        break;
                    case "subSummonPB2":
                        name = "subSummonPB2";
                        slotNum = 6;
                        break;
                }
            }
            if (mode == 2)
            {
                switch (pictureBox.Name)
                {
                    case "mhWeaponSlot":
                        slotNum = 1;
                        break;
                    case "weaponSlot2":
                        slotNum = 2;
                        break;
                    case "weaponSlot3":
                        slotNum = 3;
                        break;
                    case "weaponSlot4":
                        slotNum = 4;
                        break;
                    case "weaponSlot5":
                        slotNum = 5;
                        break;
                    case "weaponSlot6":
                        slotNum = 6;
                        break;
                    case "weaponSlot7":
                        slotNum = 7;
                        break;
                    case "weaponSlot8":
                        slotNum = 8;
                        break;
                    case "weaponSlot9":
                        slotNum = 9;
                        break;
                    case "weaponSlot10":
                        slotNum = 10;
                        break;

                }
            }
            return name;
        }

        private void CheckSlot(Character character, int slotID)
        {   
            helper.currentChar = character;  
            if (helper.partySetup.Count > 0)
            {
                foreach (var tuple in partySetup.ToList())
                {
                    int slot = tuple.Item1;
                    string name = character.name;
                    if (slot == slotID)
                    {   
                        Debug.WriteLine($"Removing slot id {slot} matches with {slotID}");
                        partySetup.Remove(tuple);
                    }

                }
            }
            Tuple<int, Character> tuple1 = new Tuple<int, Character>(slotID, character);
            helper.partySetup.Add(tuple1);
            foreach(var tuple2 in helper.partySetup.ToList())
            {
                Debug.WriteLine(tuple2.Item2.name);
            }
            Debug.WriteLine($"Size {helper.partySetup.Count}");
            List<Character> characterList = helper.partySetup.Select(tuple => tuple.Item2).ToList();
            helper.currentParty = characterList;
          
        }

        private void CheckSlot(Summon summon, int slotID)
        {
            helper.currentSum = summon;
            if(helper.currentSummonGrid.Count > 0)
            {
                foreach (var tuple in helper.currentSummonGrid.ToList())
                {
                    if (tuple.Item1 == slotID)
                    {
                        helper.currentSummonGrid.Remove(tuple);
                    }
                }
            }
           
            Tuple<int, Summon> slot = new Tuple<int, Summon>(slotID, summon);
            helper.currentSummonGrid.Add(slot);

        }

        private void CheckSlot(Weapon weapon, int slotID) 
        {   
            helper.currentWeap = weapon;
            if(helper.currentWeapGrid.Count > 0)
            {
                foreach (var wep in helper.currentWeapGrid.ToList())
                {
                    if (wep.Item1 == slotID)
                    {
                        helper.currentWeapGrid.Remove(wep);
                    }
                }
            }
            Tuple<int, Weapon> slot = new Tuple<int, Weapon>(slotID, weapon);
            helper.currentWeapGrid.Add(slot);

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            switch(settingMode)
            {
                case 0:
                    pictureBox1.Load(helper.currentChar.image);
                    break;
                case 1:
                    pictureBox1.Load(helper.currentSum.image);
                    break;
                case 2:
                    pictureBox1.Load(helper.currentWeap.imageLink);
                    break;
            }
            this.Close();   

        }
    }
}
