using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GBF_Never_Buddy.Classes.GameDataClasses.Weapon;
using static GBF_Never_Buddy.Classes.GameDataClasses;
using System.Diagnostics;
using NeverGuildWar_Buddy.Classes.SQLite;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.CodeDom;

namespace NeverGuildWar_Buddy.Classes
{
    public class SetupsHelper : SetupSQLiteHelper
    {
        public List<Character> characterDB = new List<Character>();
        public Character? currentChar = null;
        public List<Character> currentParty  = new();
        public List<Tuple<int, Character>> partySetup = new();
        public List<Tuple<int, Weapon>> currentWeapGrid = new();
        public List<Tuple<int, Summon>> currentSummonGrid = new();
        public Job? currentJob = null;
        public List<SetupSpecs>? setups = null;
        public Summon? currentSum = null;
        public Weapon? currentWeap = null;
        SqliteConnection connection = new SqliteConnection(
               GetConnectionString());

        public void AddDataToDB(GWBattleDetails details)
        {
            MBHelper mB = new MBHelper();
            string level = details.difficulty;
            string clearTime = $"{details.time}";
            int id = SetupsCount() + 1;
            int partyCount = 1;
            int weapCount = 1;
            int summonCount = 1;
            if (currentJob != null
               && currentParty != null && currentSummonGrid != null)
            {
                int index = 1;
                string characterList = "";
                foreach (var character in currentParty)
                {
                    characterList += $"{index}. {character.name}\n";
                    index++;
                    partyCount++;
                }
                index = 1;
                string summons = "";
                foreach (var summon in currentSummonGrid)
                {
                    summons += $"{index}. {summon.Item2.name}\n";
                    index++;
                    summonCount = index;
                }
                index = 1;
                string job = currentJob.jobName;
                string mainHand = $"Mainhand: ";
                string weapons = $"";
                foreach (var wep in currentWeapGrid)
                {
                    if (wep.Item1 == 1)
                    {
                        mainHand += wep.Item2.name;
                    }
                    else
                    {
                        weapons += $"{wep.Item2.name}\n";
                    }
                    index++;
                }
                weapCount = index;
                string message = $"Current party setup is:\nDifficulty:{level}\nTime Cleared:{clearTime}\n" +
                    $"\n Job: {job}\n" +
                    $"Party: {characterList}\n" + $"Grid: {weapons}" + $"Summons: {summons}";
                const string caption = "Saving Party";

                var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                if (result == DialogResult.Yes)
                {
                    string partyQ = PartyQuery(partyCount);                   
                    string weaponQ = GridQuery(weapCount);
                    string summonQ = SummonQuery(summonCount);
                    string setupQ = details.InsertQuery(id);

                    

                }
            }
        }

        private SqliteCommand PartySqCommand(string query, int count, int id)
        {   
            SqliteCommand sqliteCommand = new SqliteCommand(query, connection);
            switch (count)
            {
                case 1:
                    sqliteCommand.Parameters.AddWithValue("@id", id);
                    sqliteCommand.Parameters.AddWithValue("@class", currentJob);
                    break;
                case 2:
                    sqliteCommand.Parameters.AddWithValue("@id", id);
                    sqliteCommand.Parameters.AddWithValue("@class", currentJob);
                    sqliteCommand.Parameters.AddWithValue("@char1", partySetup[0]);;
                    break;
                case 3:
                    sqliteCommand.Parameters.AddWithValue("@id", id);
                    sqliteCommand.Parameters.AddWithValue("@class", currentJob);
                    sqliteCommand.Parameters.AddWithValue("@char1", partySetup[0]);
                    sqliteCommand.Parameters.AddWithValue("@char2", partySetup[1]);
                    break;
                case 4:
                    sqliteCommand.Parameters.AddWithValue("@id", id);
                    sqliteCommand.Parameters.AddWithValue("@class", currentJob);
                    sqliteCommand.Parameters.AddWithValue("@char1", partySetup[0]);
                    sqliteCommand.Parameters.AddWithValue("@char2", partySetup[1]);
                    sqliteCommand.Parameters.AddWithValue("@char3", partySetup[3]); 
                    break;
                case 5:
                    sqliteCommand.Parameters.AddWithValue("@id", id);
                    sqliteCommand.Parameters.AddWithValue("@class", currentJob);
                    sqliteCommand.Parameters.AddWithValue("@char1", partySetup[0]);
                    sqliteCommand.Parameters.AddWithValue("@char2", partySetup[1]);
                    sqliteCommand.Parameters.AddWithValue("@char3", partySetup[3]);
                    sqliteCommand.Parameters.AddWithValue("@char4", partySetup[4]);
                    break;
                case 6:
                    sqliteCommand.Parameters.AddWithValue("@id", id);
                    sqliteCommand.Parameters.AddWithValue("@class", currentJob);
                    sqliteCommand.Parameters.AddWithValue("@char1", partySetup[0]);
                    sqliteCommand.Parameters.AddWithValue("@char2", partySetup[1]);
                    sqliteCommand.Parameters.AddWithValue("@char3", partySetup[3]);
                    sqliteCommand.Parameters.AddWithValue("@char4", partySetup[4]);
                    sqliteCommand.Parameters.AddWithValue("@char5", partySetup[5]);
                    break;
                
            }
            return sqliteCommand;
        }






