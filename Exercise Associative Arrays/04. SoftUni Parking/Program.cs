using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<string, string> parkSlots = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputArgs = input.Split(" ");
                string command = inputArgs[0];
                string username=inputArgs[1];
                if (command=="register")
                {
                    string licenseplateNumber=inputArgs[2];
                    if (parkSlots.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseplateNumber}");
                    }
                    else
                    {
                        parkSlots.Add(username, licenseplateNumber);
                        Console.WriteLine($"{username} registered {licenseplateNumber} successfully");
                    }
                }
                else if (command=="unregister")
                {
                    if (!parkSlots.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkSlots.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var vpn in parkSlots)
            {
                Console.WriteLine($"{vpn.Key} => {vpn.Value}");
            }
        }
    }
}
