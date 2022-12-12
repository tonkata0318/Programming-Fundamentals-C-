using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string message;
            while ((message=Console.ReadLine())!="end")
            {
                string patternForName = @"@(?<names>[A-Z][A-Za-z]+)[^\@|\!|\:|\-|\>]+!(?<goodOrBad>[A-Z])!";
                Regex regexforName = new Regex(patternForName);
                StringBuilder decryptedMessage = new StringBuilder();
                for (int j = 0; j < message.Length; j++)
                {
                    char ch = message[j];
                    decryptedMessage.Append((char)(ch - n));
                }
                Match matchForName = regexforName.Match(decryptedMessage.ToString());
                if (matchForName.Success)
                {
                    string name=matchForName.Groups["names"].Value;
                    char goodOrBad = char.Parse(matchForName.Groups["goodOrBad"].Value);
                    if (goodOrBad=='G')
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}
