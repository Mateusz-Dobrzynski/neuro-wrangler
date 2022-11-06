using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Armor : Item
    {
        /// <summary>
        /// How much the damage will be reduced
        /// </summary>
        int damageReduction { get; set; }
        /// <summary>
        /// Location which the armor protects
        /// </summary>
        string location { get; set; }
        /// <summary>
        /// Penalty to Dexterity checks for wearing the armor
        /// </summary>
        int penalty { get; set; }
        /// <summary>
        /// Defines how durable the armor is. If its durability gets reduced to 0, armor shatters and no longer reduces damage
        /// </summary>
        int durability { get; set; }

        /// <summary>
        /// Allows to reduce damage taken by a creature.
        /// This method is meant to be used as a part of Creature.Damage() method.
        /// Every point of damageReduction reduces damage by one tier.
        /// Every point of armorPenetation reduces damageReduction by one.
        /// </summary>
        /// <returns>Wound of a lesser tier or null if damage gets completely reduced</returns>
        public IWound reduceDamage(IWound wound, int armorPenetration)
        {
            double damageReduction = this.damageReduction;
            damageReduction -= armorPenetration;
            double damagePoints = wound.damagePoints;
            //TO-DO: Serious and critical wounds reduce durability (by 1 and 3 respectively), but only when damage is made by a melee weapon.
            double woundTier = Math.Log(damagePoints, 3);
            if (damageReduction >= woundTier)
            {
                return null;
            }
            double reducedDamage = Math.Pow(damagePoints, 1 / (damageReduction + 1));
            switch (reducedDamage)
            {
                case 1: return new Graze();
                case 3: return new LightWound();
                case 9: return new SeriousWound();
                case 27: return new CriticalWound();
                default: throw new Exception("Damage reduction erro");
            }
        }
    }
}