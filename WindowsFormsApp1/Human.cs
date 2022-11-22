using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Human : Creature
    {
        public string background;
        public string backgroundTrait;
        public string profession;
        public string professionTrait;


        public Human(string background, string backgroundTrait, string profession, string professionTrait, bool alive, string name, Stats stats, Abilities abilities, int currentHealth)
        {
            this.background = background;
            this.backgroundTrait = backgroundTrait;
            this.profession = profession;
            this.professionTrait = professionTrait;
            this.alive = alive;
            //this.coordinatesPostion = coordinatesPostion;
            this.name = name;
            this.stats = stats;
            this.abilities = abilities;
            this.currentHealth = currentHealth;
            this.maxHealth = 27;
        }
    }
}