using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Santa_s_New_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string,int> childrenAndCountOfPresent=new Dictionary<string,int>();
            Dictionary<string,int> childrenAndTypeOfPresent=new Dictionary<string,int>();
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdInfo = command.Split("->");
                string cmdType = cmdInfo[0];
                if (cmdType == "Remove")
                {
                    string childName=cmdInfo[1];
                    childrenAndCountOfPresent.Remove(childName);
                }
                else
                {
                    string typeOfPresent = cmdInfo[1];
                    int countOfPresent = int.Parse(cmdInfo[2]);
                    if (childrenAndCountOfPresent.ContainsKey(cmdType))
                    {
                        childrenAndCountOfPresent[cmdType] += countOfPresent;
                        if (childrenAndTypeOfPresent.ContainsKey(typeOfPresent))
                        {
                            childrenAndTypeOfPresent[typeOfPresent] += countOfPresent;
                        }
                        else
                        {
                            childrenAndTypeOfPresent.Add(typeOfPresent, countOfPresent);
                        }
                    }
                    else
                    {
                        childrenAndCountOfPresent.Add(cmdType, countOfPresent);
                        if (childrenAndTypeOfPresent.ContainsKey(typeOfPresent))
                        {
                            childrenAndTypeOfPresent[typeOfPresent] += countOfPresent;
                        }
                        else
                        {
                            childrenAndTypeOfPresent.Add(typeOfPresent, countOfPresent);
                        }
                    }
                }
            }
            int totalAmountOfPresents = 0;
            foreach (var item in childrenAndTypeOfPresent)
            {
                totalAmountOfPresents += item.Value;
            }
            Console.WriteLine("Children:");
            foreach (var item in childrenAndCountOfPresent.OrderByDescending(u => u.Value).ToDictionary(z => z.Key, y => y.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var item in childrenAndTypeOfPresent.OrderByDescending(x=>totalAmountOfPresents))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
