using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            List<double> greatherThanAverage = new List<double>();
            double averageNumber = list.Average();
            int greatherIndexCounter = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]>averageNumber)
                {
                    double firstListValue = list[i];
                    greatherThanAverage.Add(firstListValue);
                    greatherIndexCounter++;
                }
            }
            greatherThanAverage.Sort();
            greatherThanAverage.Reverse();
            if (greatherThanAverage.Count>=5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(greatherThanAverage[i]+" ");
                }
            }
            else if (greatherThanAverage.Count<5&&greatherThanAverage.Count>0)
            {
                for (int i = 0; i < greatherThanAverage.Count; i++)
                {
                    Console.Write(greatherThanAverage[i]+" ");
                }
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
