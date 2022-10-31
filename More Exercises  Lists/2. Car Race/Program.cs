using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            double timeForLeftRacer = 0;
            double timeForRightRacer = 0;
            for (int i = 0; i < numbers.Count/2; i++)
            {
                if (numbers[i]==0)
                {
                    timeForLeftRacer -= timeForLeftRacer * 0.20;
                }
                else
                {
                    timeForLeftRacer += numbers[i];
                }
            }
            for (int i = numbers.Count-1; i > numbers.Count / 2; i--)
            {
                if (numbers[i] == 0)
                {
                    timeForRightRacer -= timeForRightRacer * 0.20;
                }
                else
                {
                    timeForRightRacer += numbers[i];
                }
            }
            if (timeForLeftRacer<timeForRightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {timeForLeftRacer}");
            }
            else if (timeForRightRacer<=timeForLeftRacer)
            {
                Console.WriteLine($"The winner is right with total time: {timeForRightRacer}");
            }
        }
    }
}