        public void AddSetUpToDB(GWBattleDetails details)
        {
            string level = details.difficulty;
            string clearTime = $"{details.time}";
            int id = SetupsCount() + 1;
            if (currentJob != null
                && currentSummonGrid != null && currentSummonGrid != null)
            {   
                int index = 1;
                string characterList = "";
                if (currentParty != null)
                {
                    foreach (var character in currentParty)
                    {
                        characterList += $"{index}. {character.name}\n";
                        index++;
                    }
                }
                index = 1;
                string summons = "";
                foreach (var summon in currentSummonGrid)
                {
                    summons += $"{index}. {summon.Item2.name}\n";
                    index++;
                }
                string job = currentJob.jobName;
                string mainHand = $"Mainhand: ";
                string weapons = $"";
                foreach (var wep in currentWeapGrid)
                {
                    if (wep.Item1 == 1)
                    {
                        mainHand += wep.Item2.name;
                    }
                    else
                    {
                        weapons += $"{wep.Item2.name}\n";
                    }
                }
                string message = $"Current party setup is:\nDifficulty:{level}\nTime Cleared:{clearTime}\n" +
                    $"\n Job: {job}\n" +
                    $"Party: {characterList}\n" + $"Grid: {weapons}" + $"Summons: {summons}";
                const string caption = "Saving Party";

                var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                if (result == DialogResult.Yes)
                {
                    string partyQ = PartyStringData(id);
                    string weaponQ = GridStringData(id);
                    string summonQ = SummonsStringData(id);
                    Debug.WriteLine($"Queries are,\n Party: {partyQ}" +
                        $"\nWeapon: {weaponQ}\nSummons: {summonQ}");
                    string query = details.Query(id);
                    RunSQLQuery(partyQ);
                    RunSQLQuery(weaponQ);
                    RunSQLQuery(summonQ);
                    RunSQLQuery(query);
                    if (currentParty != null)
                    {
                        currentParty.Clear();
                    }
                    currentSummonGrid.Clear();
                    currentWeapGrid.Clear();
                    currentJob = null;
                }

            }

        }


        private string PartyQuery()
        {
            string query = "INSERT INTO [PartyCharacter] ([Id], [Class]) VALUES" +
                " (@id, @class)";
            return query;
        }

        private string Party2Query()
        {
            string query = "INSERT INTO [PartyCharacter] ([Id], [Class], [Character1]) VALUES" +
                " (@id, @class, @char1)";
            return query;
        }

        private string Party3Query()
        {
            string query = "INSERT INTO [PartyCharacter] ([Id], [Class], [Character1], [Character2]) VALUES" +
                " (@id, @class, @char1, @char2)";
            return query;
        }

        private string Party4Query()
        {
            string query = "INSERT INTO [PartyCharacter] ([Id], [Class], [Character1], [Character2], [Character3]) VALUES" +
                " (@id, @class, @char1, @char2, @char3)";
            return query;
        }

        private string Party5Query()
        {
            string query = "INSERT INTO [PartyCharacter] ([Id], [Class], [Character1], [Character2], [Character3], [Character4])" +
                " VALUES (@id, @class, @char1, @char2, @char3, @char4)";
            return query;
        }

        private string FullPartyQuery()
        {
            string query = "INSERT INTO [PartyCharacter] ([Id], [Class], [Character1], [Character2], [Character3], [Character4], [Character5])" +
                " VALUES (@id, @class, @char1, @char2, @char3, @char4, @char5)";
            return query;
        }

