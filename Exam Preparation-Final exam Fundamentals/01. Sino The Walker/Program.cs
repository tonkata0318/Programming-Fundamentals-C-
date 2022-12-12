using System;

namespace _01._Sino_The_Walker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(":");
            int hours=int.Parse(time[0]);
            int minutes=int.Parse(time[1]);
            int seconds=int.Parse(time[2]);
            int stepsTaken=int.Parse(Console.ReadLine());
            int timeForEachStep=int.Parse(Console.ReadLine());
            int secondsTakenToGetHome = stepsTaken * timeForEachStep;
            seconds += secondsTakenToGetHome;
            if (seconds>=60)
            {
                seconds = 0;
                minutes+=seconds
            }
        }
    }
}
