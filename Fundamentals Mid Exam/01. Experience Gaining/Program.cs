using System;
using System.Data;

namespace _01._Experience_Gaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal neededExp=decimal.Parse(Console.ReadLine());
            decimal countOfBattles = decimal.Parse(Console.ReadLine());
            decimal gatheredExp = 0m;
            decimal neededBattles = 0m;
            bool flag=false; 
            for (int i = 1; i <= countOfBattles; i++)
            {
                decimal expEarnedinBattle = decimal.Parse(Console.ReadLine());
                gatheredExp+=expEarnedinBattle;
                if (i%3==0)
                {
                    gatheredExp += expEarnedinBattle * 0.15m;
                }
                else if (i%5==0)
                {
                    gatheredExp -= expEarnedinBattle * 0.10m;
                }
                else if (i%15==0)
                {
                    gatheredExp += expEarnedinBattle * 0.05m;
                }
                if (gatheredExp>=neededExp)
                {
                    //if (flag)
                    //{
                    //    continue;
                    //}
                    flag = true;
                    neededBattles = i;
                    break;
                }
            }
            if (gatheredExp>=neededExp)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {neededBattles} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExp-gatheredExp:f2} more needed.");
            }
        }
    }
}
