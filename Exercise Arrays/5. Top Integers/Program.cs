using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] topIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] temp = new int[topIntegers.Length];
            for (int j = 0; j < topIntegers.Length; j++)
            {
                for (int i = 0; i < topIntegers.Length; i++)
                {
                    if (topIntegers[i] > topIntegers[i + 1] && topIntegers[i + 1] > topIntegers[i + 2])
                    {
                        temp[j] = topIntegers[j];
                    }
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
    }
}
