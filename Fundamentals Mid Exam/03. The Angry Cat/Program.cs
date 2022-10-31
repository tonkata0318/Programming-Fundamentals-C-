using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _03._The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string cheapOrExpensive = Console.ReadLine();
            double priceRatingLeft = 0;
            double priceRatingRight = 0;
            for (int i = 0; i <= entryPoint-1; i++)
            {
                if (cheapOrExpensive=="cheap")
                {
                    if (items[i] < items[entryPoint])
                    {
                        priceRatingLeft += items[i];
                    }
                }
                else if (cheapOrExpensive=="expensive")
                {
                    if (items[i] >= items[entryPoint])
                    {
                        priceRatingLeft += items[i];
                    }
                }
            }
            for (int i = entryPoint+1; i < items.Count; i++)
            {
                if (cheapOrExpensive == "cheap")
                {
                    if (items[i] < items[entryPoint])
                    {
                        priceRatingRight += items[i];
                    }
                }
                else if (cheapOrExpensive == "expensive")
                {
                    if (items[i] >= items[entryPoint])
                    {
                        priceRatingRight += items[i];
                    }
                }
            }
            if (priceRatingRight==priceRatingLeft)
            {
                Console.WriteLine($"Left - {priceRatingLeft}");
            }
            else if (priceRatingRight>priceRatingLeft)
            {
                Console.WriteLine($"Right - {priceRatingRight}");
            }
            else if (priceRatingLeft>priceRatingRight)
            {
                Console.WriteLine($"Left - {priceRatingLeft}");
            }
        }
    }
}
