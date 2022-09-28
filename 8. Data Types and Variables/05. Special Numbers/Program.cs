using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastnumber = 0;
            int exactnumber = 0;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                exactnumber = i;
                while (exactnumber>0)
                {
                    sum += exactnumber % 10;
                    exactnumber = exactnumber / 10;
                }
                if (sum==5||sum==7||sum==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;
            }
        }
    }
}
