using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostgameCOunt = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int countheadsettrashes = 0;
            int mousetrashes = 0;
            int keyboardtrashes = 0;
            int despalytrashes = 0;
            for (int i = 1; i <=lostgameCOunt; i++)
            {
                if (i%2==0)
                {
                    countheadsettrashes++;
                }
                if (i%3==0)
                {
                    mousetrashes++;
                }
                if (i%2==0&&i%3==0)
                {
                    keyboardtrashes++;
                }
                if (keyboardtrashes%2==0&&i%2==0&&i%3==0)
                {
                    despalytrashes++;
                }
            }
            double allprice = countheadsettrashes * headsetPrice + mousetrashes * mousePrice + keyboardtrashes * keyboardPrice + despalytrashes * displayPrice;
            Console.WriteLine($"Rage expenses: {allprice:f2} lv.");

        }
    }
}
