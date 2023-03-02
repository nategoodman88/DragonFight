using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class EquipPhase : CharacterCreate
    {
        public string primaryWep { get; set; }
        public string offHand { get; set; }
        public string armor { get; set; }

        public EquipPhase()
        {
            //choosing primary weapon
            Console.WriteLine("Please choose your primary weapon by typing the number and hitting enter:\n1.Brave Sword: A standard sword. Adds a little to the hit stat at no cost to other stats. Suggested for Warriors and Knights.\n2.Great Sword: A giant sword, slow but strong. Add a lot to the hit stat at the cost of defense. Suggested for Knights.\n3.Dagger: A small blade. Does not buff any hits, but allows user to always strike first. Suggested for Warriors.\n4.Staff: A magically-imbued cut of wood. Boosts magic at the cost of defense. Sugested for Mages.");
            primaryWep = Console.ReadLine();
            bool weaponChoosing = true;
            while (weaponChoosing)
            {
                if (primaryWep == "1" || primaryWep == "2" || primaryWep == "3" || primaryWep == "4")
                {
                    switch(primaryWep) 
                    { 
                        case "1":
                            primaryWep = "Brave Sword";
                            this.Hit += 3;
                            break;

                        case "2":
                            primaryWep = "Great Sword";
                            this.Hit += 6;
                            this.Defense -= 3; 
                            break;

                        case "3":
                            primaryWep = "Dagger";
                            break;

                        case "4":
                            primaryWep = "Staff";
                            this.Magic += 6;
                            this.Defense -= 3;
                            break;
                    }
                    weaponChoosing = false;
                }
                else 
                { 
                    Console.WriteLine("Wrong format, please choose again.");
                    weaponChoosing = true;
                }
            }
            Console.WriteLine(primaryWep + " has been equipped to " + this.Name);
            //choosing offhand
            Console.WriteLine("Please choose your offhand by typing the number and hitting enter:\n1.Wooden Shield: Protects the user slightly. Raises defense. Suggested for all classes.\n2.Tome: Boots magic at the cost of HP. Suggested for Mages.\n3.Healing Stone. Heals some HP when user falls below 30% of their total HP. Suggested for all classes.\n4.Silver Shield. Significantly raises defense at the cost of hit. Suggested for Warriors and Knights");
            offHand = Console.ReadLine();
            bool offHandChoosing = true;
            while (offHandChoosing)
            {
                if (offHand == "1" || offHand == "2" || offHand == "3" || offHand == "4")
                {
                    switch (offHand)
                    {
                        case "1":
                            offHand = "Wooden Shield";
                            this.Defense += 3;
                            break;

                        case "2":
                            offHand = "Tome";
                            this.Magic += 6;
                            this.HP -= 5;
                            break;

                        case "3":
                            offHand = "Healing Stone";
                            break;

                        case "4":
                            offHand = "Silver Shield";
                            this.Defense += 6;
                            this.Hit -= 3;
                            break;
                    }
                    offHandChoosing = false;
                }
                else
                {
                    Console.WriteLine("Wrong format, please choose again.");
                    offHandChoosing = true;
                }
            }
            Console.WriteLine(offHand + " has been equipped to " + this.Name);
            //choosing armor
            Console.WriteLine("Please choose your armor by typing the number and hitting enter:\n1.Heavy Armor: Greatly raises defense at the cost of hit and magic.\n2.Light Armor: Slightly raises defense at no costs to stats");
            armor = Console.ReadLine();
            bool choosingArmor = true;
            while (choosingArmor)
            {
                if (armor == "1" || armor == "2")
                {
                    switch (armor)
                    {
                        case "1":
                            armor = "Heavy Armor";
                            this.Defense += 6;
                            this.Hit -= 3;
                            this.Magic -= 3;
                            break;

                        case "2":
                            armor = "Light Armor";
                            this.Defense += 2;
                            break;
                    }
                    choosingArmor = false;
                }
                else
                {
                    Console.WriteLine("Wrong format, please choose again.");
                    choosingArmor = true;
                }
            }
            Console.WriteLine(armor + " has been equipped to " + this.Name);
            //tell final equipment and stats
            Console.WriteLine(primaryWep + "," + offHand + "," + armor + " are equipped to " + this.Name);
            Console.WriteLine("Attributes:\nHP: " + this.HP + "\nHit: " + this.Hit + "\nMagic: " + this.Magic + "\nDefense: " + this.Defense);
            Console.WriteLine("Heading to battle!!!");
        }

    }
}
