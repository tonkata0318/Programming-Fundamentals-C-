using System;

namespace _6._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length-1; i++)
            {
                char currentChar = input[i];
                char nextChar=input[i+1];
                if (currentChar!=nextChar)
                {
                    currentChar = nextChar;
                }
                else
                {
                    input=input.Remove(i,1);
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
