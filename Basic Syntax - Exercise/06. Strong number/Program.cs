using System;
using System.Linq;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numCopy = n;
            int factorielSum = 0;
            while (numCopy>0)
            {
                int lastDigit = numCopy % 10;
                numCopy = numCopy / 10;
                int factoriel = 1;
                for (int i = 2; i <=lastDigit; i++)
                {
                    factoriel *= i;
                }
                factorielSum = factorielSum + factoriel;
            }
            if (factorielSum==n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
