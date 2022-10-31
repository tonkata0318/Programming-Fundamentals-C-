using System;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            Random random = new Random();
            for (int i = 0; i <input.Length; i++)
            {
                int newIndex=random.Next(0,input.Length);
                string curWord = input[i];
                string newWord = input[newIndex];

                input[i] = newWord;
                input[newIndex] = curWord;
            }
            Console.WriteLine(String.Join(Environment.NewLine,input));
        }
    }
}
