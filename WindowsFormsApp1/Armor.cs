using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public class Armor : Item
    {
        /// <summary>
        /// How much the damage will be reduced
        /// </summary>
        public int damageReduction { get; set; }
        /// <summary>
        /// Location which the armor protects
        /// </summary>
        public string location { get; set; }
        /// <summary>
        /// Penalty to Dexterity checks for wearing the armor
        /// </summary>
        public int penalty { get; set; }
        /// <summary>
        /// Defines how durable the armor is. If its durability gets reduced to 0, armor shatters and no longer reduces damage
        /// </summary>
        public int durability { get; set; }

        /// <summary>
        /// Allows to reduce damage taken by a creature.
        /// This method is meant to be used as a part of Creature.Damage() method.
        /// Every point of damageReduction reduces damage by one tier.
        /// Every point of armorPenetation reduces damageReduction by one.
        /// </summary>
        /// <returns>Wound of a lesser tier or null if damage gets completely reduced</returns>
        public IWound reduceDamage(IWound wound, Weapon weapon)
        {
            double damageReduction = this.damageReduction;
            damageReduction -= weapon.armorPenetration;
            double damagePoints = wound.damagePoints;
            if (weapon.GetType() == typeof(MeleeWeapon))
            {
                if (wound.damagePoints == 9) this.durability -= 1;
                else if (wound.damagePoints == 27) this.durability -= 3;
                if (this.durability <= 0) {
                    this.durability = 0;
                    this.damageReduction = 0;
                }
                
            }
            double woundTier = Math.Log(damagePoints, 3);
            if (damageReduction >= woundTier)
            {
                return null;
            }
            double reducedWoundTier = woundTier - damageReduction;
            switch (reducedWoundTier)
            {
                case 0: return new Graze();
                case 1: return new LightWound();
                case 2: return new SeriousWound();
                case 3: return new CriticalWound();
                default: throw new Exception("Damage reduction error");
            }
        }
    }
}