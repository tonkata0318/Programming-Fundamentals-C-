using System;
using System.Linq;
using System.Collections.Generic;

namespace _4.__Mixed_Up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> thirdList = new List<int>();
            if (firstList.Count>secondList.Count)
            {
                int firstConstrainer = firstList[firstList.Count - 2];
                int secondConstrainer = firstList[firstList.Count-1];
                for (int i = 0; i < secondList.Count; i++)
                {
                    if (firstList[i] > secondConstrainer && firstList[i]<firstConstrainer)
                    {
                        thirdList.Add(firstList[i]);
                    }
                    if (secondList[secondList.Count-i-1]>secondConstrainer&& secondList[secondList.Count - i - 1] <firstConstrainer)
                    {
                        thirdList.Add(secondList[secondList.Count - i - 1]);
                    }
                }
            }
            else if (secondList.Count>firstList.Count)
            {
                int firstConstrainer = secondList[0];
                int secondConstrainer = secondList[1];
                for (int i = 0; i < firstList.Count; i++)
                {
                    if (firstList[i] < secondConstrainer && firstList[i] > firstConstrainer)
                    {
                        thirdList.Add(firstList[i]);
                    }
                    if (secondList[secondList.Count - i - 1] < secondConstrainer && secondList[secondList.Count - i - 1] > firstConstrainer)
                    {
                        thirdList.Add(secondList[secondList.Count - i - 1]);
                    }
                }
            }
            thirdList.Sort();
            Console.WriteLine(String.Join(" ",thirdList));
        }
    }
}
