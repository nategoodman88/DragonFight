using DragonFight;
using Figgle;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Program
{
    public static async Task Main(string[] args)
    {
        bool programRunning = true;
        //print dragon art, banner, story, run rest of program methods, delay further methods until story is done
        DragonFight.Story.St();
        await Task.Delay(25000);
        //while loop so user can play multiple times
        while (programRunning) 
        {
            //empty to allow further access of variables
            CharacterCreate x = new();
            //lets user create character choosing name, class and race with unqiue attributes, also lets user start over if they are not satisfied 
            DragonFight.CharacterCreate.Create(x);
            //empty to allow further access of variables
            EquipPhase y = new();
            //chooses equipment for the upcoming battle
            DragonFight.EquipPhase.Equip(x, y);
            //initiate the battle with dragon
            DragonFight.BattlePhase.doBattlePhase(x, y);
            //ask if they want to play again
            Console.WriteLine("Would you like to play again? Enter Y or N");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "Y")
            {
                programRunning = true;
            }
            else
            {
                programRunning = false;
            }
        }
    }

}
