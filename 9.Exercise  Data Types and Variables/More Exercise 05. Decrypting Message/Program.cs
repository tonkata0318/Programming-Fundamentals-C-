using System;

namespace More_Exercise_05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 1; i <=n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                message += (char)(ch+key);
            }
            Console.WriteLine(message);
        }
    }
}
