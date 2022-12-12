using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            string namePattern = @"[A-Za-z]";
            string distancePattern = @"[0-9]";

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder sb = new StringBuilder();
                int distance = 0;

                MatchCollection currLetters = Regex.Matches(input, namePattern);

                MatchCollection currDigits = Regex.Matches(input, distancePattern);

                foreach (Match letter in currLetters)
                {
                    sb.Append(letter.Value);
                }

                foreach (Match digit in currDigits)
                {
                    distance += int.Parse(digit.Value);
                }

                string racerName = sb.ToString();

                if (racers.ContainsKey(racerName))
                {
                    racers[racerName] += distance;
                }
            }

            string[] bestRacers = racers.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToArray();

            Console.WriteLine($"1st place: {bestRacers[0]}");

            Console.WriteLine($"2nd place: {bestRacers[1]}");

            Console.WriteLine($"3rd place: {bestRacers[2]}");
        }
    }
}