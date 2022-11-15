using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileLocation = Console.ReadLine().Split("\\");
            string[] fileNameAndExtenstion = fileLocation[fileLocation.Length-1].Split(".");
            Console.WriteLine($"File name: {fileNameAndExtenstion[0]}");
            Console.WriteLine($"File extension: {fileNameAndExtenstion[1]}");
        }
    }
}
