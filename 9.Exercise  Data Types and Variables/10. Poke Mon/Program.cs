using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int countOfTargets = 0;
            int originalValueOfN = N;
            while (N>=M)
            {
                N = N - M;
                countOfTargets++;
                if (N==originalValueOfN*0.50 && Y != 0)
                {
                    N = N / Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(countOfTargets);
        }
    }
}
