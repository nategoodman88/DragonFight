using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonFight
{
    public class Equipment
    {
        public string primaryWep { get; set; }
        public string offHand { get; set; }
        public string armor { get; set; }
        //constructor
        public Equipment() 
        {
            this.primaryWep = "";
            this.offHand = "";
            this.armor = "";
        }
         
        public Equipment(string primaryWep, string offHand, string armor)
        {
            this.primaryWep = primaryWep;
            this.offHand = offHand;
            this.armor = armor;
        }
    }
}
