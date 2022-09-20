using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyJohnHas = double.Parse(Console.ReadLine());
            int countofStudents = int.Parse(Console.ReadLine());
            double priceoflightSabersForSingleSaber = double.Parse(Console.ReadLine());
            double priceofrobesforSinglerobes = double.Parse(Console.ReadLine());
            double priceofBeltsForSingleBelts = double.Parse(Console.ReadLine());
            double freebelts = countofStudents / 6;
            double priceforsaberCombine = 0;
            priceforsaberCombine = (countofStudents + countofStudents * 0.10);
            double priceforSaber = Math.Ceiling(priceforsaberCombine);
            priceforSaber = priceoflightSabersForSingleSaber * priceforSaber;
            double priceforrobes = priceofrobesforSinglerobes * countofStudents;
            double priceforbelts= priceofBeltsForSingleBelts * (countofStudents - freebelts); ;
            double priceForEquiments = priceforbelts + priceforrobes + priceforSaber;
            if (priceForEquiments>moneyJohnHas)
            {
                Console.WriteLine($" John will need {priceForEquiments-moneyJohnHas:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {priceForEquiments:f2}lv.");
            }
        }
    }
}
