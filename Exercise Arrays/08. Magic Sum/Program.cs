using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int  i = 0;  i <numbers.Length;  i++)
            {
                int curNum = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int nexNum = numbers[j];
                    if (curNum+nexNum==magicSum)
                    {
                        Console.Write($"{curNum} {nexNum}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
