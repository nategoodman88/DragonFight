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

        public string Name;
        public string Race;
        public string Class;
        public int HP;
        public int Hit;
        public int Magic;
        public int Defense;
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
                    if (choice == "Human" || choice == "human" || choice == "Elf" || choice == "elf" || choice == "Dwarf" || choice == "dwarf")
                    {
                        switch (choice)
                        {
                            case "Human":
                                this.Race = "Human";
                                HP += 30;
                                Hit += 10;
                                Magic += 10;
                                Defense += 10;
                                break;

                            case "human":
                                this.Race = "Human";
                                HP += 30;
                                Hit += 10;
                                Magic += 10;
                                Defense += 10;
                                break;

                            case "Elf":
                                this.Race = "Elf";
                                HP += 20;
                                Hit += 20;
                                Magic += 15;
                                Defense += 15;
                                break;

                            case "elf":
                                this.Race = "Elf";
                                HP += 20;
                                Hit += 20;
                                Magic += 15;
                                Defense += 15;
                                break;

                            case "Dwarf":
                                this.Race = "Dwarf";
                                HP += 40;
                                Hit += 5;
                                Magic += 5;
                                Defense += 15;
                                break;

                            case "dwarf":
                                this.Race = "Dwarf";
                                HP += 40;
                                Hit += 5;
                                Magic += 5;
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
                    if (choice2 == "Warrior" || choice2 == "warrior" || choice2 == "Mage" || choice2 == "mage" || choice2 == "Knight" || choice2 == "knight")
                    {
                        switch (choice2)
                        {
                            case "Warrior":
                                this.Class = "Warrior";
                                HP += 10;
                                Hit += 5;
                                Magic += 5;
                                Defense += 5;
                                break;

                            case "warrior":
                                this.Class = "Warrior";
                                HP += 10;
                                Hit += 5;
                                Magic += 5;
                                Defense += 5;
                                break;

                            case "Mage":
                                this.Class = "Mage";
                                HP += 5;
                                Hit += 0;
                                Magic += 10;
                                Defense += 0;
                                break;

                            case "mage":
                                this.Class = "mage";
                                HP += 5;
                                Hit += 0;
                                Magic += 10;
                                Defense += 0;
                                break;

                            case "Knight":
                                this.Class = "Knight";
                                HP += 5;
                                Hit += 15;
                                Magic += 0;
                                Defense += 10;
                                break;

                            case "knight":
                                this.Class = "Knight";
                                HP += 5;
                                Hit += 15;
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

                Console.WriteLine("Is this okay? Type Y for yes or N for no and hit enter: ");
                string final = Console.ReadLine();
                if (final == "N" || final == "n")
                {
                    running = true;
                }
                else
                {
                    running = false;
                }
            }
        
        }
    }
}












