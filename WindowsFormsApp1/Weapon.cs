using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Weapon : Item
    {
        /// <summary>
        /// Constitution required to use the weapon without getting lumbered with penalties
        /// </summary>
        int requiredConst;
        /// <summary>
        /// Number of points subtracted from a target's armor damage reduction
        /// </summary>
        int armorPenetration;
        /// <summary>
        /// Ability tested while using the weapon
        /// </summary>
        private string relatedAbility;
    }
}