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

        public static void doBattlePhase(CharacterCreate c, EquipPhase e)
        {
            Console.WriteLine("Yeahhhh we batttlingggggg ah ah");
            Console.WriteLine(c.hp); //debugging to make sure variable sticks
            Console.WriteLine(e.primaryWep); //debugging to make sure variable sticks
            //Eventual bool and while loop to have battle actually happen
        }
    }
}

