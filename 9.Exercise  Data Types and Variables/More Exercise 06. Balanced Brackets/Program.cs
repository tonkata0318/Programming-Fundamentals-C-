using System;
using System.Collections.Generic;

namespace More_Exercise_06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            for (int i = 1; i <=n; i++)
            {
                string input = Console.ReadLine();
                if (stack.Count>0 && input == ")")
                {
                    stack.Pop();
                    continue;
                }
                if (input=="(")
                {
                    stack.Push(input);
                }
            }
            if (stack.Count>0)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
