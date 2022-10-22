using System;

namespace Problem_1___SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeTake = int.Parse(Console.ReadLine());
            int secondEmpoyeeTake = int.Parse(Console.ReadLine());
            int thirdEmployeeTake = int.Parse(Console.ReadLine());
            int students=int.Parse(Console.ReadLine());
            int studentsAnswered = 0;
            int hours = 0;
            while (students>studentsAnswered)
            {
                studentsAnswered += firstEmployeeTake + secondEmpoyeeTake + thirdEmployeeTake;
                hours++;
                if (hours%4==0)
                {
                    hours++;
                    continue;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
