using NeverGuildWar_Buddy.Forms.User_Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverGuildWar_Buddy.Classes
{   
    internal class CalculatorClass
    {
      

        int exPHonours = 80800;
        int exHonours = 50000;
        int box1Tokens = 1600;
        int box2Tokens = 2400;
        int box5Tokens = 2000;
        int box46Tokens = 10000;
        int box81Tokens = 15000;

        int meatRaid = 0;

        public void UpdateMeatRaid()
        {
            switch (meatRaid)
            {
                case 0:
                    meatRaid = 1;
                    break;
                case 1:
                    meatRaid = 0;
                    break;
            }
        }

        public int TokensRequired(int targetBox)
        {
            int totalTokens = 0;
            int index = targetBox;
            for (int i = index; i > 0; i--)
            {
                if (i == 1)
                {
                    totalTokens += box1Tokens;
                    Debug.WriteLine($"Adding {box1Tokens}");
                }
                if (i >= 2 && i <= 4)
                {
                    totalTokens += (box2Tokens);
                    Debug.WriteLine($"Adding {box2Tokens}");
                }
                if (i >= 5 && i <= 20)
                {
                    totalTokens += (box5Tokens);
                    Debug.WriteLine($"Adding {box5Tokens}");
                }
                if (i >= 46 && i <= 6)
                {
                    totalTokens += (box46Tokens);
                    Debug.WriteLine($"Adding {box46Tokens}");
                }
                if (i >= 81 && i <= 47)
                {
                    totalTokens += (box81Tokens);
                    Debug.WriteLine($"Adding {box81Tokens}");
                }
            }
            return totalTokens;
        }

        public int HonoursRequired(int targetHonours)
        {
            int totalHonours = 0;
            return totalHonours;
        }
    }

    internal class GWRaids
    {
        public int divNum = 1000000;
        public int timeScore = 60;
        public int baseCost = 90;
        int halfPot = 75;
        int maxAP = 999;
        public int meat { get; set; }
        public int farmOption = 1;
        public decimal timeBest;
        public decimal timeWorst;

        public void SetMeatFarm(EX raid)
        {
            farmOption = 0;
        }
        public void SetMeatFarm(EXPlus raid)
        {
            farmOption = 1;
        }

        public decimal rateConversion(int rate)
        {
            double numOfDigits = Math.Floor(Math.Log10(rate) + 1);
            Debug.WriteLine($"There are {numOfDigits} digits in {rate}");
            string one = "1";
            for (int i = 2; i < numOfDigits; i++)
            {
                one += "0";
            }
            int conversion = Int32.Parse(one);
            decimal answer = Decimal.Divide(rate, conversion);
            Debug.WriteLine($"Math is {answer} = {rate} div {conversion}");
            return answer;
        }

        public int honourEff(int honourRate)
        {
            int honourScore = 0;
            if (honourRate >= 90)
            {
                honourScore = 50;
                return honourScore;
            }
            if (honourRate <= 70)
            {
                honourScore = 30;
                return honourScore;
            }
            if (honourRate <= 50)
            {
                honourScore = 15;
                return honourScore;
            }
            return honourScore;
        }
        public bool RefillAP(int AP, int cost)
        {
            if (cost > AP)
            {
                return true;
            }
            return false;
        }
        public decimal PotCost(decimal battles, int cost)
        {
            decimal trueCost = battles * cost;
            decimal pots = Decimal.Divide(trueCost, halfPot);
            pots = Math.Round(pots, 1);
            Debug.WriteLine($"Cost per battle: {cost} x battles {battles} = {pots}");
            return pots;
        }
        public decimal MeatCost(decimal battle, int meat)
        {
            decimal cost = battle * meat;
            Debug.WriteLine($"Meat cost: {battle}*{meat}");
            return cost;
        }
        public decimal TokenYield(decimal battles, int token)
        {
            decimal yield = battles * token;
            Debug.WriteLine($"Token yield: {battles}*{token}");
            return yield;
        }
        public decimal HonourYield(decimal battles, int honours)
        {
            decimal yield = battles * honours;
            Debug.WriteLine($"Honour yield: {battles}*{honours}");
            return yield;
        }

        public Tuple<decimal, decimal> MeatPostCalc(decimal targetMeat, EX ex)
        {
            Tuple<decimal, decimal> tuple;
            if (meat <= 0)
            {
                decimal runs = Decimal.Divide(targetMeat, ex.meatCost);
                decimal honours = MeatFarming(runs, ex);
                decimal cost = runs * ex.meatCost;
                tuple = Tuple.Create(cost, honours);
                return tuple;
            }
            decimal a = 0;
            decimal b = 0;
            tuple = Tuple.Create(a, b);
            return tuple;
        }

        public List<decimal> MeatPostCalc(decimal targetMeat, EXPlus ex)
        {
            List<decimal> list = new();
            if (meat <= 0)
            {
                decimal runs = Decimal.Divide(targetMeat, ex.meatCost);
                decimal honours = MeatFarming(runs, ex);
                decimal cost = runs * ex.meatCost;
                decimal ap = runs * ex.hostCost.Item1;
                cost = Math.Round(cost, 2);
                honours = Math.Round(honours);
                Debug.WriteLine($"Meat needed = {cost}\n honours gained {honours}");
                decimal tokens = runs * ex.token;
                tokens = Math.Round(tokens);
                decimal pots = PotCost(runs, ex.hostCost.Item1);
                pots = Math.Round(pots);
                list.Add(ap);
                list.Add(runs);
                list.Add(honours);
                list.Add(cost);
                list.Add(tokens);
                list.Add(pots);
                return list;
            }
            if (meat > 0)
            {
                decimal remainder = meat - targetMeat;

                if (remainder < 1)
                {
                    decimal runs = Decimal.Divide(targetMeat, ex.meatCost);
                    decimal honours = MeatFarming(runs, ex);
                    decimal cost = runs * ex.meatCost;
                    decimal ap = runs * ex.hostCost.Item1;
                    cost = Math.Round(cost, 2);
                    honours = Math.Round(honours);
                    Debug.WriteLine($"Meat needed = {cost}\n honours gained {honours}");
                    decimal tokens = runs * ex.token;
                    tokens = Math.Round(tokens);
                    decimal pots = PotCost(runs, ex.hostCost.Item1);
                    pots = Math.Round(pots);
                    list.Add(ap);
                    list.Add(runs);
                    list.Add(honours);
                    list.Add(cost);
                    list.Add(tokens);
                    list.Add(pots);
                    return list;
                }
                if (remainder > 1)
                {
                    return list;               
                }
            }
            decimal a = 0;
            list.Add(a);
            return list;
        }


        public decimal MeatFarming(decimal runs, EX ex)
        {
            decimal honours = runs * ex.honours;
            return honours;

        }

        public decimal MeatFarming(decimal runs, EXPlus ex)
        {
            decimal honours = runs * ex.honours;
            return honours;
        }

        public RaidTableRow row(string level, decimal honour, decimal meatCost, decimal battles,
            decimal totalMeat, decimal token, decimal totalHonour, decimal pot)
        {
            RaidTableRow raid = new(level, honour, meatCost, battles, totalMeat, token, totalHonour, pot);
            return raid;
        }

        public void ResizeTable(TableLayoutPanel table)
        {
            var styles = table.RowStyles;
            int count = table.RowCount;
            int tableHeigt = table.Height;
            int sizeDistrubution = tableHeigt / count;
            float percentageHeight = 33;
            table.RowStyles.Clear();
            Debug.WriteLine($"Table Height: {tableHeigt}");
            foreach (RowStyle style in styles)
            {
                Debug.WriteLine($"Type: {style.SizeType}, Height: {style.Height}");
                style.Height = sizeDistrubution;
                Debug.WriteLine($"Type: {style.SizeType}, Height: {style.Height}");
            }
        }

    }

    class EX : GWRaids
    {
        public int honours = 50000;
        public int token = 22;
        public Tuple<int, int> hostCost = new Tuple<int, int>(30, 0);
        public int meatCost = 5;
    }

    class EXPlus : GWRaids
    {
        public int honours = 80800;
        public int token = 26;
        public Tuple<int, int> hostCost = new Tuple<int, int>(30, 0);
        public int meatCost = 6;
        public string name = "EX+";
    }


    class NM90 : GWRaids
    {
        public int honours = 260000;
        public int token = 45;
        public Tuple<int, int> hostCost = new Tuple<int, int>(30, 5);
        int timeBest;
        int timeWorst;
        public int OptimalRating()
        {
            int rating;
            int sumTime = timeBest + timeWorst;
            int honourRate = honours / divNum;
            decimal avgTime = Decimal.Divide(sumTime, 2);
            decimal timeRating = timeScore - avgTime;
            decimal rewardRatio = hostCost.Item2 + honourRate;
            decimal score = timeRating + rewardRatio;
            rating = (int)(score);
            Debug.WriteLine($"Time score = {timeScore} AT:{avgTime}\n" +
                $"Reward Ration = Meat:{hostCost.Item2} + Honour Rate{honourRate}\n" +
                $"Score = {timeRating} - {rewardRatio}");
            return rating;

        }
    }

    class NM95 : GWRaids
    {
        public int honours = 910000;
        public int token = 55;
        public Tuple<int, int> hostCost = new Tuple<int, int>(30, 5);
  
        public int OptimalRating()
        {
            int rating;
            decimal sumTime = timeBest + timeWorst;
            int honourRate = honours / divNum;
            decimal avgTime = Decimal.Divide(sumTime, 2);
            decimal timeRating = timeScore - avgTime;
            decimal rewardRatio = hostCost.Item2 + honourRate;
            decimal score = timeRating + rewardRatio;
            rating = (int)(score);
            Debug.WriteLine($"Time score = {timeScore} AT:{avgTime}\n" +
                $"Reward Ration = Meat:{hostCost.Item2} + Honour Rate{honourRate}\n" +
                $"Score = {timeRating} - {rewardRatio}");
            return rating;

        }
    }
    class NM100 : GWRaids
    {
        public int honours = 2650000;
        public int token = 80;
        public Tuple<int, int> hostCost = new Tuple<int, int>(50, 10);
        int timeBest;
        int timeWorst;
        public int OptimalRating()
        {
            int rating;
            int sumTime = timeBest + timeWorst;
            int honourRate = honours / divNum;
            decimal avgTime = Decimal.Divide(sumTime, 2);
            decimal timeRating = timeScore - avgTime;
            decimal rewardRatio = hostCost.Item2 + honourRate;
            decimal score = timeRating + rewardRatio;
            rating = (int)(score);
            Debug.WriteLine($"Time score = {timeScore} AT:{avgTime}\n" +
                $"Reward Ration = Meat:{hostCost.Item2} + Honour Rate{honourRate}\n" +
                $"Score = {timeRating} - {rewardRatio}");
            return rating;

        }
    }
    class NM150 : GWRaids
    {
        public int honours = 4100000;
        public int token = 100;
        public Tuple<int, int> hostCost = new Tuple<int, int>(50, 20);
        int timeBest;
        int timeWorst;

        public int OptimalRating()
        {
            int rating;
            int sumTime = timeBest + timeWorst;
            int honourRate = honours / divNum;
            decimal avgTime = Decimal.Divide(sumTime, 2);
            decimal timeRating = timeScore - avgTime;
            decimal rewardRatio = hostCost.Item2 + honourRate;
            decimal score = timeRating + rewardRatio;
            rating = (int)(score);
            Debug.WriteLine($"Time score = {timeScore} AT:{avgTime}\n" +
                $"Reward Ration = Meat:{hostCost.Item2} + Honour Rate{honourRate}\n" +
                $"Score = {timeRating} - {rewardRatio}");
            return rating;

        }
    }
    class NM200 : GWRaids
    {
        string name = "NM 200";
        public int honours = 10250000;
        public int token = 160;
        public Tuple<int, int> hostCost = new Tuple<int, int>(50, 30);

        bool revive;
        int reviveCount = 0;
        decimal target;


        public NM200(bool revive, decimal timeBest, decimal timeWorst, decimal target)
        {
            if (revive)
            {
                this.revive = true;
            }
            else
            {
                this.revive = false;
            }
            this.timeBest = timeBest;
            this.timeWorst = timeWorst;
            this.target = target;
        }

        public void SetRevives(int revies)
        {
            reviveCount = revies;
        }

        public List<RaidTableRow> RequiredNumbers()
        {
            List<RaidTableRow> result = new List<RaidTableRow>();
            decimal intBattles = Decimal.Divide(target, honours);
            decimal meat = MeatCost(intBattles, hostCost.Item2);
            List<decimal> list = new();
            int meatHeld = this.meat;
            meat = (decimal)meat - meatHeld;
            if (farmOption == 1)
            {
                EXPlus exP = new();
                list = MeatPostCalc(meat, exP);
                if (list.Count > 0)
                {
                    RaidTableRow exPRow = new(exP.name, exP.honours, exP.hostCost.Item2, list[1],
          list[3], list[4], list[2], list[5]);
                    result.Add(exPRow);
                    target = target - list[2];
                }

            }
            else
            {
                EX ex = new();
                MeatPostCalc(meat, ex);
            }

            intBattles = Decimal.Divide(target, honours);
            meat = MeatCost(intBattles, hostCost.Item2);

            decimal tokens = TokenYield(intBattles, token);
            decimal honour = HonourYield(intBattles, honours);
            decimal pots = PotCost(intBattles, hostCost.Item1);
            tokens = Math.Round(tokens, 1);
            honour = Math.Round(honour);
            meat = Math.Round(meat);
            pots = Math.Round(pots, 1);
            intBattles = Math.Round(intBattles, 1);
            RaidTableRow row = new(name, honours, hostCost.Item2, intBattles, meat, tokens, honour, pots);
            
            result.Add(row);
            return result;
        }

        public int EffScore()
        {
            int score;
            decimal sumTime = timeBest + timeWorst;
            decimal avgTime = Decimal.Divide(sumTime, 2);
            int costValue = hostCost.Item1 + hostCost.Item2;
            int costSum = baseCost - costValue;
            decimal honourRate = target / honours;
            decimal rate = divNum / honourRate;
            int honourScore = honourEff((int)honourRate);
            decimal ratio = rateConversion((int)rate);
            Debug.WriteLine($"Time score = {timeScore} AT:{avgTime}\n" +
              $"Cost Value = {costValue}\n Honour Rate{target} div {honours}\n" +
              $"rate = {divNum} div {honourRate}\n" +
              $"Score = ({avgTime} + {costSum}) + {ratio} + {honourScore}");
            score = (int)((int)(avgTime + costSum) + ratio + honourScore);
            if (revive)
            {
                score = -reviveCount;
            }
            Debug.WriteLine(score);
            return score;

        }
    }
    enum raids
    {
        NM90,
        NM95,
        NM100,
        NM150,
        NM200
    }
}
