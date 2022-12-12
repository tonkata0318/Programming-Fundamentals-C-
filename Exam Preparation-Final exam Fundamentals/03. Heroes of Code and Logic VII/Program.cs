using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,int> heroHp=new Dictionary<string,int>();
            Dictionary<string,int> heroMp=new Dictionary<string,int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                heroHp.Add(heroName, hp);
                heroMp.Add(heroName, mp);
            }
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                string[] cmdArgs = command.Split(" - ");
                string commandType = cmdArgs[0];
                if (commandType=="CastSpell")
                {
                    string heroName=cmdArgs[1];
                    int MpNeeded=int.Parse(cmdArgs[2]);
                    string spellName=cmdArgs[3];
                    if (heroMp[heroName]>=MpNeeded)
                    {
                        heroMp[heroName] -= MpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMp[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (commandType=="TakeDamage")
                {
                    string heroName = cmdArgs[1];
                    int dmg = int.Parse(cmdArgs[2]);
                    string atacker = cmdArgs[3];
                    heroHp[heroName] -= dmg;
                    if (heroHp[heroName]>0)
                    {
                        Console.WriteLine($"{heroName} was hit for {dmg} HP by {atacker} and now has {heroHp[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {atacker}!");
                        heroHp.Remove(heroName);
                        heroMp.Remove(heroName);
                    }
                }
                else if (commandType=="Recharge")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);
                    if (heroMp[heroName]+amount>200)
                    {

                        Console.WriteLine($"{heroName} recharged for {200 - heroMp[heroName]} MP!");
                        heroMp[heroName] = 200;
                    }
                    else
                    {
                        heroMp[heroName] += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (commandType=="Heal")
                {
                    string heroName = cmdArgs[1];
                    int amount = int.Parse(cmdArgs[2]);
                    if (heroHp[heroName]+amount>100)
                    {

                        Console.WriteLine($"{heroName} healed for {100 - heroHp[heroName]} HP!");
                        heroHp[heroName] = 100;
                    }
                    else
                    {
                        heroHp[heroName] += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }
            }
            foreach (var item in heroHp)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value}");
                Console.WriteLine($"  MP: {heroMp[item.Key]}");
            }
        }
    }
}
