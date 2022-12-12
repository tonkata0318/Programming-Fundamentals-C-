using System;
using System.Text;

namespace Problem_1___Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder encryptedMessage = new StringBuilder(Console.ReadLine());
            string command;
            while ((command=Console.ReadLine())!="Decode")
            {
                string[] cmdInfo = command.Split("|");
                string commandName=cmdInfo[0];
                if (commandName=="Move")
                {
                    int n = int.Parse(cmdInfo[1]);
                    string substring = encryptedMessage.ToString().Remove(n,encryptedMessage.Length-n);
                    encryptedMessage.Remove(0, n);
                    encryptedMessage.Append(substring);
                }
                else if (commandName=="Insert")
                {
                    int index = int.Parse(cmdInfo[1]);
                    string insertedString=cmdInfo[2];
                    encryptedMessage.Insert(index,insertedString);
                }
                else if (commandName =="ChangeAll")
                {
                    string substring = cmdInfo[1];
                    string replacment = cmdInfo[2];
                    encryptedMessage.Replace(substring, replacment);
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
