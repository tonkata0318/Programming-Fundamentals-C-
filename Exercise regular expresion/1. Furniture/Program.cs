using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitures = new List<string>();
            double price = 0;
            string input = Console.ReadLine();
            string pattern = @"^>>(?<furniturename>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex=new Regex(pattern);
            while (input != "Purchase")
            {
                Match match=regex.Match(input);
                if (match.Success)
                {
                    furnitures.Add(match.Groups["furniturename"].Value);
                    double priceperFurniture = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    price += quantity*priceperFurniture;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furnitures)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }
}
