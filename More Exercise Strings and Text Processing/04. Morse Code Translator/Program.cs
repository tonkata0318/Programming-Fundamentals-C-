using System;
using System.Collections.Generic;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string article=Console.ReadLine();
            string content=Console.ReadLine();
            string comment=Console.ReadLine();
            List<string> comments=new List<string>();
            while (comment!="end of comments")
            {
                comments.Add(comment);
                comment=Console.ReadLine();
            }
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {article}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
            foreach (var comm in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comm}");
                Console.WriteLine("</div>");
            }
        }
    }
}
