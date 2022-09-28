using System;

namespace _1._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metres = int.Parse(Console.ReadLine());
            double kilometres = metres / 1000.0;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
