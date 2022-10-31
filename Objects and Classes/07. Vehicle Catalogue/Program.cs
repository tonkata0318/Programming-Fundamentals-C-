using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();
            while (input != "end")
            {
                string[] inputInfo = input.Split("/");
                string type = inputInfo[0];
                string brand = inputInfo[1];
                string model = inputInfo[2];
                int value = int.Parse(inputInfo[3]);
                if (type == "Car")
                {
                    Car car = new Car(brand,model,value);
                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand,model,value);
                    catalog.Trucks.Add(truck);
                }
                input = Console.ReadLine();
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(x=>x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
        public class Truck
        {
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }

        }
        public class Car
        {
            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
            public string Brand { get; set; }

            public string Model { set; get; }

            public int HorsePower { get; set; }

        }
        public class Catalog
        {
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

            public List<Truck> Trucks { get; set; }

            public List<Car> Cars { get; set; }
        }
    }
}
