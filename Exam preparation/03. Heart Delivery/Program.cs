using System;
using System.Linq;
using System.Collections.Generic;


namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string command;
            int lastposition = 0;
            while ((command=Console.ReadLine())!="Love!")
            {
                string[] cmdArgs = command.Split(" ");
                int moves = int.Parse(cmdArgs[1]);
                moves = moves + lastposition;
                if (moves>=houses.Count)
                {
                    moves = 0;
                    lastposition = 0;
                }
                if (cmdArgs[0]=="Jump")
                {
                    houses[moves] = houses[moves]-2;
                    if (houses[moves]==0)
                    {
                        Console.WriteLine($"Place {moves} has Valentine's day.");
                    }
                    else if (houses[moves]<0)
                    {
                        Console.WriteLine($"Place {moves} already had Valentine's day.");
                    }
                }
                lastposition = moves;
            }
            Console.WriteLine($"Cupid's last position was {lastposition}.");
            if (houses.All(x=>x==0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int count = 0;
                for (int i = 0; i < houses.Count; i++)
                {
                    if (houses[i]>0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}
