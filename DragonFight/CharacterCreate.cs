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

        public CharacterCreate()
        {
            Console.WriteLine("What is your name?");
            this.Name = Console.ReadLine();
            Console.WriteLine("Please choose a race by typing your choice and hitting enter: ");
            Console.WriteLine("Human: Well balanced in all attributes.\nElf:A race that excels in magic.\nDwarf: A race that excels in strength and the use of large weapons.");
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
                            break;

                        case "human":
                            this.Race = "Human";
                            break;

                        case "Elf":
                            this.Race = "Elf";
                            break;

                        case "elf":
                            this.Race = "Elf";
                            break;

                        case "Dwarf":
                            this.Race = "Dwarf";
                            break;

                        case "dwarf":
                            this.Race = "Dwarf";
                            break;
                    }
                    choosing = false;
                }

                else
                {
                    Console.WriteLine("Wrong format, please try again.");
                    Console.WriteLine("Please choose a race by typing your choice and hitting enter: ");
                    Console.WriteLine("Human: Well balanced in all attributes.\nElf:A race that excels in magic.\nDwarf: A race that excels in strength and the use of large weapons.");
                    choice = Console.ReadLine();
                }

            }

            //To do here: the same as above with the class choices

            Console.WriteLine("Here is your character:");
            Console.WriteLine("Name: " + this.Name + "\n" + "Race: " + this.Race + "\n" + "Class: " + this.Class);

            //To do here: give user the choice to go back and edit anything or move forward

            //To do here: calculate and display final stats of the character and end this section 

        }
    }
}












