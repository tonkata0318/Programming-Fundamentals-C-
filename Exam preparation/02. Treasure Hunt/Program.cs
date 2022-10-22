using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> loots = Console.ReadLine().Split("|").ToList();
            string command;
            double averageTreasureGain = 0;
            while ((command=Console.ReadLine())!= "Yohoho!")
            {
                string[] cmdArgs = command.Split(" ");
                string firstCommand = cmdArgs[0];
                if (firstCommand=="Loot")
                {
                    for (int i = 1; i <= cmdArgs.Length-1; i++)
                    {
                        string item = cmdArgs[i];
                        if (loots.Contains(item))
                        {
                            
                        }
                        else
                        {
                            loots.Insert(0,item);
                        }
                    }
                }
                else if (firstCommand=="Drop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index<0||index>=loots.Count)
                    {
                        continue;
                    }
                    else
                    {
                        string itemAtIndex=loots[index];
                        loots.RemoveAt(index);
                        loots.Add(itemAtIndex);
                    }
                }
                else if (firstCommand=="Steal")
                {
                    int stealCount = int.Parse(cmdArgs[1]);
                    //string[] stealedItems = new string[stealCount];
                    int indexStealItems = 0;
                    if (stealCount>loots.Count)
                    {
                        string[] stealedItems = new string[loots.Count];
                        for (int i = 0; i < loots.Count; i++)
                        {
                            stealedItems[indexStealItems] = loots[i];
                            loots.Remove(loots[i]);
                            i--;
                            indexStealItems++;
                        }
                        Console.WriteLine(string.Join(", ", stealedItems));
                    }
                    else
                    {
                        string[] stealedItems = new string[stealCount];
                        for (int i = loots.Count - stealCount; i < loots.Count; i++)
                        {
                            stealedItems[indexStealItems] = loots[i];
                            loots.Remove(loots[i]);
                            i--;
                            indexStealItems++;
                        }
                        Console.WriteLine(string.Join(", ", stealedItems));
                    }

                }
            }
            if (loots.Count>0)
            {
                for (int i = 0; i < loots.Count; i++)
                {
                    string loot = loots[i];
                    averageTreasureGain += loot.Length;
                }
                averageTreasureGain /= loots.Count;
                Console.WriteLine($"Average treasure gain: {averageTreasureGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
