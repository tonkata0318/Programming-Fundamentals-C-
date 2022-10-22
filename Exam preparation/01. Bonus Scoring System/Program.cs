using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numberOfStudents = decimal.Parse(Console.ReadLine());
            decimal numberOfLecture = decimal.Parse(Console.ReadLine());
            decimal additionalBonus = decimal.Parse(Console.ReadLine());
            decimal maxBonus = 0;
            decimal maxLecture = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                decimal attendanceForEachSt = decimal.Parse(Console.ReadLine());
                decimal bonus = attendanceForEachSt / numberOfLecture * (5m + additionalBonus);
                if (bonus>maxBonus)
                {
                    maxBonus = bonus;
                    maxLecture = attendanceForEachSt;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxLecture} lectures.");
        }
    }
}
