using System;
using System.Linq;
using System.Collections.Generic;


namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            string command;
            while ((command=Console.ReadLine())!="Craft!")
            {
                string[] cmdArgs = command.Split(" ");
                string firstCommand = cmdArgs[0];
                if (firstCommand=="Collect")
                {
                    string item=cmdArgs[2];
                    if (list.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(item);
                    }
                }
                else if (firstCommand== "Drop")
                {
                    string item = cmdArgs[2];
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                    }
                    else
                    {
                        continue ;
                    }
                }
                else if (firstCommand== "Combine")
                {
                    string[] items = cmdArgs[3].Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];
                    if (list.Contains(oldItem))
                    {
                        int indexofOldItem = list.IndexOf(oldItem);
                        list.Insert(indexofOldItem + 1, newItem);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (firstCommand== "Renew")
                {
                    string item = cmdArgs[2];
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                        list.Add(item);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(String.Join(", ",list));
        }
    }
}
