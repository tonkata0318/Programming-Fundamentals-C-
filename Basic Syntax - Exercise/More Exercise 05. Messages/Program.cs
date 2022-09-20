using System;

namespace More_Exercise_05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string theMEssage = string.Empty;
            int offsetOfNumber = 0;
            int numberofdigit = 0;
            int mainnumber = 0;
            int n = int.Parse(Console.ReadLine());
            int letterIndex = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    theMEssage += " ";
                    continue;
                }
                else if (number > 999)
                {
                    numberofdigit = 4;
                }
                else if (number > 99)
                {
                    numberofdigit = 3;
                }
                else if (number > 9)
                {
                    numberofdigit = 2;
                }
                else
                {
                    numberofdigit = 1;
                }
                mainnumber = number % 10;

                int additionalOffset = 0;
                int letterSetLength = 3;
                if (mainnumber > 7)
                {
                    additionalOffset = 2;
                    letterSetLength += 1;
                }
                else if (mainnumber > 6)
                {
                    additionalOffset = 1;
                    letterSetLength += 1;
                }

                offsetOfNumber = ((mainnumber - 1) * 3 + additionalOffset) - (letterSetLength - numberofdigit);

                letterIndex = 96 + offsetOfNumber;
                theMEssage += Convert.ToChar(letterIndex);
            }
            Console.WriteLine(theMEssage);
        }
    }
}