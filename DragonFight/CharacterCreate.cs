using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class CharacterCreate
    {
        //public variables for use with actual method below

        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int HP { get; set; }
        public int Hit { get; set; }
        public int Magic { get; set; }
        public int Defense { get; set; }
        //lets user create character choosing name, class and race with unqiue attributes, also lets user start over if they are not satisfied 
        public CharacterCreate()
        {
            bool running = true;
            while (running) {
                Console.WriteLine("What is your name?");
                this.Name = Console.ReadLine();
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
                                Race = "Human";
                                HP += 30;
                                Hit += 10;
                                Magic += 5;
                                Defense += 10;
                                break;

                            case "ELF":
                                Race = "Elf";
                                HP += 20;
                                Hit += 0;
                                Magic += 20;
                                Defense += 15;
                                break;

                            case "DWARF":
                                Race = "Dwarf";
                                HP += 40;
                                Hit += 5;
                                Magic += 0;
                                Defense += 15;
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
                    if (choice2.ToUpper() == "WARRIOR" || choice2.ToUpper() == "MAGE" ||  choice2.ToUpper( )== "KNIGHT")
                    {
                        switch (choice2)
                        {
                            case "WARRIOR":
                                Class = "Warrior";
                                HP += 10;
                                Hit += 15;
                                Magic += 5;
                                Defense += 5;
                                break;

                            case "MAGE":
                                Class = "Mage";
                                HP += 5;
                                Hit += 0;
                                Magic += 10;
                                Defense += 0;
                                break;

                            case "KNIGHT":
                                Class = "Knight";
                                HP += 5;
                                Hit += 5;
                                Magic += 0;
                                Defense += 10;
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
                Console.WriteLine("Name: " + this.Name + "\n" + "Race: " + this.Race + "\n" + "Class: " + this.Class);
                Console.WriteLine("Attributes:\nHP:" + this.HP + "\nHit: " + this.Hit + "\nMagic: " + this.Magic + "\nDefense: " + this.Defense);
                bool choosingFinal = true;
                while(choosingFinal)
                {
                    Console.WriteLine("Is this okay? Type Y for yes or N for no and to start over, then hit enter: ");
                    string final = Console.ReadLine();
                    if (final.ToUpper() == "N")
                    {
                        choosingFinal= false;
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












