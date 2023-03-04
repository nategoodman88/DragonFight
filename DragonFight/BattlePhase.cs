using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class BattlePhase : EquipPhase
    {
        //declare the variables for the dragon attributes as well as variables needed to run through the battle including whose turn it is, etc. 
        public int dragonHealth = 100;
        public int dragonHit = 10;
        public int dragonMagic = 15;
        public int dragonDefense = 25;
        public string turn = "";
        public Random rnd = new Random();
        public int turnDecider = 0;
        public int damage = 0;
        public string dragonAttackType = "";
        public int attackTypeDecider = 0;
        public string victor = "";

        public async Task BP()
        {
            bool fighting = true;
            if (primaryWep == "Dagger")
            {
                turn = "Player";
            }
            else
            {
                turnDecider = rnd.Next(1, 2);
                if (turnDecider == 1)
                {
                    turn = "Player";
                }
                else if (turnDecider == 2)
                {
                    turn = "Dragon";
                }

            }
            while (fighting)
            {
                await Task.Delay(2000);
                if (turn == "Player")
                {
                    Console.WriteLine(Name + " attacks");
                    if (primaryWep != "Staff")
                    {
                        damage = (Magic * rnd.Next(1, 3)) - dragonDefense;
                        dragonHealth -= damage;
                        if (dragonHealth < 0)
                        {
                            dragonHealth = 0;
                        }
                        Console.WriteLine(Name + " attacks Edel for " + damage + "damage. Edel's health is now " + dragonHealth);
                        if (dragonHealth == 0)
                        {
                            victor = "Player";
                            fighting = false;
                        }
                    }
                    else
                    {
                        damage = Hit * rnd.Next(1, 3) - dragonDefense;
                        dragonHealth -= damage;
                        if (dragonHealth < 0)
                        {
                            dragonHealth = 0;
                        }
                        Console.WriteLine(Name + " attacks Edel for " + damage + "damage. Edel's health is now " + dragonHealth);
                        if (dragonHealth == 0)
                        {
                            victor = "Player";
                            fighting = false;
                        }
                    }
                }
                if (turn == "Dragon")
                {
                    attackTypeDecider = rnd.Next(1, 2);
                    if (attackTypeDecider == 1)
                    {
                        dragonAttackType = "Magic";
                    }
                    else if (attackTypeDecider == 2)
                    {
                        dragonAttackType = "Hit";
                    }
                    if (dragonAttackType == "Magic")
                    {
                        damage = dragonMagic;
                        HP -= damage - Defense;
                        if (HP < 0)
                        {
                            HP = 0;
                        }
                        Console.WriteLine("Edel attacks " + Name + " for " + damage + " damae. " + Name + "'s health is now " + HP);
                        if (HP == 0)
                        {
                            victor = "Dragon";
                            fighting = false;
                        }
                    }
                    if (dragonAttackType == "Hit")
                    {
                        damage = dragonHit;
                        HP -= damage - Defense;
                        if (HP < 0)
                        {
                            HP = 0;
                        }
                        Console.WriteLine("Edel attacks " + Name + " for " + damage + " damae. " + Name + "'s health is now " + HP);
                        if (HP == 0)
                        {
                            victor = "Dragon";
                            fighting = false;
                        }
                    }
                    if (turn == "Dragon")
                    {
                        turn = "Player";
                    }
                    else
                    {
                        turn = "Dragon";
                    }


                }

            }
            if(victor == "Player")
            {
                Console.WriteLine(Name + " has slayed Edel and claimed victory for the kingdom!");
            }
            else if (victor == "Dragon")
            {
                Console.WriteLine("Edel has defeated " + Name + ". Game over.");
            }

        }
    }
}

