using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]+)\1(?<years>\d{4})\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection maches= regex.Matches(input);
            foreach (Match item in maches)
            {
                Console.Write($"Day: {item.Groups[2]}, Month: {item.Groups[3]}, Year: {item.Groups[4]}");
                Console.WriteLine();
            }
        }
    }
}
