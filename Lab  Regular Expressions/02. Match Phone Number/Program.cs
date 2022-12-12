using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}";
            string input=Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection maches=regex.Matches(input);
            string[] result = maches.Select(x => x.Value).ToArray();
            Console.Write(String.Join(", ",result));
        }
    }
}