        private string PartyQuery(int id)
        {
            string query = "";
            switch(id)
            {
                case 1:
                    query = PartyQuery(); 
                    break;
                case 2:
                    query = Party2Query();
                    break;
                case 3:
                    query = Party3Query();
                    break;
                case 4:
                    query = Party4Query();
                    break;
                case 5:
                    query = Party5Query();
                    break;
                case 6:
                    query = FullPartyQuery();
                    break;

            }
            return query;   
        }

        private string GridMH()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon]) VALUES" +
              " (@id, @mhw)";
            return query;
        }

        private string Weap1Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1]) VALUES" +
              " (@id, @mhw, @w1)";
            return query;
        }

        private string Weap2Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1], [Weapon2]) VALUES" +
              " (@id, @mhw, @w1, @w2)";
            return query;
        }

        private string Weap3Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1], [Weapon2], [Weapon3]) VALUES" +
              " (@id, @mhw, @w1, @w2, @w3)";
            return query;
        }

        private string Weap4Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1], [Weapon2], [Weapon3], [Weapon4]) VALUES" +
              " (@id, @mhw, @w1, @w2, @w3, @w4)";
            return query;
        }

        private string Weap5Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1], [Weapon2], " +
                "[Weapon3], [Weapon4], [Weapon5]) VALUES" +
              " (@id, @mhw, @w1, @w2, @w3, @w4, @w5)";
            return query;
        }

        private string Weap6Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1], [Weapon2], " +
                "[Weapon3], [Weapon4], [Weapon5], [Weapon6]) VALUES" +
              " (@id, @mhw, @w1, @w2, @w3, @w4, @w5, @w6)";
            return query;
        }

        private string Weap7Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1], [Weapon2], " +
                "[Weapon3], [Weapon4], [Weapon5], [Weapon6], [Weapon7]) VALUES" +
              " (@id, @mhw, @w1, @w2, @w3, @w4, @w5, @w6, @w7)";
            return query;
        }

        private string Weap8Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1], [Weapon2], " +
                "[Weapon3], [Weapon4], [Weapon5], [Weapon6], [Weapon7], [Weapon8]) VALUES" +
              " (@id, @mhw, @w1, @w2, @w3, @w4, @w5, @w6, @w7, @w8)";
            return query;
        }

        private string Weap9Grid()
        {
            string query = "INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon], [Weapon1], [Weapon2], " +
                "[Weapon3], [Weapon4], [Weapon5], [Weapon6], [Weapon7], [Weapon8], [Weapon9]) VALUES" +
              " (@id, @mhw, @w1, @w2, @w3, @w4, @w5, @w6, @w7, @w8, @w9)";
            return query;
        }

        private string GridQuery(int id)
        {
            string query = "";
            switch (id) 
            {
                case 1:
                    query = GridMH();
                    break;
                case 2:
                    query = Weap1Grid();
                    break;
                case 3:
                    query = Weap2Grid();
                    break;
                case 4:
                    query = Weap3Grid();
                    break; 
                case 5:
                    query = Weap4Grid();
                    break;
                case 6:
                    query = Weap5Grid();
                    break;
                case 7:
                    query = Weap6Grid();
                    break;
                case 8:     
                    query = Weap7Grid();
                    break;
                case 9:
                     query = Weap8Grid();
                    break;
                case 10:           
                    query = Weap9Grid();
                    break;
            }
            return query;
        }

        private string SummonGrid()
        {
            string query = "INSERT INTO [PartySummons] ([Id], [MainSummon] ) VALUES" +
              " (@id, @ms, @s1)";
            return query;
        }

        private string Summon1Grid()
        {
            string query = "INSERT INTO [PartySummons] ([Id], [MainSummon], [Summon1]) VALUES" +
              " (@id, @ms, @s1)";
            return query;
        }

        private string Summon2Grid()
        {
            string query = "INSERT INTO [PartySummons] ([Id], [MainSummon], [Summon1], [Summon2]) VALUES" +
              " (@id, @ms, @s1, @s2)";
            return query;
        }

        private string Summon3Grid()
        {
            string query = "INSERT INTO [PartySummons] ([Id], [MainSummon], [Summon1], [Summon2], " +
                "[Summon3]) VALUES" +
              " (@id, @ms, @s1, @s2, @s3)";
            return query;
        }

        private string Summon4Grid()
        {
            string query = "INSERT INTO [PartySummons] ([Id], [MainSummon], [Summon1], [Summon2], " +
                "[Summon3], [Summon4]) VALUES" +
              " (@id, @ms, @s1, @s2, @s3, @s4)";
            return query;
        }

        private string Summon5Grid()
        {
            string query = "INSERT INTO [PartySummons] ([Id], [MainSummon], [Summon1], [Summon2], " +
                    "[Summon3], [Summon4], [SubSummon1]) VALUES" +
                  " (@id, @ms, @s1, @s2, @s3, @s4, @s5)";
            return query;
            
        }

        private string FullSummonGrid()
        {
            string query = "INSERT INTO [PartySummons] ([Id], [MainSummon], [Summon1], [Summon2], " +
                "[Summon3], [Summon4], [SubSummon1], [SubSummon2]) VALUES" +
              " (@id, @ms, @s1, @s2, @s3, @s4, @s5, @s6)";
            return query;
        }

        private string SummonQuery(int id)
        {
            string query = "";
            switch (id)
            {
                case 1:
                    query = Summon1Grid();
                    break;
                case 2:
                    query = Summon2Grid();
                    break;
                case 3:
                    query = Summon3Grid();
                    break; 
                case 4:
                    query = Summon4Grid();
                    break;
                case 5:
                    query = Summon5Grid();
                    break;
                case 6:
                    query = FullSummonGrid();
                    break;
            }
            return query;
        }

        private string PartyStringData(int id)
        {   
            if(currentJob != null)
            {
                string header = $"INSERT INTO [PartyCharacter] ([Id],";
                int count = currentParty.Count;
                string classValue = currentJob.jobName;
                string partyValue = "";
                string partyQuery = "";
                switch (count)
                {
                    case 0:
                        partyQuery = " [Class]) VALUES";
                        partyValue = $" ({id},'{classValue}')";
                        break;
                    case 2:
                        partyQuery = " [Class], [Character1], [Character2]) VALUES";
                        partyValue = $" ({id},'{classValue}','{FormatSqlString(currentParty[0].name)}', '{FormatSqlString(currentParty[1].name)}')";
                        break;
                    case 3:
                        partyQuery = " [Character1], [Character2], [Character3]) VALUES";
                        partyValue = $" ({id},'{classValue}','{FormatSqlString(currentParty[0].name)}', '{FormatSqlString(currentParty[1].name)}', '{FormatSqlString(currentParty[2].name)}')";
                        break;
                    case 4:
                        partyQuery = " [Class], [Character1], [Character2], [Character3]," +
                           " [SubCharacter1]) VALUES";
                        partyValue = $" ({id},'{classValue}','{FormatSqlString(currentParty[0].name)}', '{FormatSqlString(currentParty[1].name)}', '{FormatSqlString(currentParty[2].name)}'" +
                            $",'{FormatSqlString(currentParty[3].name)}')";
                        break;
                    case 5:
                        partyQuery = " [Class], [Character1], [Character2], [Character3]," +
                            " [SubCharacter1], [SubCharacter2]) VALUES";
                        partyValue = $" ({id}, '{classValue}', '{FormatSqlString(currentParty[0].name)}', '{FormatSqlString(currentParty[1].name)}', '{FormatSqlString(currentParty[2].name)}'" +
                            $",'{FormatSqlString(currentParty[3].name)}', '{FormatSqlString(currentParty[4].name)}')";
                        break;
                }
                string query = header + partyQuery + partyValue;
                return query;
            }
            return "Error job is null";
        }

        private string GridStringData(int id)
        {
            string header = $"INSERT INTO [PartyWeaponGrid] ([Id], [MHWeapon]";
            int count = currentWeapGrid.Count;
            string gridValue = "";
            string gridQuery = "";
            string mainHand = FormatSqlString(currentWeapGrid[0].Item2.name);
            Debug.WriteLine(mainHand);
            switch (count)
            {
                case 1:
                    gridQuery = ") VALUES";
                    gridValue = $" ({id},'{mainHand}')";
                    break;
                case 2:
                    gridQuery = " [Weapon1], [Weapon2]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)}" +
                        $",'{FormatSqlString(FormatSqlString(currentWeapGrid[2].Item2.name))})'";
                    break;
                case 3:
                    gridQuery = " [Weapon1], [Weapon2], [Weapon3]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)} '" +
                        $",'{FormatSqlString(currentWeapGrid[2].Item2.name)},'{FormatSqlString(currentWeapGrid[3].Item2.name)})";
                    break;
                case 4:
                    gridQuery = " [Weapon1], [Weapon2], [Weapon3], [Weapon4]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)} '" +
                        $",'{FormatSqlString(currentWeapGrid[2].Item2.name)},'{FormatSqlString(currentWeapGrid[3].Item2.name)}" +
                        $",'{FormatSqlString(currentWeapGrid[4].Item2.name)})";
                    break;
                case 5:
                    gridQuery = " [Weapon1], [Weapon2], [Weapon3], [Weapon4], " +
                        "[Weapon5]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)}'" +
                        $",'{FormatSqlString(currentWeapGrid[2].Item2.name)},'{FormatSqlString(currentWeapGrid[3].Item2.name)}" +
                        $",'{FormatSqlString(currentWeapGrid[4].Item2.name)},'{FormatSqlString(currentWeapGrid[5].Item2.name)})";
                    break;
                case 6:
                    gridQuery = " [Weapon1], [Weapon2], [Weapon3], [Weapon4], " +
                      "[Weapon5], [Weapon6]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)}'" +
                        $",'{FormatSqlString(currentWeapGrid[2].Item2.name)}','{FormatSqlString(currentWeapGrid[3].Item2.name)}'" +
                        $",'{FormatSqlString(currentWeapGrid[4].Item2.name)}','{FormatSqlString(currentWeapGrid[5].Item2.name)}'," +
                        $"'{FormatSqlString(currentWeapGrid[6].Item2.name)}')";
                    break;
                case 7:
                    gridQuery = " [Weapon1], [Weapon2], [Weapon3], [Weapon4], " +
                   "[Weapon5], [Weapon6], [Weapon7]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)}','{FormatSqlString(currentWeapGrid[2].Item2.name)}" +
                        $",'{FormatSqlString(currentWeapGrid[3].Item2.name)},'{FormatSqlString(currentWeapGrid[4].Item2.name)}" +
                        $",'{FormatSqlString(currentWeapGrid[5].Item2.name)},'{FormatSqlString(currentWeapGrid[6].Item2.name)}," +
                        $"'{FormatSqlString(currentWeapGrid[7].Item2.name)},'{FormatSqlString(currentWeapGrid[8].Item2.name)})";
                    break;
                case 8:
                    gridQuery = " [Weapon1], [Weapon2], [Weapon3], [Weapon4], " +
                    "[Weapon5], [Weapon6], [Weapon7], [Weapon8]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)}','{FormatSqlString(currentWeapGrid[2].Item2.name)}" +
                        $",'{FormatSqlString(currentWeapGrid[3].Item2.name)},'{FormatSqlString(currentWeapGrid[4].Item2.name)}" +
                        $",'{FormatSqlString(currentWeapGrid[5].Item2.name)},'{FormatSqlString(currentWeapGrid[6].Item2.name)}," +
                        $"'{FormatSqlString(currentWeapGrid[7].Item2.name)},'{FormatSqlString(currentWeapGrid[8].Item2.name)}" +
                        $",'{FormatSqlString(currentWeapGrid[9].Item2.name)})";
                    break;
                case 9:
                    gridQuery = " [Weapon1], [Weapon2], [Weapon3], [Weapon4], " +
                    "[Weapon5], [Weapon6], [Weapon7], [Weapon8], [Weapon9]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)}','{FormatSqlString(currentWeapGrid[2].Item2.name)}" +
                     $",'{FormatSqlString(currentWeapGrid[3].Item2.name)},'{FormatSqlString(currentWeapGrid[4].Item2.name)}" +
                     $",'{FormatSqlString(currentWeapGrid[5].Item2.name)},'{FormatSqlString(currentWeapGrid[6].Item2.name)}," +
                     $"'{FormatSqlString(currentWeapGrid[7].Item2.name)},'{FormatSqlString(currentWeapGrid[8].Item2.name)}" +
                     $",'{FormatSqlString(currentWeapGrid[9].Item2.name)})";
                    break;
                case 10:
                    gridQuery = ", [Weapon1], [Weapon2], [Weapon3], [Weapon4], " +
                   "[Weapon5], [Weapon6], [Weapon7], [Weapon8], [Weapon9]) VALUES";
                    gridValue = $" ({id},'{mainHand}','{FormatSqlString(currentWeapGrid[1].Item2.name)}'" +
                     $",'{FormatSqlString(currentWeapGrid[2].Item2.name)}','{FormatSqlString(currentWeapGrid[3].Item2.name)}'" +
                     $",'{FormatSqlString(currentWeapGrid[4].Item2.name)}','{FormatSqlString(currentWeapGrid[5].Item2.name)}'," +
                     $"'{FormatSqlString(currentWeapGrid[6].Item2.name)}','{FormatSqlString(currentWeapGrid[7].Item2.name)}'" +
                     $",'{FormatSqlString(currentWeapGrid[8].Item2.name)}','{FormatSqlString(currentWeapGrid[9].Item2.name)}')";
                    break;
            }
            string query = header + gridQuery + gridValue;
            return query;
        }

        private string SummonsStringData(int id)
        {
            string header = $"INSERT INTO [PartySummons] ([Id],";
            int count = currentSummonGrid.Count;
            string mainSummon = FormatSqlString(currentSummonGrid[0].Item2.name);
            string summonValue = "";
            string summonQuery = "";
            Debug.WriteLine($"Summons count {count}");
            switch (count)
            {
                case 1:
                    summonQuery = " [MainSummon]) VALUES";
                    summonValue = $" ({id},'{mainSummon}')";
                    break;
                case 2:
                    summonQuery = " [MainSummon], [Summon1], [Summon2]) VALUES";
                    summonValue = $" ({id},'{mainSummon}','{FormatSqlString(currentSummonGrid[1].Item2.name)}','{FormatSqlString(currentSummonGrid[2].Item2.name)}'";
                    break;
                case 3:
                    summonQuery = " [Summon1], [Summon2], [Summon3]) VALUES";
                    summonValue = $" ({id},'{mainSummon}','{FormatSqlString(currentSummonGrid[1].Item2.name)}','{FormatSqlString(currentSummonGrid[2].Item2.name)}','{FormatSqlString(currentSummonGrid[3].Item2.name)}'";
                    break;
                case 4:
                    summonQuery = " [MainSummon], [Summon1], [Summon2], [Summon3]," +
                       " [Summon4]) VALUES";
                    summonValue = $" ({id},'{mainSummon}','{FormatSqlString(currentSummonGrid[1].Item2.name)}','{FormatSqlString(currentSummonGrid[2].Item2.name)}','{FormatSqlString(currentSummonGrid[3].Item2.name)}'" +
                        $",'{FormatSqlString(currentSummonGrid[4].Item2.name)}')";
                    break;
                case 5:
                    summonQuery = " [MainSummon], [Summon1], [Summon2], [Summon3]," +
                        " [Summon4], [SubSummon1], [SubSummon2])) VALUES";
                    summonValue = $" ({id},'{mainSummon}','{FormatSqlString(currentSummonGrid[1].Item2.name)}','{FormatSqlString(currentSummonGrid[2].Item2.name)}','{FormatSqlString(currentSummonGrid[3].Item2.name)}'" +
                        $",'{FormatSqlString(currentSummonGrid[4].Item2.name)}','{FormatSqlString(currentSummonGrid[5].Item2.name)}')";
                    break;
                case 6:
                    summonQuery = " [MainSummon], [Summon1], [Summon2], [Summon3]," +
                        " [Summon4], [SubSummon1]) VALUES";
                    summonValue = $" ({id},'{mainSummon}','{FormatSqlString(currentSummonGrid[1].Item2.name)}','{FormatSqlString(currentSummonGrid[2].Item2.name)}','{FormatSqlString(currentSummonGrid[3].Item2.name)}'" +
                     $",'{FormatSqlString(currentSummonGrid[4].Item2.name)}','{FormatSqlString(currentSummonGrid[5].Item2.name)}','{FormatSqlString(currentSummonGrid[6].Item2.name)}')";
                    break;
                case 7:
                    summonQuery = " [MainSummon], [Summon1], [Summon2], [Summon3], [Summon4]," +
                        " [SubSummon1], [SubSummon2]) VALUES";
                    summonValue = $" ({id},'{mainSummon}','{FormatSqlString(currentSummonGrid[1].Item2.name)}','{FormatSqlString(currentSummonGrid[2].Item2.name)}','{FormatSqlString(currentSummonGrid[3].Item2.name)}'" +
                      $",'{FormatSqlString(currentSummonGrid[4].Item2.name)}','{FormatSqlString(currentSummonGrid[5].Item2.name)}','{FormatSqlString(currentSummonGrid[6].Item2.name)}')";
                    break;
            }
            string query = header + summonQuery + summonValue;
            return query;
        }

     

    }
}
