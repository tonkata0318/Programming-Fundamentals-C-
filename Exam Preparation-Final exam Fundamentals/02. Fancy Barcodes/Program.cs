using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#{1,}[A-Z](?<digits>[A-Za-zdigits\d]{4,})[A-Z]@#{1,}";
            Regex regex=new Regex(pattern);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string group = match.Groups["digits"].Value;
                    string barcode = "";
                    foreach (char item in group)
                    {
                        if (char.IsDigit(item))
                        {
                            barcode += item;
                        }
                    }
                    if (barcode == "")
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {barcode}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
