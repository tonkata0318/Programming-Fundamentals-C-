using System;

namespace More_Exercise_03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string gameCommand = Console.ReadLine();
            double totalSpent = 0;
            while (gameCommand!="Game Time")
            {
                if (money<=0)
                {
                    Console.WriteLine("out of money");
                    break;
                }
                switch (gameCommand)
                {
                    case "OutFall 4":
                        if (money<39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money = money - 39.99;
                            totalSpent = totalSpent + 39.99;
                            Console.WriteLine($"Bought {gameCommand}");
                        }
                        break;
                    case "CS: OG":
                        if (money < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money = money - 15.99;
                            totalSpent = totalSpent + 15.99;
                            Console.WriteLine($"Bought {gameCommand}");
                        }
                        break;
                    case "Zplinter Zell":
                        if (money < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money = money - 19.99;
                            totalSpent = totalSpent + 19.99;
                            Console.WriteLine($"Bought {gameCommand}");
                        }
                        break;
                    case "Honored 2":
                        if (money < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money = money - 59.99;
                            totalSpent = totalSpent + 59.99;
                            Console.WriteLine($"Bought {gameCommand}");
                        }
                        break;
                    case "RoverWatch":
                        if (money < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money = money - 29.99;
                            totalSpent = totalSpent + 29.99;
                            Console.WriteLine($"Bought {gameCommand}");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (money < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            money = money - 39.99;
                            totalSpent = totalSpent + 39.99;
                            Console.WriteLine($"Bought {gameCommand}");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                gameCommand = Console.ReadLine();
            }
            if (money>0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${money:F2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
