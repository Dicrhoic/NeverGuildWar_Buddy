using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NeverGuildWar_Buddy.Classes
{
    public class RaidComparer
    {
        List<Tuple<string, RaidInfo>> RaidTuple;
        List<Tuple<string, NumericUpDown>> UsagePercentage;
        public RaidComparer() {
            RaidTuple = new();
            UsagePercentage = new List<Tuple<string, NumericUpDown>>();
        }

        public decimal HonourValues(decimal value, string raid)
        {
            var query = UsagePercentage.Where(x => x.Item1 == raid);
            if (query.Count() < 1)
            {
                return -1;
            }
            Debug.WriteLine($"Decimal Ratio: {query.First().Item2.Value}");
            decimal ratio = Decimal.Divide(query.First().Item2.Value, 100);
            Debug.WriteLine($"Decimal Ratio: {ratio}");
            decimal percentage = value * ratio;
            return percentage;
        }

        public void ValidateRaid(string name, RaidInfo raid)
        {
            var query = RaidTuple.Where(x => x.Item1 == name);
            if (query.Count() > 0)
            { 
                return; 
            }
            Tuple<string, RaidInfo> tuple = new Tuple<string, RaidInfo>(name, raid);        
            RaidTuple.Add(tuple);
            Debug.WriteLine($"Adding tuple for {name}");
      
        }

        public void AddNumeric(string name, NumericUpDown numeric)
        {          
            var tuple = UsagePercentage.Where(x => x.Item1 == name);
            if(tuple.Count() > 0)
            {   
                var item = tuple.First();   
                UsagePercentage.Remove(item);
            }
            UsagePercentage.Add(Tuple.Create(name, numeric));

        }

        public void BalanceNumerics(NumericUpDown numeric)
        {   
            decimal value = numeric.Value;  
            decimal max = UsagePercentage.Select(x => x.Item2.Value).Sum();
            Debug.WriteLine($"Sum of {UsagePercentage.Count} values : {max}");   
            if(max >= 100)
            {
                decimal exceed = max - 100;
                decimal deincrement = exceed / (UsagePercentage.Count()-1);
                foreach(var item in UsagePercentage)
                {
                    if(item.Item2.Value != value)
                    {
                        Debug.WriteLine(item.Item2.Value); 
                        decimal percentage = Decimal.Divide(item.Item2.Value, 100);                               
                        Debug.WriteLine($"% = {percentage}");
                        decimal d  = (100 ) * percentage;
                        item.Item2.Value = d;   
                    }
              
                }
            }
          
        }

        public void RemoveRaid(string name)
        {
            var query = RaidTuple.Where(x => x.Item1 == name);        
            if(query.Count() > 0)
            {
                Tuple<string, RaidInfo> raid = query.First();
                RaidTuple.Remove(raid);
                Debug.WriteLine($"Removed {raid}");
            }      
                     
        }

        public void PrintList()
        {
            Debug.WriteLine(RaidTuple.Count);
            foreach(var item in RaidTuple)
            {
                Debug.WriteLine($"Raid: {item.Item1}");
            }
        }

        public decimal AvgClearTime(string name)
        {
            var query = RaidTuple.Where(x => x.Item1 == name);
            if( query.Count() > 0 )
            {
                Tuple<string, RaidInfo> raid = query.First();
                return raid.Item2.avgTime;
            }
            return -1;
        }

        public void UpdateEffScore(string name, decimal time)
        {
            var query = RaidTuple.Where(x => x.Item1 == name);
           
            if (query.Count() > 0)
            {
                Tuple<string, RaidInfo> raid = query.First();
                decimal timeScore = Decimal.Divide(raid.Item2.honours, time);
                raid.Item2.avgTime = timeScore; 
                if(raid.Item2.revive > 0)
                {
                    decimal reviveDeduc = raid.Item2.revive * 10;
                    Debug.WriteLine($"Revives: {raid.Item2.revive}");
                    timeScore = Decimal.Divide(timeScore, reviveDeduc);
                }
                Debug.WriteLine($"Time Score: {timeScore}");
                raid.Item2.score = (int)timeScore;
            }
        }
            
    }
}
