using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> soccer = Console.ReadLine().Split(" ").ToList();
            string command;
            int moves = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                if (soccer.Count<=0)
                {
                    continue;
                }
                string[] cmdArgs = command.Split(" ");
                int firstIndex = int.Parse(cmdArgs[0]);
                int secondIndex = int.Parse(cmdArgs[1]);
                moves++;
                int soccerCount = soccer.Count;
                if (firstIndex == secondIndex || firstIndex < 0 || firstIndex>=soccer.Count || secondIndex > soccer.Count||secondIndex<0)
                {
                    for (int i = soccerCount / 2 ; i <= (soccerCount / 2)+1 ; i++)
                    {
                        soccer.Insert(i, "-" + moves + "a");
                    }
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (soccer[firstIndex] == soccer[secondIndex])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {soccer[firstIndex]}!");
                    soccer.RemoveAt(firstIndex);
                    if (secondIndex==0)
                    {
                        soccer.RemoveAt(secondIndex);
                    }
                    else
                    {
                        soccer.RemoveAt(secondIndex - 1);
                    }
                }
                else if (soccer[firstIndex] != soccer[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }
            }
            if (soccer.Count>0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(String.Join(" ", soccer));
            }
            else
            {
                Console.WriteLine($"You have won in {moves} turns!");
            }
        }
    }
}
