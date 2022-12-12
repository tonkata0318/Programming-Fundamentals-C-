using System;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection maches = regex.Matches(input);
            foreach (Match item in maches)
            {
                Console.Write(item.Value+" ");
            }


        }
    }
}
