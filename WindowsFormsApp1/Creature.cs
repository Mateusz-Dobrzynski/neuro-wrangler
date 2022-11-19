using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace WindowsFormsApp1
{
    public class Creature : INeuroObject
    {
        public bool alive { get; set; } = true;
        public int[,] coordinatesPostion { get; set; }
        public int currentHealth { get; set; }
        public int maxHealth { get; set; }
        public string name { get; set; }
        public Stats stats { get; set; }
        public Abilities abilities;
        public List<IWound> wounds { get; set; } = new List<IWound>();

        /*
        public Creature(string name, Stats stats, Abilities abilities, int maxHealth)
        {
            this.name = name;
            this.stats = stats;
            this.abilities = abilities;
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
        }
        */

        void Attack()
        {

        }


        /// <summary>
        /// TO-DO:
        ///   - Implement armor damage reduction
        /// Basic method used to deal damage to creatures.
        /// It reduces current health and checks whether the creature is still alive
        /// Then, it performs Pain Resistance check and adds penalty accordingly
        /// </summary>
        public void Damage(IWound wound, Weapon weapon)
        {
            //TO-DO: Damage reduction
            this.wounds.Add(wound);
            this.stats.ApplyModifierPercentage(wound.penalty);
            this.currentHealth -= wound.damagePoints;
            if (this.currentHealth < 0)
            {
                this.alive = false;
                this.currentHealth = 0;
            }
        }

        /// <summary>
        /// Method used to instantly heal a character.
        /// It reduces penalties associated with wounds in order defined by the greedy algorithm
        /// (wounds with biggest penalty are healed first)
        /// If a penalty associated with wound gets reduced to 0, character's currentHealth is increased
        /// by the value equal to wound's tier
        /// </summary>
        public void Heal(int healingPercentage)
        {
            IWound woundCheck()
            {   
                int maxPenaltyValue = 0;
                int maxPenaltyIndex = 0;
                for (int i = 0; i < this.wounds.Count; i++)
                {
                    if (wounds[i].penalty > maxPenaltyValue)
                    {
                        maxPenaltyValue = wounds[i].penalty;
                        maxPenaltyIndex = i;
                    }
                }
                IWound biggestWound = this.wounds[maxPenaltyIndex];
                return biggestWound;
            }
            if (this.wounds.Count == 0) return;
            while(healingPercentage > 0)
            {
                IWound biggestWound = woundCheck();
                if (healingPercentage >= biggestWound.penalty)
                {
                    healingPercentage -= biggestWound.penalty;
                    this.currentHealth += biggestWound.damagePoints;
                    this.wounds.Remove(biggestWound);
                }
                else
                {
                    biggestWound.penalty -= healingPercentage;
                    healingPercentage = 0;
                }
            }
        }
    }
}