using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litresAddedInTank = 0;
            for (int i = 1; i <=n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                litresAddedInTank += litres;
                if (litresAddedInTank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litresAddedInTank -= litres;
                }
            }
            Console.WriteLine(litresAddedInTank);
        }
    }
}
