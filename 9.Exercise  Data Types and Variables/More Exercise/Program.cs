using System;

namespace More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int nummber = 2; nummber <= n; nummber++)
            {
                bool isPrime = true;
                for (int prime = 2; prime < nummber; prime++)
                {
                    if (nummber % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", nummber, isPrime.ToString().ToLower());
            }
        }
    }
}
