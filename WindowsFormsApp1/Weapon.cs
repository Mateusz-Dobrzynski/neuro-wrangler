using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Weapon : Item
    {
        /// <summary>
        /// Constitution required to use the weapon
        /// without getting lumbered with penalties
        /// </summary>
        int requiredConst { get; set; }
        /// <summary>
        /// Number of points subtracted from
        /// a target's armor damage reduction
        /// </summary>
        public int armorPenetration { get; set; } = 0;
        /// <summary>
        /// Ability tested while using the weapon
        /// </summary>
        string relatedAbility { get; set; }
    }
}