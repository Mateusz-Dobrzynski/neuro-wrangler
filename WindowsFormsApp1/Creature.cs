using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace WindowsFormsApp1
{
    public class Creature : INeuroObject
    {
        bool alive { get; set; }
        int[,] coordinatesPostion { get; set; }
        int currentHealth { get; set; }
        int maxHealth { get; set; }
        public string name { get; set; }
        Stats stats { get; set; }
        public Abilities abilities;
        List<IWound> wounds { get; set; }

        void Attack()
        {

        }


        /// <summary>
        /// TO-DO:
        ///   - Implement ability checks
        ///   - Implement armor damage reduction
        /// Basic method used to deal damage to creatures.
        /// It reduces current health and checks whether the creature is still alive
        /// Then, it performs Pain Resistance check and adds penalty accordingly
        /// </summary>
        void Damage(IWound wound, string location)
        {
        }

        /// <summary>
        /// Method used to instantly heal a character.
        /// It reduces penalties associated with wounds in order defined by the greedy algorithm
        /// (wounds with biggest penalty are healed first)
        /// If a penalty associated with wound gets reduced to 0, character's currentHealth is increased
        /// by the value equal to wound's tier
        /// </summary>
        void Heal(int healingPercentage)
        {

        }
    }
}