using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourse;
            Dictionary<string,int> minerTask=new Dictionary<string,int>();
            while ((resourse=Console.ReadLine())!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!minerTask.ContainsKey(resourse))
                {
                    minerTask[resourse]=quantity;
                }
                else
                {
                    minerTask[resourse] += quantity;
                }
            }
            foreach (var runes in minerTask)
            {
                Console.WriteLine($"{runes.Key} -> {runes.Value}");
            }
        }
    }
}
