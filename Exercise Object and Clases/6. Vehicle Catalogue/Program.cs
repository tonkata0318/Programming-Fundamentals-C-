using System;
using System.Collections.Generic;

namespace _6._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<VenchileCatalogue> catalog=new List<VenchileCatalogue>();
            double averageCarsHorse = 0;
            double averageTrucksHorse = 0;
            int trucksCount = 0;
            int carsCount = 0;
            while ((input=Console.ReadLine())!="End")
            {
                string[] inputInfo = input.Split(" ");
                string typeOfVenchile=inputInfo[0];
                string model = inputInfo[1];
                string colour = inputInfo[2];
                int horsePower = int.Parse(inputInfo[3]);
                VenchileCatalogue venchile=new VenchileCatalogue(typeOfVenchile, model, colour, horsePower);
                catalog.Add(venchile);
            }
            string command;
            while ((command=Console.ReadLine())!= "Close the Catalogue")
            {
                foreach (var venchile in catalog)
                {
                    if (venchile.Model==command)
                    {
                        Console.WriteLine($"Type: {char.ToUpper(venchile.TypeOfVenchelie[0])+venchile.TypeOfVenchelie.Substring(1)}");
                        Console.WriteLine($"Model: {venchile.Model}");
                        Console.WriteLine($"Color: {venchile.Colour}");
                        Console.WriteLine($"Horsepower: {venchile.HorsePowerOfVenchile}");
                    }
                }
            }
            foreach (var venchile in catalog)
            {
                if (venchile.TypeOfVenchelie=="truck")
                {
                    averageTrucksHorse += venchile.HorsePowerOfVenchile;
                    trucksCount++;
                }
                else if (venchile.TypeOfVenchelie=="car")
                {
                    averageCarsHorse += venchile.HorsePowerOfVenchile;
                    carsCount++;
                }
            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarsHorse/carsCount:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorse/trucksCount:f2}.");
        }
    }
    public class VenchileCatalogue
    {
        public VenchileCatalogue(string typeOfVenchelie, string model, string colour, int horsePowerOfVenchile)
        {
            TypeOfVenchelie = typeOfVenchelie;
            Model = model;
            Colour = colour;
            HorsePowerOfVenchile = horsePowerOfVenchile;
        }

        public string TypeOfVenchelie { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public int HorsePowerOfVenchile { get; set; }

        
    }
}
