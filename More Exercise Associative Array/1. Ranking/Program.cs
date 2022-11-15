using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1;
            Dictionary<string,string> exams=new Dictionary<string, string>();
            while ((input1=Console.ReadLine())!= "end of contests")
            {
                string[] input1Info = input1.Split(":");
                string courseName = input1Info[0];
                string codeForPass = input1Info[1];
                if (!exams.ContainsKey(courseName))
                {
                    exams[courseName] = codeForPass;
                }
            }
            string input2;
            Dictionary<string, List<string>> studentsInExam = new Dictionary<string,List<string>>();
            while ((input2=Console.ReadLine())!="end of submissions")
            {
                string[] input2Info = input2.Split("=>");
                string nameOfStudent=input2Info[2];
                string enteredPass = input2Info[1];
                string courseName = input2Info[0];
                double points = double.Parse(input2Info[3]);
                bool create = false;
                if (!studentsInExam.ContainsKey(nameOfStudent)||studentsInExam.ContainsKey(nameOfStudent))
                {
                    foreach (var exma in exams)
                    {
                        if (exma.Value==enteredPass&&exma.Key==courseName)
                        {
                            if (studentsInExam.ContainsKey(nameOfStudent) && !studentsInExam[nameOfStudent].Contains(nameOfStudent))
                            {
                                string[] array = studentsInExam[nameOfStudent].ToArray();
                                double oldPoints = double.Parse(array[1]);
                                if (points>oldPoints)
                                {
                                    studentsInExam[nameOfStudent].Remove(courseName+":"+points);
                                    studentsInExam[nameOfStudent].Add(courseName + ":" + points);
                                }
                            }
                            create = true;
                        }
                    }
                    if (create)
                    {
                        studentsInExam[nameOfStudent] = new List<string>();
                        studentsInExam[nameOfStudent].Add(courseName + ":" + points);
                    }
                }
            }
            //Console.WriteLine($"Best candidate is {} with total {} points.);
        }

    }
}
