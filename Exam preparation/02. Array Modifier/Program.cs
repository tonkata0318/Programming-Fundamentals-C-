using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] cmdArggs = command.Split(" ");
                string cmdCommand = cmdArggs[0];
                if (cmdCommand=="swap")
                {
                    SwapArray(array, cmdArggs);
                }
                else if (cmdCommand=="multiply")
                {
                    MultiplyArray(array, cmdArggs);
                }
                else if (cmdCommand=="decrease")
                {
                    DecreaseMethod(array);
                }
            }
            Console.WriteLine(String.Join(", ",array));
        }

        static int[] DecreaseMethod(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]--;
            }
            return array;
        }

        static int[] MultiplyArray(int[] array, string[] cmdArggs)
        {
            int firstindex = int.Parse(cmdArggs[1]);
            int secondIndex = int.Parse(cmdArggs[2]);
            int multiplyedValue = array[firstindex] * array[secondIndex];
            array[firstindex] = multiplyedValue;
            return array;
        }

        static int[] SwapArray(int[] array, string[] cmdArggs)
        {
            int firstIndex = int.Parse(cmdArggs[1]);
            int secondIndex = int.Parse(cmdArggs[2]);
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
            return array;
        }
    }
}
