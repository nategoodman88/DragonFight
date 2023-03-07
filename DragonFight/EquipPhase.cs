using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class EquipPhase : Equipment
    {
        public static void Equip(CharacterCreate c, Equipment e)
        { 
            //storing the attributes as the appear originally in order to allow for reset if equip phase is unsatisfactory
            int initHP = c.hp;
            int initHit = c.hit;
            int initMagic = c.magic;
            int initDefense = c.defense;

            bool running = true;
            while (running)
            {
                EquipPhase x = new();
                //choosing primary weapon
                Console.WriteLine("Please choose your primary weapon by typing the number and hitting enter:\n1.Brave Sword: A standard sword. Adds a little to the hit stat at no cost to other stats. Suggested for Warriors and Knights.\n2.Great Sword: A giant sword, slow but strong. Add a lot to the hit stat at the cost of defense. Suggested for Knights.\n3.Dagger: A small blade. Does not buff any hits, but allows user to always strike first. Suggested for Warriors.\n4.Staff: A magically-imbued cut of wood. Boosts magic at the cost of defense. Sugested for Mages.");
                e.primaryWep = Console.ReadLine();
                bool weaponChoosing = true;
                while (weaponChoosing)
                {
                    if (e.primaryWep == "1" || e.primaryWep == "2" || e.primaryWep == "3" || e.primaryWep == "4")
                    {
                        switch (e.primaryWep)
                        {
                            case "1":
                                e.primaryWep = "Brave Sword";
                                c.hit += 3;
                                break;

                            case "2":
                                e.primaryWep = "Great Sword";
                                c.hit += 6;
                                c.defense -= 3;
                                break;

                            case "3":
                                e.primaryWep = "Dagger";
                                break;

                            case "4":
                                e.primaryWep = "Staff";
                                c.hit += 6;
                                c.defense -= 3;
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
                Console.WriteLine(e.primaryWep + " has been equipped to " + c.name);
                //choosing offhand
                Console.WriteLine("Please choose your offhand by typing the number and hitting enter:\n1.Wooden Shield: Protects the user slightly. Raises defense. Suggested for all classes.\n2.Tome: Boots magic at the cost of HP. Suggested for Mages.\n3.Healing Stone. Heals some HP when user falls below 30% of their total HP. Suggested for all classes.\n4.Silver Shield. Significantly raises defense at the cost of hit. Suggested for Warriors and Knights");
                e.offHand = Console.ReadLine();
                bool offHandChoosing = true;
                while (offHandChoosing)
                {
                    if (e.offHand == "1" || e.offHand == "2" || e.offHand == "3" || e.offHand == "4")
                    {
                        switch (e.offHand)
                        {
                            case "1":
                                e.offHand = "Wooden Shield";
                                c.defense += 3;
                                break;

                            case "2":
                                e.offHand = "Tome";
                                c.magic += 6;
                                c.hp -= 5;
                                break;

                            case "3":
                                e.offHand = "Healing Stone";
                                break;

                            case "4":
                                e.offHand = "Silver Shield";
                                c.defense += 6;
                                c.hit -= 3;
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
                Console.WriteLine(e.offHand + " has been equipped to " + c.name);
                //choosing armor
                Console.WriteLine("Please choose your armor by typing the number and hitting enter:\n1.Heavy Armor: Greatly raises defense at the cost of hit and magic.\n2.Light Armor: Slightly raises defense at no costs to stats");
                e.armor = Console.ReadLine();
                bool choosingArmor = true;
                while (choosingArmor)
                {
                    if (e.armor == "1" || e.armor == "2")
                    {
                        switch (e.armor)
                        {
                            case "1":
                                e.armor = "Heavy Armor";
                                c.defense += 6;
                                c.hit -= 3;
                                c.magic -= 3;
                                break;

                            case "2":
                                e.armor = "Light Armor";
                                c.defense += 2;
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
                Console.WriteLine(e.armor + " has been equipped to " + c.name);
                //tell final equipment and stats
                Console.WriteLine(e.primaryWep + "," + e.offHand + "," + e.armor + " are equipped to " + c.name);
                Console.WriteLine("Attributes:\nHP: " + c.hp + "\nHit: " + c.hit + "\nMagic: " + c.magic + "\nDefense: " + c.defense);
                bool choosingFinal = true;
                while (choosingFinal)
                {
                    Console.WriteLine("Is this okay? Type Y for yes or N for no and to start over, then hit enter: ");
                    string final = Console.ReadLine();
                    if (final.ToUpper() == "N")
                    {
                        choosingFinal = false;
                        c.hp = initHP;
                        c.hit = initHit;
                        c.magic = initMagic;
                        c.defense = initDefense;
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
            Console.WriteLine("Heading to battle!!!");
        }
    }
}
