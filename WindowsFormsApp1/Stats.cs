using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Stats
    {
        public int charisma;
        public int constitution;
        public int intelligence;
        public int perception;
        public int dexterity;

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