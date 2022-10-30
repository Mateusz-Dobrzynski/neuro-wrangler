using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Stats
    {
        int charisma { get; set; }
        int constitution { get; set; }
        int dexterity { get; set; }
        int intelligence { get; set; }
        int perception { get; set; }

        public Stats(int charisma, int constitution, int dexterity, int intelligence, int perception)
        {
            this.charisma = charisma;
            this.constitution = constitution;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.perception = perception;
        }
    }
}