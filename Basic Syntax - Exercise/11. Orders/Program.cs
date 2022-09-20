using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalsum = 0;
            for (int i = 1; i <= n; i++)
            {
                double pricepercapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                double orderPrice = days * capsuleCount * pricepercapsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                totalsum = totalsum + orderPrice;
            }
            Console.WriteLine($"Total: ${totalsum:f2}");
        }
    }
}
