using System;

namespace More_Exercise_1.Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i <=numbers.Length-1; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <=3; i++)
            {
                for (int j = 0; j <=numbers.Length-2; j++)
                {
                    if (numbers[j]<numbers[j+1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i <=numbers.Length-1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= n - 1; j++)
            //    {
            //        if (a[j] > a[j + 1])
            //        {
            //            int temp = a[j];
            //            a[j] = a[j + 1];
            //            a[j + 1] = temp;
            //        }
            //    }
            //}
        }
    }
}
