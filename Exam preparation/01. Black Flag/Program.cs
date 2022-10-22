using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal daysOfPlunder = decimal.Parse(Console.ReadLine());
            decimal dailyPlunder=decimal.Parse(Console.ReadLine());
            decimal expectedPlunder=decimal.Parse(Console.ReadLine());
            decimal totalPlunder = 0;
            for (int i = 1; i <= daysOfPlunder; i++)
            {
                totalPlunder += dailyPlunder;
                if (i%3==0)
                {
                    totalPlunder = totalPlunder + (dailyPlunder * 0.50m);
                }
                if (i%5==0)
                {
                    totalPlunder = totalPlunder - (totalPlunder * 0.30m);
                }
            }
            if (totalPlunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                decimal percentage = (totalPlunder / expectedPlunder)*100m;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
