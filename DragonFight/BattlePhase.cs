using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class BattlePhase : EquipPhase
    {
        //declare the variables for the dragon attributes as well as variables needed to run through the battle including whose turn it is, amount of damage done, etc. 
        static int dragonDefense = 15;
        static int dragonHealth = 100;
        static int dragonAttack = 5;

        public static void doBattlePhase(CharacterCreate c, EquipPhase e)
        {
            int initHP = c.hp;
            Console.WriteLine("Yeahhhh we batttlingggggg ah ah");
            Console.WriteLine(c.hp); //debugging to make sure variable sticks
            Console.WriteLine(e.primaryWep); //debugging to make sure variable sticks
            //Bool and while loop to go through the battle until there is a winner
            bool battling = true;
            string turn = "";
            Random random = new Random();
            int turnDecider = 0;
            while (battling)
            {
                if (e.primaryWep == "Dagger")
                {
                    turn = "Player";
                }
                else
                {
                    turnDecider = random.Next(0, 2);
                    if (turnDecider == 1)
                    {
                        turn = "Player";
                    }
                    else
                    {
                        turn = "Dragon";
                    }
                }
                if (turn == "Player")
                {
                    Console.WriteLine(c.name + "'s turn is next");
                    Console.WriteLine("What would you like to do? Type the number for your chosen action and hit enter.\n1.Attack\n2.Magic\n3.Fortify and heal.");
                    bool choosingAction = true;
                    while (choosingAction)
                    {
                        string move = Console.ReadLine();
                        if (move == "1")
                        {
                            int damage = (c.hit * random.Next(0, 5)) - dragonDefense;
                            Console.WriteLine(damage);
                            dragonHealth -= damage;
                            if (dragonHealth < 0)
                            {
                                dragonHealth = 0;
                            }
                            Console.WriteLine(c.name + " hits Edel for " + damage + " damage. Edel's HP is now " + dragonHealth);
                            choosingAction = false;
                            if (dragonHealth == 0)
                            {
                                Console.WriteLine(c.name + " has killed Edel! You win!");
                                battling = false;
                            }
                        }
                        if (move == "2")
                        {
                            int damage = (c.magic * random.Next(0, 5)) - dragonDefense;
                            dragonHealth -= damage;
                            if (dragonHealth < 0)
                            {
                                dragonHealth = 0;
                            }
                            Console.WriteLine(c.name + " hits Edel for " + damage + " damage. Edel's HP is now " + dragonHealth);
                            choosingAction = false;
                            if (dragonHealth == 0)
                            {
                                Console.WriteLine(c.name + " has killed Edel! You win!");
                                battling = false;
                            }
                        }
                        if (move == "3")
                        {
                            if (c.hp < initHP)
                            {
                                c.hp += random.Next(5, 10);
                                if (c.hp > initHP)
                                {
                                    c.hp = initHP;
                                }
                                Console.WriteLine("You fortify and recover some health. Your HP is now: " + c.hp);
                                choosingAction = false;
                            }
                            else
                            {
                                Console.WriteLine("You are already at full health!");
                                choosingAction = true;
                            }
                            choosingAction = false;
                        }
                    }
                    if (turn == "Dragon")
                    {
                        Console.WriteLine("Edel prepares to attack!");
                        int damage = (dragonAttack * random.Next(0, 2)) - c.defense;
                        c.hp -= damage;
                        if (c.hp < 0)
                        {
                            c.hp = 0;
                        }
                        Console.WriteLine("Edel hits " + c.name + " for " + damage + " damage. " + c.name + "'s HP is now " + c.hp);
                        if (c.hp == 0)
                        {
                            Console.WriteLine("Edel has won the battle. Game over");
                            battling = false;
                        }
                    }
                    if (turn == "Player")
                    {
                        turn = "Dragon";
                        Console.WriteLine("Edel prepares to attack!");
                        int damage = (dragonAttack * random.Next(0, 2)) - c.defense;
                        c.hp -= damage;
                        if (c.hp < 0)
                        {
                            c.hp = 0;
                        }
                        Console.WriteLine("Edel hits " + c.name + " for " + damage + " damage. " + c.name + "'s HP is now " + c.hp);
                        if (c.hp == 0)
                        {
                            Console.WriteLine("Edel has won the battle. Game over");
                            battling = false;
                        }
                    }
                    if (turn == "Dragon")
                    {
                        Console.WriteLine(c.name + "'s turn is next");
                        Console.WriteLine("What would you like to do? Type the number for your chosen action and hit enter.\n1.Attack\n2.Magic\n3.Fortify and heal.");
                        choosingAction = true;
                        while (choosingAction)
                        {
                            string move = Console.ReadLine();
                            if (move == "1")
                            {
                                int damage = (c.hit * random.Next(0, 5)) - dragonDefense;
                                Console.WriteLine(damage);
                                dragonHealth -= damage;
                                if (dragonHealth < 0)
                                {
                                    dragonHealth = 0;
                                }
                                Console.WriteLine(c.name + " hits Edel for " + damage + " damage. Edel's HP is now " + dragonHealth);
                                choosingAction = false;
                                if (dragonHealth == 0)
                                {
                                    Console.WriteLine(c.name + " has killed Edel! You win!");
                                    battling = false;
                                }
                            }
                            if (move == "2")
                            {
                                int damage = (c.magic * random.Next(0, 5)) - dragonDefense;
                                dragonHealth -= damage;
                                if (dragonHealth < 0)
                                {
                                    dragonHealth = 0;
                                }
                                Console.WriteLine(c.name + " hits Edel for " + damage + " damage. Edel's HP is now " + dragonHealth);
                                choosingAction = false;
                                if (dragonHealth == 0)
                                {
                                    Console.WriteLine(c.name + " has killed Edel! You win!");
                                    battling = false;
                                }
                            }
                            if (move == "3")
                            {
                                if (c.hp < initHP)
                                {
                                    c.hp += random.Next(5, 10);
                                    if (c.hp > initHP)
                                    {
                                        c.hp = initHP;
                                    }
                                    Console.WriteLine("You fortify and recover some health. Your HP is now: " + c.hp);
                                    choosingAction = false;
                                }
                                else
                                {
                                    Console.WriteLine("You are already at full health!");
                                    choosingAction = true;
                                }
                                choosingAction = false;
                            }
                        }
                        //debugging
                        Console.WriteLine(turn);
                        Console.WriteLine("butts");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}

