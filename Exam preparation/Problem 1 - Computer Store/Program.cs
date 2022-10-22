using System;
using System.Diagnostics;

namespace Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            decimal total = 0m;
            bool isSpecial = false;
            while ((command=Console.ReadLine())!="special"&& command !="regular")
            {
                decimal prices = decimal.Parse(command);
                if (prices>=0)
                {
                    total += prices;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

            }
            if (command=="special")
            {
                isSpecial = true;
            }
            if (total==0m)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (isSpecial)
            {
                decimal taxes = total * 0.20m;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                decimal discount = (total + taxes) * 0.10m;
                Console.WriteLine($"Total price: {(total+taxes)-discount:f2}$");
            }
            else if (isSpecial==false)
            {
                decimal taxes = total * 0.20m;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {total:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {total + taxes:f2}$");
            }
        }
    }
}
