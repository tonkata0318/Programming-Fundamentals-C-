using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_Strin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            Dictionary<char, int> charsinInput = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char[] charArray = input[i].ToCharArray();
                for (int j = 0; j < charArray.Length; j++)
                {
                    if (!charsinInput.ContainsKey(charArray[j]))
                    {
                        charsinInput[charArray[j]] = 1;
                    }
                    else
                    {
                        charsinInput[charArray[j]]++;
                    }
                }
                
            }
            foreach (var kvp in charsinInput)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
