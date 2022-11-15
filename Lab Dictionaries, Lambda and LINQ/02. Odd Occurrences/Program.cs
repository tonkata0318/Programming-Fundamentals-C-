using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            Dictionary<string,int> countsOfWords=new Dictionary<string,int>();
            foreach (var word in words)
            {
                string wordInLower=word.ToLower();
                if (countsOfWords.ContainsKey(wordInLower))
                {
                    countsOfWords[wordInLower]++;
                }
                else
                {
                    countsOfWords.Add(wordInLower, 1);
                }
            }
            foreach (var word in countsOfWords)
            {
                if (word.Value%2!=0)
                {
                    Console.Write(word.Key+" ");
                }
            }
        }
    }
}
