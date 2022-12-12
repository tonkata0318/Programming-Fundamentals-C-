using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<delimetres>\||\#)(?<itemName>[A-Za-z ]+)\1(?<day>\d{2})\/(?<months>\d{2})\/(?<year>\d{2})\1(?<calories>\d+)\1";
            Regex regex = new Regex(pattern);
            int neededCalories = 2000;
            string input = Console.ReadLine();
            MatchCollection maches = regex.Matches(input);
            int allcalories = 0;
            foreach (Match item in maches)
            {
                int caloriesAdded = int.Parse(item.Groups["calories"].Value);
                allcalories+=caloriesAdded;
            }
            Console.WriteLine($"You have food to last you for: {allcalories/neededCalories} days!");
            foreach (Match item in maches)
            {
                string itemName = item.Groups["itemName"].Value;
                string day = item.Groups["day"].Value;
                string months = item.Groups["months"].Value;
                int year = int.Parse(item.Groups["year"].Value);
                int calories = int.Parse(item.Groups["calories"].Value);
                Console.WriteLine($"Item: {itemName}, Best before: {day}/{months}/{year}, Nutrition: {calories}");
            }
        }
    }
}
