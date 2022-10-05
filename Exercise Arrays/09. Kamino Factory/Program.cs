using System;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lentghOfSequances = int.Parse(Console.ReadLine());
            string command;
            int subsequnces = 0;
            int maxsequnces = 0;
            int indexofSubsequnces = 0;
            int sum = 0;
            int mininmumLentghSubqences = 0;
            int maxSum = 0;
            string[] copyaArray = new string[lentghOfSequances];
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                string[] cmdArgs = command
                   .Split("!", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < cmdArgs.Length; i++)
                {
                    int dnaNumber = int.Parse(cmdArgs[i]);
                    if (i == cmdArgs.Length - 1)
                    {
                        if (dnaNumber==1)
                        {
                            sum += dnaNumber;
                            if (sum>maxSum)
                            {
                                maxSum = sum;
                            }
                            sum = 0;
                            subsequnces = 0;
                        }
                        else
                        {
                            sum = 0;
                            subsequnces = 0;
                            continue;
                        }
                        continue;
                    }
                    if (dnaNumber!=1)
                    {
                        continue;
                    }
                    int nextdnaNumber = int.Parse(cmdArgs[i + 1]);
                    sum += dnaNumber;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    
                    if (dnaNumber!=nextdnaNumber)
                    {
                        continue;
                    }
                    subsequnces++;
                    indexofSubsequnces = i;
                    if (subsequnces>=maxsequnces)
                    {
                        maxsequnces = subsequnces;
                        if (indexofSubsequnces==mininmumLentghSubqences)
                        {
                            mininmumLentghSubqences = indexofSubsequnces;
                            if (maxSum>sum)
                            {
                                copyaArray = cmdArgs;
                            }
                        }
                        else
                        {
                            copyaArray = cmdArgs;
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {mininmumLentghSubqences} with sum: {maxSum}.");
            Console.Write(String.Join(' ',copyaArray));
        }
    }
}
