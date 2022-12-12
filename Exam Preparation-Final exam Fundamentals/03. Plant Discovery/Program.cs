using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] plantrarity = Console.ReadLine().Split("<->");
                string plant = plantrarity[0];
                int rarity = int.Parse(plantrarity[1]);
                if (!plantRarity.ContainsKey(plant))
                {
                    plantRarity.Add(plant, rarity);
                    plantRating.Add(plant, new List<double>());
                }
                else
                {
                    plantRarity[plant]=rarity;
                }
            }
            string command;
            while ((command=Console.ReadLine())!="Exhibition")
            {
                string[] cmdArgs = command.Split(": ");
                string commandType = cmdArgs[0];
                if (commandType=="Rate")
                {
                    string[] plantAndRating = cmdArgs[1].Split(" - ");
                    string plant = plantAndRating[0];
                    double rating=double.Parse(plantAndRating[1]);
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRating[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }
                else if (commandType=="Update")
                {
                    string[] plantAndNewRarity = cmdArgs[1].Split(" - ");
                    string plant = plantAndNewRarity[0];
                    int rarity=int.Parse(plantAndNewRarity[1]);
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRarity[plant] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandType=="Reset")
                {
                    string plant=cmdArgs[1];
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].RemoveAll(x=>x>0);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plantRarity)
            {
                if (plantRating[item.Key].Count>0)
                {
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {(plantRating[item.Key].Average()):f2}");
                }
                else
                {
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: 0.00");
                }
            }
        }
    }
}
