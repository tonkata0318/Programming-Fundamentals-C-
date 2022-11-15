using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string,List<string>> keyValuePairs = new Dictionary<string,List<string>>();
            while((input=Console.ReadLine())!="end")
            {
                string[] inputInfo=input.Split(" : ");
                string couseName=inputInfo[0];
                string name = inputInfo[1];
                if (!keyValuePairs.ContainsKey(couseName))
                {
                    keyValuePairs[couseName] = new List<string>();
                    keyValuePairs[couseName].Add(name);
                }
                else
                {
                    keyValuePairs[couseName].Add(name);
                }
            }
            foreach (var kvp in keyValuePairs)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }

            }
        }
    }
}
