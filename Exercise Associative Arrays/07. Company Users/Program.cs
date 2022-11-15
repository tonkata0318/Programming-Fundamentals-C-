using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string,List<string>> comapnmyUsers=new Dictionary<string,List<string>>();
            while((input=Console.ReadLine())!="End")
            {
                string[] cmdArhs=input.Split(" -> ");
                string companyName = cmdArhs[0];
                string id = cmdArhs[1];
                if (!comapnmyUsers.ContainsKey(companyName))
                {
                    comapnmyUsers[companyName] = new List<string>();
                    comapnmyUsers[companyName].Add(id);
                }
                else
                {
                    if (comapnmyUsers[companyName].Contains(id))
                    {

                    }
                    else
                    {
                        comapnmyUsers[companyName].Add(id);
                    }
                }
            }
            foreach (var kvp in comapnmyUsers)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }

            }
        }
    }
}
