using System;

namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int input = int.Parse(Console.ReadLine());
            if (input<1||input>7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(days[input-1]);
        }
    }
}
