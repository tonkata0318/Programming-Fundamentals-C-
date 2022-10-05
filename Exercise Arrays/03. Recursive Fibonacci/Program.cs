using System;
using System.Numerics;

namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        public static void Fibonacci(long n)
        {
            BigInteger[] sequances = new BigInteger[n+1];
            BigInteger whantedNumber = 1;
            for (int i = 3; i < sequances.Length; i++)
            {
                sequances[0] = 0;
                sequances[1] = 1;
                sequances[2] = 1;
                sequances[i] = sequances[i - 2] + sequances[i - 1];
                whantedNumber = sequances[i];
            }
            Console.WriteLine(whantedNumber);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n<0)
            {
                n = int.Parse(Console.ReadLine());
            }
            Fibonacci(n);
        }
    }
}
