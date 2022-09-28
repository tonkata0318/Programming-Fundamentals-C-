using System;

namespace More_Exercise_02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 1; i <= lines; i++)
            {
                string numbers = Console.ReadLine();
                string firstnumber = numbers.Substring(0, numbers.IndexOf(" "));
                string secondnumber = numbers.Substring(firstnumber.Length+1);
                long firstNumbverInteger = long.Parse(firstnumber);
                long secondNumberInteger = long.Parse(secondnumber);
                if (firstNumbverInteger>secondNumberInteger)
                {
                    firstNumbverInteger = Math.Abs(firstNumbverInteger);
                    while (firstNumbverInteger>0)
                    {
                        sum = sum + firstNumbverInteger % 10;
                        firstNumbverInteger = firstNumbverInteger / 10;
                    }
                }
                else
                {
                    secondNumberInteger = Math.Abs(secondNumberInteger);
                    while (secondNumberInteger > 0)
                    {
                        sum = sum + secondNumberInteger % 10;
                        secondNumberInteger = secondNumberInteger / 10;
                    }
                }
                Console.WriteLine(sum);
                sum = 0;
            }

        }
    }
}
