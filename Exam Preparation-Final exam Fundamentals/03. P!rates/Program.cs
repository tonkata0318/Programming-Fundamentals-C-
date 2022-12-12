using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, int> cityAndPopulation = new Dictionary<string, int>();
            Dictionary<string, int> cityAndGold = new Dictionary<string, int>();
            while ((command=Console.ReadLine())!="Sail")
            {
                string[] meAndMyCrew = command.Split("||");
                string city=meAndMyCrew[0];
                int population = int.Parse(meAndMyCrew[1]);
                int gold = int.Parse(meAndMyCrew[2]);
                if (cityAndPopulation.ContainsKey(city))
                {
                    cityAndPopulation[city] += population;
                    cityAndGold[city] += gold;
                }
                else
                {
                    cityAndPopulation.Add(city, population);
                    cityAndGold.Add(city, gold);
                }
            }
            string events;
            while ((events=Console.ReadLine())!="End")
            {
                string[] eventCmd = events.Split("=>");
                string eventName = eventCmd[0];
                if (eventName=="Plunder")
                {
                    string town=eventCmd[1];
                    int peopleKilled = int.Parse(eventCmd[2]);
                    int goldTaken = int.Parse(eventCmd[3]);
                    Console.WriteLine($"{town} plundered! {goldTaken} gold stolen, {peopleKilled} citizens killed.");
                    cityAndGold[town]-=goldTaken;
                    cityAndPopulation[town]-=peopleKilled;
                    if (cityAndGold[town] <= 0 || cityAndPopulation[town]<=0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        cityAndGold.Remove(town);
                        cityAndPopulation.Remove(town);
                    }
                }
                else if (eventName=="Prosper")
                {
                    string town = eventCmd[1];
                    int gold = int.Parse(eventCmd[2]);
                    if (gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        cityAndGold[town] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cityAndGold[town]} gold.");
                    }
                }
            }
            if (cityAndPopulation.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityAndPopulation.Count} wealthy settlements to go to:");
                foreach (var item in cityAndPopulation)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value} citizens, Gold: {cityAndGold[item.Key]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
