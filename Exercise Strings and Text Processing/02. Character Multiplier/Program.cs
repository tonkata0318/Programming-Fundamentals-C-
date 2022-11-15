using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ");
            string firstString=strings[0];
            string secondString=strings[1];
            CharacterMultiplyer(firstString, secondString);
        }
        static void CharacterMultiplyer(string firstString,string secondString)
        {
            int sum = 0;
            if (firstString.Length<secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum+=firstString[i] * secondString[i];
                }
                for (int i = firstString.Length; i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }
            else if (secondString.Length<firstString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    sum += secondString[i] * firstString[i];
                }
                for (int i = secondString.Length; i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }
            }
            else if (secondString.Length==firstString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    sum += secondString[i] * firstString[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
