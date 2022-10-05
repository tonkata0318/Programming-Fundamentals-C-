using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] temp = new int[Array.Length];
            for (int i = 0; i <temp.Length-1; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    temp[j] = Array[j] + Array[j + 1];
                    Array[j] = temp[j];
                }
                temp[i] = Array[i] + Array[i + 1];
            }
            if (Array.Length==1)
            {
                Console.WriteLine(Array[0]);
            }
            else
            {
                Console.WriteLine(temp[0]);
            }
        }
    }
}
