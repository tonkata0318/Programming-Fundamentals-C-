using System;

namespace More_Exercise1._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input!="END")
            {
                bool isInteger=int.TryParse(input, out int n);
                bool isbool = bool.TryParse(input, out bool b);
                bool isDouble = double.TryParse(input, out double d);
                bool isChar = char.TryParse(input, out char ch);
                if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isDouble)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isbool)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
