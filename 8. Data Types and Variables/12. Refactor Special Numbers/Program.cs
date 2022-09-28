using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int ch = 1; ch <= n; ch++)
            {
                int exactNumber = ch;
                while (exactNumber > 0)
                {
                    sum += exactNumber % 10;
                    exactNumber = exactNumber / 10;

                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", ch, isSpecial);
                sum = 0;
            }
        }
    }
}
