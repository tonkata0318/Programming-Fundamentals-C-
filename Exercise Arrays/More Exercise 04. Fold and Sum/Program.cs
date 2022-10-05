using System;
using System.Linq;

namespace More_Exercise_04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] firstRow = new int[k*2];
            int[] secondRow = new int[k * 2];
            if (k==0)
            {
                secondRow = new int[array.Length];
                firstRow = new int[array.Length];
            }
            int lastindex = 0;
            int temp = 0;
            //if (k==0)
            //{

            //}
            if (k % 2 == 0)
            {
                for (int i = 0; i < k; i++)
                {
                    if (i > 0)
                    {
                        firstRow[i] = array[k - i-1];
                    }
                    else
                    {
                        firstRow[i] = array[i + k - i-1];
                    }
                    lastindex = i + 1;
                }
                for (int i = lastindex; i < 2 * k + k; i++)
                {
                    secondRow[temp] = array[i];
                    temp++;
                }
                for (int i = array.Length - 1; i >= 2 * k + k; i--)
                {
                    firstRow[lastindex] = array[i];
                    lastindex++;
                }
                if (k==0)
                {
                    for (int i = 0; i < 2 * k+array.Length; i++)
                    {
                        int sum = 0;
                        sum = firstRow[i] + secondRow[i];
                        Console.Write($"{sum} ");
                    }
                }
                else
                {
                    for (int i = 0; i < 2 * k; i++)
                    {
                        int sum = 0;
                        sum = firstRow[i] + secondRow[i];
                        Console.Write($"{sum} ");
                    }
                }
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    if (i > 0)
                    {
                        firstRow[i] = array[k -i-1];
                    }
                    else
                    {
                        firstRow[i] = array[k-1];
                    }
                    lastindex = i + 1;
                }
                for (int i = lastindex+1; i <= array.Length-k ; i++)
                {
                    secondRow[temp] = array[i-1];
                    temp++;
                }
                for (int i = array.Length - 1; i >= 2 * k + k; i--)
                {
                    firstRow[lastindex] = array[i];
                    lastindex++;
                }
                for (int i = 0; i < 2 * k; i++)
                {
                    int sum = 0;
                    sum = firstRow[i] + secondRow[i];
                    Console.Write($"{sum} ");
                }
            }
        }
    }
}
