using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> students = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students[name] = grade;
                }
                else
                {
                    double oldgrade = students[name];
                    students[name] = (oldgrade+grade)/2;
                }

            }
            foreach (var vpn in students)
            {
                if (vpn.Value>=4.50)
                {
                    Console.WriteLine($"{vpn.Key} -> {vpn.Value:f2}");
                }

            }
        }
    }
}
