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

namespace NeverGuildWar_Buddy.Classes
{
    public class SetupsHelper : SetupSQLiteHelper
    {
        public List<Character> characterDB = new List<Character>();
        public Character? currentChar = null;
        public List<Character> currentParty  = new();
        public List<Tuple<int, Weapon>> currentWeapGrid = new();
        public List<Tuple<int, Summon>> currentSummonGrid = new();
        public Job? currentJob = null;
        public List<SetupSpecs>? setups = null;
        public Summon? currentSum = null;
        public Weapon? currentWeap = null;

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
