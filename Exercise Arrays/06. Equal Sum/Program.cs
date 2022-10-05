using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftsum = 0;
            int rigtsum = 0;
            bool flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int curNum = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    rigtsum += nextNumber;
                }
                for (int k = i-1; k >= 0; k--)
                {
                    int previousNumber = numbers[k];
                    leftsum += previousNumber;
                }
                if (leftsum==rigtsum)
                {
                    Console.WriteLine(i);
                    flag = true;
                }
                leftsum = 0;
                rigtsum = 0;
            }
            if (flag!=true)
            {
                Console.WriteLine("no");
            }
        }
    }
}
