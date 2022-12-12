using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternForEmoji = @"((\*\*)|(\:\:))(?<emoji>[A-Z][a-z]{2,})\1";
            Regex regexForEmoji=new Regex(patternForEmoji);
            string patterForThreshholders = @"\d{1}";
            Regex regexForTreshHolders=new Regex(patterForThreshholders);
            string input = Console.ReadLine();
            MatchCollection matchesForEmoji=regexForEmoji.Matches(input);
            MatchCollection matchesForThresholders = regexForTreshHolders.Matches(input);
            BigInteger threshHolders = new BigInteger(1);
            int coolOnes = 0;
            foreach (Match match in matchesForThresholders)
            {
                threshHolders *= int.Parse(match.Value);
            }
            Console.WriteLine($"Cool threshold: {threshHolders}");
            Console.WriteLine($"{matchesForEmoji.Count} emojis found in the text. The cool ones are:");
            foreach (Match match in matchesForEmoji)
            {
                string matchEmoji = match.Groups["emoji"].Value;
                int coolnes = 0;
                for (int i = 0; i < matchEmoji.Length; i++)
                {
                    if (matchEmoji[i] != '*' && matchEmoji[i]!=':')
                    {
                        coolnes += matchEmoji[i];
                    }
                }
                if (coolnes>threshHolders)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
