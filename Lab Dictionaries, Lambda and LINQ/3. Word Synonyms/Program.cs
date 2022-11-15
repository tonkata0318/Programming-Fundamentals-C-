using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string syndrom = Console.ReadLine();
                if (dic.ContainsKey(word))
                {
                    dic[word].Add(syndrom);
                }
                else
                {
                    dic.Add(word, new List<string>());
                    dic[word].Add(syndrom);
                }
            }
            foreach (var word in dic)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
