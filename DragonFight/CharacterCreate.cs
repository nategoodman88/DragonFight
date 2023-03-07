using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class CharacterCreate : Character
    {
        public static void Create(Character c)
        {
            CharacterCreate x = new();
            bool running = true;
            while (running)
            {
                Console.WriteLine("What is your name?");
                c.name = Console.ReadLine();
                Console.WriteLine("Please choose a race by typing your choice and hitting enter: ");
                Console.WriteLine("Human: Well balanced in all attributes.\nElf:A race that excels in magic.\nDwarf: A race that excels in defense.");
                string choice = Console.ReadLine();
                bool choosing = true;
                while (choosing)
                {
                    if (choice.ToUpper() == "HUMAN" || choice.ToUpper() == "ELF" || choice.ToUpper() == "DWARF")
                    {
                        switch (choice.ToUpper())
                        {
                            case "HUMAN":
                                c.race = "Human";
                                c.hp += 30;
                                c.hit += 10;
                                c.magic += 5;
                                c.defense += 10;
                                break;

                            case "ELF":
                                c.race = "Elf";
                                c.hp += 20;
                                c.hit += 0;
                                c.magic += 20;
                                c.defense += 15;
                                break;

                            case "DWARF":
                                c.race = "Dwarf";
                                c.hp += 40;
                                c.hit += 5;
                                c.magic += 0;
                                c.defense += 15;
                                break;
                        }
                        choosing = false;
                    }

                    else
                    {
                        Console.WriteLine("Wrong format, please try again.");
                        Console.WriteLine("Please choose a race by typing your choice and hitting enter: ");
                        Console.WriteLine("Human: Well balanced in all attributes.\nElf:A race that excels in magic.\nDwarf: A race that excels in defense.");
                        choice = Console.ReadLine();
                    }

                }

                Console.WriteLine("Please choose a class by typing your choice and hitting enter: ");
                Console.WriteLine("Warrior: Well balanced class.\nMage: A class focused on magic.\nKnight: A class focused on close quarters combat with swords.");
                string choice2 = Console.ReadLine();
                bool choosing2 = true;
                while (choosing2)
                {
                    if (choice2.ToUpper() == "WARRIOR" || choice2.ToUpper() == "MAGE" || choice2.ToUpper() == "KNIGHT")
                    {
                        switch (choice2)
                        {
                            case "WARRIOR":
                                c.clss = "Warrior";
                                c.hp += 10;
                                c.hit += 15;
                                c.magic += 5;
                                c.defense += 5;
                                break;

                            case "MAGE":
                                c.clss = "Mage";
                                c.hp += 5;
                                c.hit += 0;
                                c.magic += 10;
                                c.defense += 0;
                                break;

                            case "KNIGHT":
                                c.clss = "Knight";
                                c.hp += 5;
                                c.hit += 5;
                                c.magic += 0;
                                c.defense += 10;
                                break;
                        }
                        choosing2 = false;
                    }

                    else
                    {
                        Console.WriteLine("Wrong format, please try again.");
                        Console.WriteLine("Please choose a class by typing your choice and hitting enter: ");
                        Console.WriteLine("Warrior: Well balanced class.\nMage: A class focused on magic.\nKnight: A class focused on close quarters combat with swords.");
                        choice2 = Console.ReadLine();
                    }

                }

                Console.WriteLine("Here is your character:");
                Console.WriteLine("Name: " + c.name + "\n" + "Race: " + c.race + "\n" + "Class: " + c.clss);
                Console.WriteLine("Attributes:\nHP:" + c.hp + "\nHit: " + c.hit + "\nMagic: " + c.magic + "\nDefense: " + c.defense);
                bool choosingFinal = true;
                while (choosingFinal)
                {
                    Console.WriteLine("Is this okay? Type Y for yes or N for no and to start over, then hit enter: ");
                    string final = Console.ReadLine();
                    if (final.ToUpper() == "N")
                    {
                        choosingFinal = false;
                        c.hp = 0;
                        c.hit = 0;
                        c.magic = 0;
                        c.defense = 0;
                        running = true;
                    }
                    else if (final.ToUpper() == "Y")
                    {
                        choosingFinal = false;
                        running = false;

                    }
                    else
                    {
                        Console.WriteLine("Wrong input, please try again");
                        choosingFinal = true;

                    }

                }
            }
        }
    }
}
