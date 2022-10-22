using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            string[] rooms = Console.ReadLine().Split("|").ToArray();
            bool survived=false;
            int bitcoins = 0;
            while (health>0)
            {
                for (int i = 0; i < rooms.Length; i++)
                {
                    string[] cmdArgs = rooms[i].Split(" ");
                    if (cmdArgs[0]=="potion")
                    {
                        int numberHealed = int.Parse(cmdArgs[1]);
                        int totalhealth = health + numberHealed;
                        if (totalhealth>100)
                        {
                            totalhealth = 100;
                            Console.WriteLine($"You healed for {100-health} hp.");
                            Console.WriteLine($"Current health: {totalhealth} hp.");
                            health = 100;
                        }
                        else
                        {
                            health += numberHealed;
                            Console.WriteLine($"You healed for {numberHealed} hp.");
                            Console.WriteLine($"Current health: {totalhealth} hp.");
                        }
                    }
                    else if (cmdArgs[0]=="chest")
                    {
                        int amount = int.Parse(cmdArgs[1]);
                        bitcoins += amount;
                        Console.WriteLine($"You found {amount} bitcoins.");
                    }
                    else
                    {
                        int atackOfMonster = int.Parse(cmdArgs[1]);
                        health = health - atackOfMonster;
                        if (health>0)
                        {
                            Console.WriteLine($"You slayed {cmdArgs[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {cmdArgs[0]}.");
                            Console.WriteLine($"Best room: {i+1}");
                            break;
                        }
                    }
                }
                if (health>0)
                {
                    survived = true;
                    break;
                }
            }
            if (survived)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
