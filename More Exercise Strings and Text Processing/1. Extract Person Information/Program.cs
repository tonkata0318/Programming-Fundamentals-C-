using System;
using System.Collections.Generic;

namespace _1._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string name = string.Empty;
                for (int j = 0; j < info.Length; j++)
                {
                    if (info[j].Contains("@") && info[j].Contains("|"))
                    {
                        name = info[j].Substring(1, info[j].Length - 2);
                        dic[name] = "";
                    }
                    if (info[j].Contains("#") && info[j].Contains("*"))
                    {
                        dic[name] = info[j].Substring(1, info[j].Length - 2);
                    }
                }
               
            }
            foreach (var name in dic)
            {
                Console.WriteLine($"{name.Key} is {name.Value} years old.");
            }
        }
    }
}
