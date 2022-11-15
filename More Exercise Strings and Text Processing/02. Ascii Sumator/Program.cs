using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char[] characters=text.ToCharArray();
                if (characters[i] > firstChar && characters[i] <secondChar)
                {
                    sum += characters[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
