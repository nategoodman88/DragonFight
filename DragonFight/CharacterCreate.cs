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
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }

        public CharacterCreate(string name, string race, string cl)
        {
            this.Name = name;
            this.Race = race; 
            this.Class = cl;
        }

       
    }


}
