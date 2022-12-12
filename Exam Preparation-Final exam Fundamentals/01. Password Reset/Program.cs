using System;
using System.Text;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder(Console.ReadLine());
            string command;
            while ((command=Console.ReadLine())!="Done")
            {
                string[] cmdArgs = command.Split(" ");
                string commandType = cmdArgs[0];
                if (commandType=="TakeOdd")
                {
                    StringBuilder newPass = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i%2!=0)
                        {
                            newPass.Append(password[i]);
                        }
                    }
                    Console.WriteLine(newPass);
                    password = newPass;
                }
                else if (commandType=="Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int lentgh = int.Parse(cmdArgs[2]);
                    string substring=password.ToString().Substring(index, lentgh);
                    if (password.ToString().Contains(substring)) 
                    {
                        int startIndex = password.ToString().IndexOf(substring);
                        password.Remove(startIndex, substring.Length);
                    }
                    Console.WriteLine(password);
                }
                else if (commandType=="Substitute")
                {
                    string oldSubstitude = cmdArgs[1];
                    string newSubstitude = cmdArgs[2];
                    if (password.ToString().Contains(oldSubstitude))
                    {
                        password.Replace(oldSubstitude, newSubstitude);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
