using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sequances = 1;
            int numberToPrint = 0;
            int maxsequances = 1;
            int sequncasForI = 0;
            for (int i = 0; i < numbers.Length; i+=sequncasForI)
            {
                int curNum = numbers[i];
                for (int j = i+1;  j < numbers.Length;  j++)
                {
                    int nextNum = numbers[j];
                    if (curNum==nextNum)
                    {
                        sequances++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequances>maxsequances)
                {
                    maxsequances = sequances;
                    numberToPrint = curNum;
                }
                if (sequances>0)
                {
                    sequncasForI = sequances;
                    sequances = 1;
                }
                else
                {
                    sequances = 0;
                }
            }
            for (int i = 0; i < maxsequances; i++)
            {
                Console.Write(numberToPrint+" ");
            }
        }
    }
}
