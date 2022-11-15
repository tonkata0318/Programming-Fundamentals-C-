using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strenthg = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString()==">")
                {
                    strenthg+=int.Parse(input[i+1].ToString());
                }
                else
                {
                    if (strenthg>0)
                    {
                        input=input.Remove(i, 1);
                        strenthg--;
                        i--;
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
