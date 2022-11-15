using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var word in input)
             {
                    char first = char.Parse(word[0].ToString());
             if (char.IsUpper(first))
             {
                 int position = first - 64;
                 int startIndex = 1;
                 double number = double.Parse(word.Substring(startIndex, word.Length - 2));
                 sum += number / position;
             }
             else if (char.IsLower(first))
             {
                 int position = first - 96;
                    int startIndex = 1;
                 double number = double.Parse(word.Substring(startIndex, word.Length - 2));
                 sum += number * position;
             }
             char second = char.Parse(word[word.Length - 1].ToString());
             if (char.IsUpper(second))
             {
                 int position = second - 64;
                 sum -= position;
             }
             else if (char.IsLower(second))
             {
                 int position = second - 96;
                 sum += position;
             }
                }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
