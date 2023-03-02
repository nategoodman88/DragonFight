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
            Console.WriteLine("Please choose your primary weapon by typing the number and hitting enter:\n1.Brave Sword: A standard sword. Suggested for Warriors and Knights.\n2.Great Sword: A giant sword, slow but strong. Suggested for Knights.\n3.Dagger: A small blade, useful in all situations. Suggested for Warriors.\n4.Staff: A magically-imbued cut of wood. Sugested for Mages.");
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
                            break;

                        case "2":
                            primaryWep = "Great Sword";
                            break;

                        case "3":
                            primaryWep = "Dagger";
                            break;

                        case "4":
                            primaryWep = "Staff";
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
            //find way to get character name
            Console.WriteLine(primaryWep + " has been equipped to " + this.Name);
        }

    }
}
