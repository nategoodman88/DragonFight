using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class Character
    {

        public string name { get; set; }
        public string race { get; set; }
        public string clss { get; set; }
        public int hp { get; set; }
        //testing
        //public ref int hp1 = ref hp;
        public int hit { get; set; }
        public int magic { get; set; }
        public int defense { get; set; }
        //constructor
        public Character()
        {
            this.name = "";
            this.race = "";
            this.clss = "";
            this.hp = 0;
            this.hit = 0;
            this.magic = 0;
            this.defense = 0;   

        }
        
        public Character(string name, string race, string clss, int hp, int hit, int magic, int defense)
        {
            
            this.name = name;
            this.race = race;
            this.clss = clss;
            this.hp = hp;
            this.hit = hit;
            this.magic =  magic;
            this.defense = defense;

        }

        
    }
}











