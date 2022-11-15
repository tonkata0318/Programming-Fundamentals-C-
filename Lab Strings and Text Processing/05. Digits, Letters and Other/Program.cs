using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line=Console.ReadLine();
            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                bool number=char.IsDigit(line[i]);
                bool letter = char.IsLetter(line[i]);
                if (number)
                {
                    numbers.Append(line[i]);
                }
                else if (letter)
                {
                    letters.Append(line[i]);
                }
                else if (letter==false&&number==false)
                {
                    others.Append(line[i]);
                }

            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
