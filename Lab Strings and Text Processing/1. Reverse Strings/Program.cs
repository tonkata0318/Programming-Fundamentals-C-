using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string reversed = "";
            while (line!="end")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];
                }
                Console.WriteLine($"{line} = {reversed}");
                line = Console.ReadLine();
                reversed = string.Empty;
            }
        }
    }
}
