using System;
using System.Text.RegularExpressions;
using System.Transactions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternt = @"%(?<customer>[A-Z][a-z]+)%[^\|\,\.\$\%]*?<(?<product>\w+)>[^\|\,\.\$\%]*?\|(?<count>\d+)\|[^\|\,\.\$\%]*?(?<quantity>\d+(\.\d+)?)\$[^\|\,\.\$\%]*?";
            Regex regex = new Regex(patternt);
            string input = Console.ReadLine();
            double totalIncome = 0;
            while (input!="end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string customerName=match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    double totalPrice = double.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["quantity"].Value);
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
