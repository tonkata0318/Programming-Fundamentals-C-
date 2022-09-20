using System;

namespace _2._Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int dividbleby10 = 0;
            int divbidbleby7 = 0;
            int dividbleby6 = 0;
            int dividbleby3 = 0;
            int divibleby2 = 0;
            int max = 0;
            if (number%2==0)
            {
                divibleby2 = 2;
            }
            if (number%3==0)
            {
                dividbleby3 = 3;
            }
            if (number%6==0)
            {
                dividbleby6 = 6;
            }
            if (number%7==0)
            {
                divbidbleby7 = 7;
            }
            if (number%10==0)
            {
                dividbleby10 = 10;
            }
            if (divibleby2>max)
            {
                max = divibleby2;
            }
            if (dividbleby3>max)
            {
                max = dividbleby3;
            }
            if (dividbleby6>max)
            {
                max = dividbleby6;
            }
            if (divbidbleby7>max)
            {
                max = divbidbleby7;
            }
            if (dividbleby10>max)
            {
                max = dividbleby10;
            }
            if (max!=0)
            {
                Console.WriteLine($"The number is divisible by {max}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
            
    }
}
