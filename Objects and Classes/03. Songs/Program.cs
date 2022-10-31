using System;
using System.Collections.Generic;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Songs> songs = new List<Songs>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                string typeListInList=input[0];
                string name=input[1];
                string time=input[2];
                Songs song = new Songs();
                song.TypeList = typeListInList;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
            }
            string typeList = Console.ReadLine();
            if (typeList=="all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList==typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    public class Songs
    {
         public string TypeList { get; set; }

        public string Name { get; set; }
         
        public string Time { get; set; }
    }
}
