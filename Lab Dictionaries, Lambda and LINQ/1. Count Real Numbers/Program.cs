using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            SortedDictionary<int, int> count = new SortedDictionary<int, int>();
            foreach (var number in numbers)
            {
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count.Add(number, 1);
                }
            }
            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
