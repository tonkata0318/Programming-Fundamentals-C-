using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Dictionary<string, string> tresures = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while(input!="find")
            {
                string decryptedMessage = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < keys.Length; j++)
                    {
                        if (i<=input.Length-1)
                        {
                            decryptedMessage += (char)(input[i] - keys[j]);
                            if (j < keys.Length - 1)
                            {
                                i++;
                            }
                        }
                    }
                }
                int startIndexForType = decryptedMessage.IndexOf("&");
                startIndexForType++;
                int endINdexForType = decryptedMessage.LastIndexOf("&");
                int startIndexForCor = decryptedMessage.IndexOf("<");
                startIndexForCor++;
                int endIndexForCor = decryptedMessage.IndexOf('>');
                string type = decryptedMessage[startIndexForType..endINdexForType];
                string cordinates = decryptedMessage[startIndexForCor..endIndexForCor];
                tresures[type] = cordinates;
                input = Console.ReadLine();
            }
            foreach (var treasure in tresures)
            {
                Console.WriteLine($"Found {treasure.Key} at {treasure.Value}");
            }
        }
    }
}
