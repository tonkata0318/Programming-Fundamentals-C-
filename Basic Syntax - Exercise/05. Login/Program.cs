using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string username = Console.ReadLine();
            string pass = string.Empty;
            char[] charArray = username.ToCharArray();
            for (int i = charArray.Length-1; i > -1; i--)
            {
                pass += charArray[i];
            }
            string password = Console.ReadLine();
            while (password!=pass)
            {
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                if (counter>=3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                password = Console.ReadLine();
            }
            if (counter!=3)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            
        }
    }
}
