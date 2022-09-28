using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minute
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days =(int)(years * 365.2422);
            int hourse = days * 24;
            int minutes = hourse * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hourse} hours = {minutes} minutes");
        }
    }
}
