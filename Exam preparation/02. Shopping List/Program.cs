using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> grocery = Console.ReadLine().Split("!").ToList();
            string command;
            while ((command=Console.ReadLine())!="Go Shopping!")
            {
                string[] cmdArgs = command.Split(" ");
                string firstCommand = cmdArgs[0];
                if (firstCommand== "Urgent")
                {
                    string product=cmdArgs[1];
                    if (grocery.Contains(product))
                    {
                        continue;
                    }
                    else
                    {
                        grocery.Insert(0, product);
                    }

                }
                else if (firstCommand== "Unnecessary")
                {
                    string product = cmdArgs[1];
                    if (grocery.Contains(product))
                    {
                        grocery.Remove(product);
                    }
                    else
                    {
                        continue ;
                    }
                }
                else if (firstCommand== "Correct")
                {
                    string oldname=cmdArgs[1];
                    string newName = cmdArgs[2];
                    if (grocery.Contains(oldname))
                    {
                        int index = 0;
                        for (int i = 0; i < grocery.Count; i++)
                        {
                            if (grocery[i]==oldname)
                            {
                                index = i;
                                break;
                            }
                        }
                        grocery.Remove(oldname);
                        grocery.Insert(index, newName);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (firstCommand== "Rearrange")
                {
                    string prodcut = cmdArgs[0];
                    if (grocery.Contains(prodcut))
                    {
                        grocery.Remove(prodcut);
                        grocery.Add(prodcut);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(String.Join(", ",grocery));
        }
    }
}
