using System;
using System.Text;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder activationKey = new StringBuilder(Console.ReadLine());
            string command;
            while ((command=Console.ReadLine())!="Generate")
            {
                string[] cmdArgs = command.Split(">>>");
                string commandType=cmdArgs[0];
                if (commandType=="Contains")
                {
                    string substring = cmdArgs[1];
                    if (activationKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (commandType=="Flip")
                {
                    string type=cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);
                    if (type=="Upper")
                    {
                        string substring=activationKey.ToString().Substring(startIndex, endIndex-startIndex);
                        activationKey.Remove(startIndex, endIndex - startIndex);
                        substring = substring.ToUpper();
                        activationKey.Insert(startIndex,substring);
                        Console.WriteLine(activationKey);
                    }
                    else if (type=="Lower")
                    {
                        string substring = activationKey.ToString().Substring(startIndex, endIndex - startIndex);
                        activationKey.Remove(startIndex, endIndex - startIndex);
                        substring = substring.ToLower();
                        activationKey.Insert(startIndex, substring);
                        Console.WriteLine(activationKey);
                    }
                }
                else if (commandType=="Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    activationKey.Remove(startIndex,endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
