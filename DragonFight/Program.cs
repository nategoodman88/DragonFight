using DragonFight;
using Figgle;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

internal class Program
{
    public static async Task Main(string[] args)
    {
        // declare variables, print out banner, dragon art, story line by line
        string dragon = @"         __----~~~~~~~~~~~------___
                                  .  .   ~~//====......          __--~ ~~
                  -.            \_|//     |||\\  ~~~~~~::::... /~
               ___-==_       _-~o~  \/    |||  \\            _/~~-
       __---~~~.==~||\=_    -_--~/_-~|-   |\\   \\        _/~
   _-~~     .=~    |  \\-_    '-~7  /-   /  ||    \      /
 .~       .~       |   \\ -_    /  /-   /   ||      \   /
/  ____  /         |     \\ ~-_/  /|- _/   .||       \ /
|~~    ~~|--~~~~--_ \     ~==-/   | \~--===~~        .\
         '         ~-|      /|    |-~\~~       __--~~
                     |-~~-_/ |    |   ~\_   _-~            /\
                          /  \     \__   \/~                \__
                      _--~ _/ | .-~~____--~-/                  ~~==.
                     ((->/~   '.|||' -_|    ~~-/ ,              . _||
                                -_     ~\      ~~---l__i__i__i--~~_/
                                _-~-__   ~)  \--______________--~~
                              //.-~~~-~_--~- |-------~~~~~~~~
                                     //.-~~~--\";

        string story = "The kingdom of Aerono has seen peace since the end of the Great Dragon War five years ago." + "\n" +
            "Unbeknownst to the citizens of Aerono, however, one of the elder dragons, Edel, slipped away undetected toward the end of the war" + "\n" +
            "Having rested for all this time, Edel sets out on a surprise attack on Aerono in hopes of reigniting the war and starting a new brood" + "\n" +
            "With defenses unprepared and battalions low, a new hero rises up from the shadows to do battle with Edel and subdue the dragon once and for all...";

        string name = "";
        string race = "";
        string cl = "";

        CharacterCreate c = new CharacterCreate(name,race,cl);

        Console.WriteLine(FiggleFonts.Standard.Render("Dragon Fight!"));
        await Task.Delay(1000);

        Console.WriteLine(dragon);
        await Task.Delay(1000);

        foreach (string line in story.Split("\n"))
        {
            Console.WriteLine(line);
            await Task.Delay(5000);
        }
        await Task.Delay(2000);

        // enter character creation, check entered info is okay with player before moving on
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        c.Name = name;
        await Task.Delay(1000);


        // to-do: 1.implement race switch case which describes the attribute changes for each race 2.implement class switch case which describes the attribute changes and abilites of each class

        Console.WriteLine("Here is your character, is this okay?:");
        await Task.Delay(1000);

        Console.WriteLine("Name: "
            + c.Name);


        Console.ReadLine();  // generic for testing, so app doesn't auto close
    }
}