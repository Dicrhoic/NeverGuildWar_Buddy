using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Never_Buddy.Classes
{
    public class GameDataClasses
    {
        public class Character
        {
            public string name;
            public string series;
            public string element;
            public string image;
            public string link;

            public Character(string name, string element, string series, string image, string link)
            {
                this.name = name;
                this.element = element;
                this.series = series;
                this.image = image;
                this.link = link;
            }
        }

        public class Summon
        {
            public string name;
            public string series;
            public string element;
            public string image;
            public string link;

            public Summon(string name, string series, string element, string image, string link)
            {
                this.name = name;
                this.series = series;
                this.element = element;
                this.image = image;
                this.link = link;
            }
        }

        public class Weapon
        {
            public string name;
            public string element;
            public string link;
            public string imageLink;

            public Weapon(string name, string element, string link, string imageLink)
            {
                this.name = name;
                this.element = element;
                this.link = link;
                this.imageLink = imageLink;
            }

            public class Job
            {
                public string jobName;
                public string jobImage;

                public Job(string jobName, string jobImage)
                {
                    this.jobName = jobName;
                    this.jobImage = jobImage;
                }
            }

      
            public class GWBattleDetails
            {
                public string difficulty;
                public string time;
                public string element;
                public string revive;
                public string type;
                public int reviveTimes;
                public string desc;
                public TimeSpan timeConv;

                public GWBattleDetails(string difficulty, string time, string element, string revive, int reviveTimes, string type, string desc)
                {
                    this.difficulty = difficulty;
                    this.time = time;
                    this.element = element;
                    this.revive = revive;
                    this.reviveTimes = reviveTimes;
                    this.type = type;
                    this.desc = desc;
                    ConvertedTime();
                }

                private TimeSpan ConvertedTime()
                {   
                    TimeSpan conTime;
                    conTime = TimeSpan.Parse(this.time);
                    //var output = $"{(int)time.TotalMinutes}:{time.Seconds:00}";
                    //conTime = output.ToString();
                    return conTime;

                }
                public string Query(int id)
                {
                    string query = $"INSERT INTO [SetupDetails] ([Id], [Difficulty], [Time], [RaidID], [Element], [Revive]," +
                        $" [ReviveTimes], [Type]) VALUES ({id},'{difficulty}','{time}','{id}','{element}','{revive}','{reviveTimes}','{type}')";
                    return query;

                }
                public string QueryDes(int id)
                {
                    string query = $"INSERT INTO [SetupDetails] ([Id], [Difficulty], [Time], [RaidID], [Element], [Revive]," +
                        $" [ReviveTimes], [Type]) VALUES ({id},'{difficulty}','{time}','{id}','{element}','{revive}','{reviveTimes}','{type}')";
                    return query;

                }
            }

            public class SetupSpecs
            {
                public int id;
                public List<string> Party;
                public List<string> Weapons;
                public List<string> Summons;
                public GWBattleDetails GWRaidDetails;

                public SetupSpecs(int id, List<string> party, List<string> weapons, List<string> summons, GWBattleDetails gWRaidDetails)
                {
                    this.id = id;
                    Party = party;
                    Weapons = weapons;
                    Summons = summons;
                    GWRaidDetails = gWRaidDetails;
                }
            }
          

            public class GWResult
            {
                public int id;
                public string GWType;
                public string day;
                public string result;
                public string mvp;
                public decimal crewHonours;
                public decimal danchoHonours;
                public decimal stromHonours;
                public decimal angHonours;

                public GWResult(int id, string gWType, string day, string result, string mvp, decimal crewHonours, decimal danchoHonours, decimal stromHonours, decimal angHonours)
                {
                    this.id = id;
                    GWType = gWType;
                    this.day = day;
                    this.result = result;
                    this.mvp = mvp;
                    this.crewHonours = crewHonours;
                    this.danchoHonours = danchoHonours;
                    this.stromHonours = stromHonours;
                    this.angHonours = angHonours;
                }
            }

            public class ItemComparer : IComparer
            {
                public int Column { get; set; }

                public SortOrder Order { get; set; }
                private CaseInsensitiveComparer ObjectCompare;

                public ItemComparer()
                {
                    Order = SortOrder.None;
                    ObjectCompare = new CaseInsensitiveComparer();
                }
                public int Compare(object x, object y)
                {
                    int result;
                    ListViewItem listviewX, listviewY;

                    listviewX = (ListViewItem)x;
                    listviewY = (ListViewItem)y;
                    result = ObjectCompare.Compare(listviewX.SubItems[Column].Text, listviewY.SubItems[Column].Text);
                    var xStr = listviewX.SubItems[Column].Text;
                    var yStr = listviewY.SubItems[Column].Text;
                    int xValue = 0;
                    int yValue = 0;
                    TimeSpan xTime;
                    TimeSpan yTime;
                    TimeSpan.TryParse(xStr, out xTime);
                    TimeSpan.TryParse(yStr, out yTime);
                    if (xTime != TimeSpan.Zero && yTime != TimeSpan.Zero)
                    {
                        result = xTime.CompareTo(yTime);
                    }
                    int.TryParse(xStr, System.Globalization.NumberStyles.Currency, null, out xValue);
                    int.TryParse(yStr, System.Globalization.NumberStyles.Currency, null, out yValue);
                    if (yValue != 0 && xValue != 0)
                    {
                        Debug.WriteLine($"Number, comparing: {xValue} to {yValue}");
                        result = xValue - yValue;
                    }

                    if (Order == SortOrder.Descending)
                    {
                        return (-result);
                    }
                    else if (Order == SortOrder.Ascending)
                    {
                        return result;
                    }
                    return 0;
                }
                public int SortColumn
                {
                    set
                    {
                        Column = value;
                    }
                    get
                    {
                        return Column;
                    }
                }

                public SortOrder OrderCol
                {
                    set
                    {
                        Order = value;
                    }
                    get
                    {
                        return Order;
                    }
                }
            }
        }
    }
}
