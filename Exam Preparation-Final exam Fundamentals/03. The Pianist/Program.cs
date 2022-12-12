using System;
using System.Collections.Generic;
using System.IO;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var piesecInfo = new Dictionary<string, string>();
            var composerInfo=new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] piecesInfo = Console.ReadLine().Split("|");
                piesecInfo[piecesInfo[0]] = piecesInfo[2];
                composerInfo[piecesInfo[0]] = piecesInfo[1];
            }
            string command;
            while ((command=Console.ReadLine())!="Stop")
            {
                string[] cmdInfo = command.Split("|");
                string commandName=cmdInfo[0];
                if (commandName=="Add")
                {
                    string pieses=cmdInfo[1];
                    string compose = cmdInfo[2];
                    string key = cmdInfo[3];
                    if (piesecInfo.ContainsKey(pieses))
                    {
                        Console.WriteLine($"{pieses} is already in the collection!");
                    }
                    else
                    {
                        piesecInfo.Add(pieses, key);
                        composerInfo.Add(pieses, compose);
                        Console.WriteLine($"{pieses} by {compose} in {key} added to the collection!");
                    }
                }
                else if (commandName=="Remove")
                {
                    string pieses = cmdInfo[1];
                    if (piesecInfo.ContainsKey(pieses))
                    {
                        piesecInfo.Remove(pieses);
                        composerInfo.Remove(pieses);
                        Console.WriteLine($"Successfully removed {pieses}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieses} does not exist in the collection.");
                    }
                }
                else if (commandName=="ChangeKey")
                {
                    string pieses = cmdInfo[1];
                    string newKey = cmdInfo[2];
                    if (piesecInfo.ContainsKey(pieses))
                    {
                        piesecInfo[pieses]=newKey;
                        Console.WriteLine($"Changed the key of {pieses} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieses} does not exist in the collection.");
                    }
                }
            }
            foreach (var item in piesecInfo)
            {
                Console.WriteLine($"{item.Key} -> Composer: {composerInfo[item.Key]}, Key: {item.Value}");
            }
        }
    }
}
