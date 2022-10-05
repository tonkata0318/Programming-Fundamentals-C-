using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] firstArrayLeteer = Console.ReadLine().Split(' ');
                if (i%2==0)
                {
                    firstArray[i] = int.Parse(firstArrayLeteer[1]);
                    secondArray[i] = int.Parse(firstArrayLeteer[0]);
                }
                else
                {
                    firstArray[i] = int.Parse(firstArrayLeteer[0]);
                    secondArray[i] = int.Parse(firstArrayLeteer[1]);
                }
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i]+" ");
            }
            
        }
    }
}
