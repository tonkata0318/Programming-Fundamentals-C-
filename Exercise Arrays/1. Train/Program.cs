using System;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] peopleInWagon = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                peopleInWagon[i] = int.Parse(Console.ReadLine());
                sum += peopleInWagon[i];
            }
            for (int i = 0; i <n; i++)
            {
                Console.Write(peopleInWagon[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
