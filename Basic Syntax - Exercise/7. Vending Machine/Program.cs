using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string input = Console.ReadLine();
            while (input!="Start")
            {
                double number = double.Parse(input);
                if (number==0.1||number==0.2||number==0.5||number==1||number==2)
                {
                    sum = sum + number;
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Cannot accept {number}");
                    input = Console.ReadLine();
                }
            }
            input = Console.ReadLine();
            double priceforNuts = 2.0;
            double priceforWater = 0.7;
            double priceforCrisps = 1.5;
            double priceforSoda = 0.8;
            double priceforCoke = 1.0;
            while (input!="End")
            {
                if (input=="Nuts")
                {
                    if (sum>=priceforNuts)
                    {
                        Console.WriteLine("Purchased nuts");
                        sum = sum - priceforNuts;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input=="Water")
                {
                    if (sum >= priceforWater)
                    {
                        Console.WriteLine("Purchased water");
                        sum = sum - priceforWater;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input=="Crisps")
                {
                    if (sum >= priceforCrisps)
                    {
                        Console.WriteLine("Purchased crisps");
                        sum = sum - priceforCrisps;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input=="Soda")
                {
                    if (sum >= priceforSoda)
                    {
                        Console.WriteLine("Purchased soda");
                        sum = sum - priceforSoda;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input=="Coke")
                {
                    if (sum >= priceforCoke)
                    {
                        Console.WriteLine("Purchased coke");
                        sum = sum - priceforCoke;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {Math.Abs(sum):f2}");
        }
    }
}
