using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] SecondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            bool isNot = false;
            int sum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i]!=SecondArray[i])
                {
                    index = i;
                    isNot = true;
                    break;
                }
                else
                {
                    sum = sum + firstArray[i];
                }
            }
            if (isNot)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
