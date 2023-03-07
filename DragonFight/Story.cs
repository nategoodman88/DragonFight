using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class Story
    {
        public static async void St()
        {
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

            Console.WriteLine(FiggleFonts.Standard.Render("Dragon Fight!"));
            await Task.Delay(2000);
            Console.WriteLine(dragon);
            await Task.Delay(2000);
            foreach (string line in story.Split("\n"))
            {
                Console.WriteLine(line);
                await Task.Delay(5000);
            }

        }
    }
}
