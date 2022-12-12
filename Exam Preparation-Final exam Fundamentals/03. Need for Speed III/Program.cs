using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> carAndMileague = new Dictionary<string, int>();
            Dictionary<string, int> carAndFuel = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string car=input[0];
                int mileague = int.Parse(input[1]);
                int fuel=int.Parse(input[2]);
                carAndMileague.Add(car, mileague);
                carAndFuel.Add(car, fuel);
            }
            string command;
            while ((command=Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = command.Split(" : ");
                string commandType=cmdArgs[0];
                if (commandType=="Drive")
                {
                    string car = cmdArgs[1];
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);
                    if (carAndFuel[car]>=fuel)
                    {
                        carAndFuel[car] = carAndFuel[car] - fuel;
                        carAndMileague[car] = carAndMileague[car] + distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (carAndMileague[car]>=100000)
                        {
                            carAndMileague.Remove(car);
                            carAndFuel.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (commandType=="Refuel")
                {
                    string car = cmdArgs[1];
                    int fuel = int.Parse(cmdArgs[2]);
                    if (carAndFuel[car] + fuel > 75)
                    {
                        int requiredToFIllITUp = 75 - carAndFuel[car];
                        Console.WriteLine($"{car} refueled with {requiredToFIllITUp} liters");
                        carAndFuel[car] = 75;
                    }
                    else
                    {
                        carAndFuel[car]+=fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if (commandType=="Revert")
                {
                    string car = cmdArgs[1];
                    int kilometres = int.Parse(cmdArgs[2]);
                    carAndMileague[car] = carAndMileague[car] - kilometres;
                    if (carAndMileague[car]<10000)
                    {
                        carAndMileague[car] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometres} kilometers");
                    }
                }
            }
            foreach (var item in carAndMileague)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value} kms, Fuel in the tank: {carAndFuel[item.Key]} lt.");
            }
        }
    }
}
