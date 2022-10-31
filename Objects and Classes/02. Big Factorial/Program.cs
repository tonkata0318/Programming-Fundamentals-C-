using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <=n ; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
