using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spices = int.Parse(Console.ReadLine());
            int totalConsume = 0;
            int countDays = 0;
            while (spices>=100)
            {
                totalConsume += spices - 26;
                spices = spices - 10;
                countDays++;
            }
            Console.WriteLine(countDays);
            if (countDays>0)
            {
                Console.WriteLine(totalConsume-26);
            }
            else
            {
                Console.WriteLine(totalConsume);
            }

        }
    }
}
