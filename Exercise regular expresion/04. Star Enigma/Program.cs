using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"[^\@\-\!\,\:\>]*@(?<planet>[A-Za-z]+)[^\@\-\!\,\:\>]*:(?<population>\d+)[^\@\-\!\,\:\>]*!(?<atacktype>A|D)![^\@\-\!\,\:\>]*->(?<soldierscount>\d+)[^\@\-\!\,\:\>]*";
            List<string> atackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            Regex regex=new Regex(pattern);
            for (int i = 0; i < n; i++) 
            {
                string encryptedMessage = Console.ReadLine();
                int keys=GetDecryptedKey(encryptedMessage);
                string decryptedmessages=(DecryptedMessage(keys, encryptedMessage));
                Match match = regex.Match(decryptedmessages);
                if (match.Success)
                {
                    char atackType = char.Parse(match.Groups["atacktype"].Value);
                    string planet = match.Groups["planet"].Value;
                    if (atackType=='A')
                    {
                        atackedPlanets.Add(planet);
                    }
                    else if (atackType=='D')
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {atackedPlanets.Count}");
            foreach (var item in atackedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
        static int GetDecryptedKey(string encryptedMessage)
        {
            int encryptedKey = 0;
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                encryptedMessage = encryptedMessage.ToLower();
                if (encryptedMessage[i].ToString() == "s" || encryptedMessage[i].ToString() == "t" || encryptedMessage[i].ToString() == "a" || encryptedMessage[i].ToString()=="r")
                {
                    encryptedKey++;
                }
            }
            return encryptedKey;
        }
        static string DecryptedMessage(int key,string decryptedMessage)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in decryptedMessage)
            {
                sb.Append((char)(ch - key));
            }
            return sb.ToString();
        }
    }
}
