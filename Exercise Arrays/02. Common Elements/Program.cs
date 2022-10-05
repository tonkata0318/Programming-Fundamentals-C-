using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            string[] temp = new string[firstArray.Length];
            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i]==firstArray[j])
                    {
                        temp[i] = secondArray[i];
                    }
                }
            }
            for (int i = 0; i <=temp.Length-1; i++)
            {
                if (temp[i]!=null)
                {
                    Console.Write(temp[i] + " ");
                }

            }
        } 
    }
}
