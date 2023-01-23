using NeverGuildWar_Buddy.Classes.SQLite;
using NeverGuildWar_Buddy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBF_Never_Buddy.Classes;
using NeverGuildWar_Buddy.Classes.SQlite;
using static GBF_Never_Buddy.Classes.GameDataClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;
using static GBF_Never_Buddy.Classes.GameDataClasses.Weapon;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace NeverGuildWar_Buddy.Forms.User_Controls
{
    public partial class SetupDetails : UserControl
    {
        GWBattleDetails Details;
        SetupsHelper setupsHelper = new();
        SetupSQLiteHelper setupSQLHelper = new();
        CharacterSQLiteHelper characterHelper = new();
        SummonSQLiteHelper summonHelper = new();
        WeaponSQLHelper weaponHelper = new();
        List<Character> characterList;
        List<Summon> summonsList;
        List<Weapon> weaponList;
        List<string> Weapons = new List<string>();
        List<string> Summons = new List<string>();
        List<string> Party = new List<string>();

        public SetupDetails(SetupSpecs details)
        {
            InitializeComponent();
            characterList = characterHelper.CharacterList();
            summonsList = summonHelper.AllSummonList();
            weaponList = weaponHelper.weaponList();
            Summons = details.Summons;
            Weapons = details.Weapons;
            Party = details.Party;
            Details = details.GWRaidDetails;
            idLabel.Text = $"Setup ID: {details.id}";
            levelLabel.Text = Details.difficulty;
            timeLabel.Text = Details.time;
            elementTag.Text = Details.element;
            reviveTag.Text = $"Revived: {Details.revive}";
            countTag.Text = $"Revived times: {Details.reviveTimes}";
            typeLabel.Text = $"Type: {Details.type}";
            descTag.Text = $"Desc: {Details.desc}";
            LoadWeapons();
            LoadCharacters();
            LoadSummons();
        }

        private void LoadCharacters()
        {
            Job job = setupsHelper.JobData(Party[0]);
            mcJobPB.Load(job.jobImage);
     
            int index = 0;
            int max = Party.Count;
            foreach (PictureBox picture in partyFlowPanel.Controls)
            {
                Character character;
                if(picture.Name.Contains("char") && index < max)
                {
                    Debug.WriteLine(Party[index]);
                    string name = setupsHelper.FormatSqlString(Party[index]);   
                    character = characterHelper.QueriedCharacter(name);
                    string link = character.link;
                    Debug.WriteLine($"Adding {name} to {picture.Name}");
                    picture.MouseClick += (s, e) => { ImageClickFunction(picture, link); };
                    picture.Load(character.image);
                }
                index++;
            }  
        }

        private void LoadWeapons()
        {
            int count = Weapons.Count();
            LoadMH();
            int max = Weapons.Count;
            if (count == 10)
            {
                int index = 1;
                foreach (PictureBox picture in weaponGrid.Controls)
                {

                    Weapon wep;
                    try
                    {
                        string weapName = setupSQLHelper.FormatSqlString(Weapons[index]);
                        wep = weaponHelper.Queriedweapon(weapName);
                        Debug.WriteLine(picture.Name);
                        string wepLink = wep.link.ToString();   
                        picture.MouseClick += (s, e) => { ImageClickFunction(picture, wepLink); };
                        picture.Load(wep.imageLink);
                    }
                    catch(Exception ex) { }

                    index++;
                }
            }
        }

        private void LoadSummons()
        {
            int count = Summons.Count();
            Summon sum; 
            string mainSummon = setupSQLHelper.FormatSqlString(Summons[0]); 
            sum = summonHelper.QueriedSummon(mainSummon);
            string mLink = sum.link.ToString();
            mainSummonPB.MouseClick += (s, e) => { ImageClickFunction(mainSummonPB, mLink); };
            mainSummonPB.Load(sum.image);
            int i = 1;
            foreach (PictureBox picture in summonGrid.Controls)
            {
              
                try
                {
                    string name = setupSQLHelper.FormatSqlString(Summons[i]);
                    sum = summonHelper.QueriedSummon(name);
                    string link = sum.link.ToString();
                    picture.MouseClick += (s, e) => { ImageClickFunction(picture, link); };
                    picture.Load(sum.image);
                }
                catch (Exception ex) { }
                i++;
            }
            Debug.WriteLine(count.ToString());  
            switch (count)
            {   
                case 6:
                    
                    string name = setupSQLHelper.FormatSqlString(Summons[5]);
                    sum = summonHelper.QueriedSummon(name);
                    string link = sum.link.ToString();
                    subSummonSlot1.MouseClick += (s, e) => { ImageClickFunction(subSummonSlot1, link); };
                    subSummonSlot1.Load(sum.image);
                    break;
                case 7:
                    name = setupSQLHelper.FormatSqlString(Summons[5]);
                    sum = summonHelper.QueriedSummon(name);
                    link = sum.link.ToString();
                    subSummonSlot1.MouseClick += (s, e) => { ImageClickFunction(subSummonSlot1, link); };
                    subSummonSlot1.Load(sum.image);
                    name = setupSQLHelper.FormatSqlString(Summons[6]);
                    sum = summonHelper.QueriedSummon(name);
                    link = sum.link.ToString();
                    subSummonSlot2.MouseClick += (s, e) => { ImageClickFunction(subSummonSlot2, link); };
                    subSummonSlot2.Load(sum.image);
                    break;

            }
        }

        private void LoadMH()
        {
            string weapName = setupSQLHelper.FormatSqlString(Weapons[0]);
            Weapon wep;
            wep = weaponHelper.Queriedweapon(weapName);
            Debug.WriteLine(mainHandPB.Name);
            string wepLink = wep.link.ToString();
            mainHandPB.MouseClick += (s, e) => { ImageClickFunction(mainHandPB, wepLink); };
            mainHandPB.Load(wep.imageLink);
        }

        private string FixURL(string url)
        {
            string newURL = url.Replace("//", "/");
            return newURL;
        }

        private void ImageClickFunction(PictureBox imageHolder, string name)
        {
            Debug.WriteLine("Click");
            string url = FixURL(name);
            System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            
        }
    }
}
