using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShit = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship=Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHPofSection = int.Parse(Console.ReadLine());
            string command;
            bool staleMate = true;
            while ((command=Console.ReadLine())!="Retire")
            {
                string[] cmdArgs = command.Split(" ");
                if (cmdArgs[0]=="Fire")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int dmg = int.Parse(cmdArgs[2]);
                    if (index<0||index>=warship.Count)
                    {
                        continue;
                    }
                    else
                    {
                        warship[index] -= dmg;
                        if (warship[index]<=0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            staleMate = false;
                            break;
                        }
                    }
                }
                else if (cmdArgs[0]=="Defend")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int dmg = int.Parse(cmdArgs[3]);
                    if (startIndex < 0 || startIndex >=pirateShit.Count||endIndex>pirateShit.Count||endIndex<0)
                    {
                        continue;
                    }
                    else
                    {
                        if (startIndex<endIndex)
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                pirateShit[i] -= dmg;
                                if (pirateShit[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    staleMate=false;
                                    break;
                                }
                            }
                        }
                        else if (endIndex<startIndex)
                        {
                            for (int i = startIndex; i >= endIndex; i--)
                            {
                                pirateShit[i] -= dmg;
                                if (pirateShit[i]<=0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    staleMate = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (cmdArgs[0]=="Repair")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int amount = int.Parse(cmdArgs[2]);
                    if (index<0||index>=pirateShit.Count)
                    {
                        continue;
                    }
                    else
                    {
                        pirateShit[index] = pirateShit[index] + amount;
                        if (pirateShit[index]>maxHPofSection)
                        {
                            pirateShit[index] = maxHPofSection;
                        }
                    }
                }
                else if (cmdArgs[0]=="Status")
                {
                    double needRepair = maxHPofSection * 0.20;
                    int countofRepair = 0;
                    for (int i = 0; i < pirateShit.Count; i++)
                    {
                        if (pirateShit[i]<needRepair)
                        {
                            countofRepair++;
                        }
                    }
                    Console.WriteLine($"{countofRepair} sections need repair.");
                }
            }
            if (staleMate)
            {
                double pirateShipSum = 0;
                for (int i = 0; i < pirateShit.Count; i++)
                {
                    pirateShipSum += pirateShit[i];
                }
                double washipsum = 0;
                for (int i = 0; i < warship.Count; i++)
                {
                    washipsum += warship[i];
                }
                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {washipsum}");
            }
        }
    }
}
