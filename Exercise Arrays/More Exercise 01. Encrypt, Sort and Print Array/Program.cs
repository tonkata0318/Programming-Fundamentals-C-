using System;
using System.Linq;

namespace More_Exercise_01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vuvejdame
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            int[] namesNumbers = new int[n];
            int sum = 0;
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
                char[] array = names[i].Take(names[i].Length).ToArray();
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j]=='A'||array[j]=='a'||array[j]=='e'||array[j]=='E'||array[j]=='i'||array[j]=='I'||array[j]=='o'||array[j]=='O'||array[j]=='u'||array[j]=='U')
                    {
                        sum += array[j] * array.Length;
                    }
                    else
                    {
                        int temp = array[j];
                        sum += temp / array.Length;
                    }
                }
                namesNumbers[i] = sum;
                sum = 0;
            }
            int smalles = 0;
            for (int i = 0; i < namesNumbers.Length; i++)
            {
                for (int j = i+1; j < namesNumbers.Length; j++)
                {
                    if (namesNumbers[j]<namesNumbers[i])
                    {
                        int temp = namesNumbers[i];
                        namesNumbers[i] = namesNumbers[j];
                        namesNumbers[j] = temp;
                    }
                }
            }
            for (int i = 0; i < namesNumbers.Length; i++)
            {
                Console.WriteLine(namesNumbers[i]);
            }
        }
    }
}
