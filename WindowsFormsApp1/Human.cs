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

        public Abilities abilities;
        public bool alive { get; set; }
        public int[,] coordinatesPostion { get; set; }
        public string name { get; set; }
        public Stats stats { get; set; }
        public int currentHealth { get; set; }
        public int maxHealth { get; set; }

        public Human(string background, string backgroundTrait, string profession, string professionTrait, bool alive, string name, Stats stats, Abilities abilities, int currentHealth, int maxHealth)
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
            this.maxHealth = maxHealth;
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Damage()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }
    }
}