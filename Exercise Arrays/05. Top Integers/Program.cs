using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                int curNum = arrayNumber[i];
                bool isTopInger = true;
                for (int j = i+1; j < arrayNumber.Length; j++)
                {
                    int nexNum = arrayNumber[j];
                    if (nexNum>=curNum)
                    {
                        isTopInger = false;
                        break;
                    }
                }
                if (isTopInger)
                {
                    Console.Write(curNum+" ");
                }
            }
        }
    }
}
