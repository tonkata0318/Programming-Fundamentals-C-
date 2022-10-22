using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string distance;
            int wonBattles = 0;
            while ((distance=Console.ReadLine())!="End of battle"&&energy>0)
            {
                int distanceForEnergy = Math.Abs(int.Parse(distance));
                energy-=distanceForEnergy;
                if (energy<0)
                {
                    break;
                }
                wonBattles++;
                if (wonBattles%3==0)
                {
                    energy += wonBattles;
                }
            }
            if (energy>0)
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
            }
        }
    }
}
