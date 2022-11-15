using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, string> orders = new Dictionary<string, string>();
            while ((input=Console.ReadLine())!="buy")
            {
                string[] inputInfo = input.Split(" ");
                string productName=inputInfo[0];
                string itemprice=inputInfo[1];
                string itemQuantity=inputInfo[2];
                if (!orders.ContainsKey(productName))
                {
                    orders[productName] = itemprice+":"+itemQuantity;
                }
                else
                {
                    string[] sameOrder=orders[productName].Split(":");
                    double newPrice = double.Parse(sameOrder[1])+double.Parse(itemQuantity);
                    orders[productName] = itemprice + ":" + newPrice;
                }

            }
            foreach (var nvp in orders)
            {
                string[] finalorders = nvp.Value.Split(":");
                double valueprice = double.Parse(finalorders[0]);
                double valuequantity = double.Parse(finalorders[1]);
                Console.WriteLine($"{nvp.Key} -> {valuequantity*valueprice:f2}");
            }
        }
    }
}
