using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfpeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string theDayOfWeekTheyWillStay = Console.ReadLine();
            double totalprice = 0;
            double priceforOnePerson = 0;
            switch (theDayOfWeekTheyWillStay)
            {
                case "Friday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            priceforOnePerson = 8.45;
                            break;
                        case "Business":
                            priceforOnePerson = 10.90;
                            break;
                        case "Regular":
                            priceforOnePerson = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            priceforOnePerson = 9.80;
                            break;
                        case "Business":
                            priceforOnePerson = 15.60;
                            break;
                        case "Regular":
                            priceforOnePerson = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            priceforOnePerson = 10.46;
                            break;
                        case "Business":
                            priceforOnePerson = 16;
                            break;
                        case "Regular":
                            priceforOnePerson = 22.50;
                            break;
                    }
                    break;
            }
            totalprice = countOfpeople * priceforOnePerson;
            if (countOfpeople>=30&&typeOfGroup=="Students")
            {
                totalprice = totalprice * 0.85;
            }
            if (typeOfGroup=="Business"&&countOfpeople>=100)
            {
                totalprice = totalprice - (10 * priceforOnePerson);
            }
            if (typeOfGroup=="Regular" && (countOfpeople>=10&&countOfpeople<=20) )
            {
                totalprice = totalprice * 0.95;
            }
            Console.WriteLine($"Total price: {totalprice:f2}");
        }
    }
}
