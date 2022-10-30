using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}