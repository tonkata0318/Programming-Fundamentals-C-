using System;
using System.Text;

namespace _01.World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder worldTour = new StringBuilder(Console.ReadLine());
            string command;
            while ((command=Console.ReadLine())!="Travel")
            {
                string[] cmdInfo = command.Split(":");
                string commandType=cmdInfo[0];
                if (commandType == "Add Stop")
                {
                    int index = int.Parse(cmdInfo[1]);
                    string text = cmdInfo[2];
                    if (index>=0&&index<=worldTour.Length-1)
                    {
                        worldTour.Insert(index, text);
                        Console.WriteLine(worldTour);
                    }
                    else
                    {
                        Console.WriteLine(worldTour);
                    }

                }
                else if (commandType=="Remove Stop")
                {
                    int startIndex = int.Parse(cmdInfo[1]);
                    int endIndex = int.Parse(cmdInfo[2]);
                    if (startIndex>=0&&endIndex<=worldTour.Length-1)
                    {
                        worldTour.Remove(startIndex, endIndex - startIndex+1);
                        Console.WriteLine(worldTour);
                    }
                    else
                    {
                        Console.WriteLine(worldTour);
                    }
                }
                else if (commandType=="Switch")
                {
                    string oldString = cmdInfo[1];
                    string newString = cmdInfo[2];
                    if (worldTour.ToString().Contains(oldString))
                    {
                        worldTour.Replace(oldString, newString);
                        Console.WriteLine(worldTour);
                    }
                    else
                    {
                        Console.WriteLine(worldTour);
                    }

                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {worldTour}");
        }
    }
}
