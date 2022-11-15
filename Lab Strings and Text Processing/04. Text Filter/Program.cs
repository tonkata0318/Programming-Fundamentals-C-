using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords=Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text=text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
