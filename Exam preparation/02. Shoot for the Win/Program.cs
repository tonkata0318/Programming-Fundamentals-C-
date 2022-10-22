using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command;
            int countShootTargets = 0;
            while((command=Console.ReadLine())!="End")
            {
                string[] cmdArgs = command.Split(" ");
                int index = int.Parse(cmdArgs[0]);
                if (index<0||index>=array.Length)
                {
                    continue;
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i]==-1)
                        {
                            continue;
                        }
                        if (array[i] > array[index])
                        {
                            array[i] = array[i] - array[index];
                        }
                        else if (array[i] < array[index]||i==index-1||i==index+1)
                        {
                            array[i] = array[i] + array[index];
                        }
                    }
                    array[index] = -1;
                    countShootTargets++;
                }
            }
            Console.WriteLine($"Shot targets: {countShootTargets} -> {string.Join(" ",array)}");
        }
    }
}
