using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ").ToArray();
            string command;
            int countBlacklisted = 0;
            int lost = 0;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] cmdArgs = command.Split(" ");
                string firstCommand = cmdArgs[0];
                if (firstCommand == "Blacklist")
                {
                    string name = cmdArgs[1];
                    bool isFound = false;
                    int indexName = -1;
                    for (int i = 0; i < usernames.Length; i++)
                    {
                        if (usernames[i] == name)
                        {
                            isFound = true;
                            indexName = i;
                        }
                    }
                    if (isFound)
                    {
                        usernames[indexName] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                        countBlacklisted++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (firstCommand == "Error")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= usernames.Length || usernames[index] == "Blacklisted" || usernames[index] == "Lost")
                    {
                        continue;
                    }
                    string name = usernames[index];
                    usernames[index] = "Lost";
                    Console.WriteLine($"{name} was lost due to an error.");
                    lost++;
                }
                else if (firstCommand == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = cmdArgs[2];
                    if (index < 0 || index >= usernames.Length)
                    {
                        continue;
                    }
                    string curName = usernames[index];
                    usernames[index] = newName;
                    Console.WriteLine($"{curName} changed his username to {newName}.");
                }
            }
            Console.WriteLine($"Blacklisted names: {countBlacklisted}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(String.Join(" ", usernames));
        }
    }
}
