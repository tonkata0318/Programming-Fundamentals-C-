using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggest = 0;
            string biggestName = string.Empty;
            for (int i = 0; i < n; i++)
            {
                    string midel = Console.ReadLine();
                    float radius = float.Parse(Console.ReadLine());
                    int height = int.Parse(Console.ReadLine());
                    double volume = Math.PI * Math.Pow(radius,2) * height;
                    if (volume>biggest)
                    {
                        biggest = volume;
                        biggestName = midel;
                    }
            }
            Console.WriteLine(biggestName);
        }
    }
}
