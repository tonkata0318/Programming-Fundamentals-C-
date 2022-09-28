using System;

namespace More_Exercise_03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            if (numberA > numberB)
            {
                double diff = numberA - numberB;
                if (diff>eps)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
            else
            {
                double diff = numberB - numberA;
                if (diff > eps)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
        }
    }
}
