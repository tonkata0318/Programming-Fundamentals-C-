using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string pattern = @"(@|#)(?<firstword>[A-Za-z]{3,})\1\1(?<secondword>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            Dictionary<string, string> validPairs = new Dictionary<string, string>();
            foreach (Match match in matches)
            {
                string firstWord=match.Groups["firstword"].Value;
                string secondWord = match.Groups["secondword"].Value;
                string secondWordInBackwords = "";
                for (int i = secondWord.Length-1; i >=0; i--)
                {
                    secondWordInBackwords += secondWord[i];
                }
                if (secondWordInBackwords==firstWord)
                {
                    validPairs.Add(firstWord, secondWord);
                }
            }
            if (matches.Count>0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else if (validPairs.Count==0)
            {
                Console.WriteLine("No word pairs found!");
            }
            if (validPairs.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                foreach (var item in validPairs)
                {
                    if (validPairs[item.Key].Equals(validPairs.Last().Value))
                    {
                        Console.Write($"{item.Key} <=> {item.Value}");
                    }
                    else
                    {
                        Console.Write($"{item.Key} <=> {item.Value}, ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
