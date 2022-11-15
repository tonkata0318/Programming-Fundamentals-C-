using System;

namespace _1._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            bool invalid = false;
            foreach (string user in usernames)
            {
                if (user.Length>=3&&user.Length<=16)
                {
                    foreach (char charsinUser in user)
                    {
                        char thisChar=charsinUser;
                        if (!(char.IsLetter(thisChar) || char.IsDigit(thisChar) || (thisChar == '-') || (thisChar == '_')))
                        {
                            invalid = true;
                            break;
                        }
                    }
                }
                else
                {
                    invalid = true;
                }
                if (invalid==false)
                {
                    Console.WriteLine(user);
                }
                invalid = false;
            }
        }
    }
}
