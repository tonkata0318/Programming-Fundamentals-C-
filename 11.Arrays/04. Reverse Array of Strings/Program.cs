using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] something = Console.ReadLine().Split(" ").ToArray();
            for (int i = 0; i < something.Length/2; i++)
            {
                string temp = something[i];
                something[i] = something[something.Length - 1 - i];
                something[something.Length - 1 - i] = temp;
            }
            Console.WriteLine(String.Join(' ',something));
        }
    }
}
