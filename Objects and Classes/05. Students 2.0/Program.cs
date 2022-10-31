using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            List<Student> list = new List<Student>();
            while (input!="end")
            {
                string[] inputInfo = input.Split(" ");
                string firstName=inputInfo[0];
                string lastName=inputInfo[1];
                int age = int.Parse(inputInfo[2]);
                string homeTown = inputInfo[3];
                Student student = new Student(firstName,lastName,age,homeTown);
                bool exist = false;
                foreach (var currstudent in list)
                {
                    if (currstudent.FirstName==student.FirstName&&currstudent.LastName==student.LastName)
                    {
                        currstudent.Age = age;
                        currstudent.HomeTown = homeTown;
                        exist = true;
                    }
                }
                if (!exist)
                {
                    list.Add(student);
                }
                input = Console.ReadLine();
            }
            string homeTownNeeded = Console.ReadLine();
            foreach (var student in list)
            {
                if (student.HomeTown==homeTownNeeded)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    public class Student
    {
        public Student(string firstName,string lastName,int age,string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;

        }
        public string FirstName { get; set; }

        public string LastName { get; set; }   

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }

}
