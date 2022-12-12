using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\/|\=])(?<destinationname>[A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection maches = regex.Matches(input);
            int travelPopints = 0;
            List<string> destinations = new List<string>();
            foreach (Match match in maches)
            {
                string destination = match.Groups["destinationname"].Value;
                destinations.Add(destination);
                for (int i = 0; i < destination.Length; i++)
                {
                    travelPopints++;
                }
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPopints}");
        }
    }
}
