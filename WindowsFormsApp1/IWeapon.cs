using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public interface IWeapon
    {
        /// <summary>
        /// The amount of armor damageReduction points that weapon ignores
        /// </summary>
        int armorPenetration { get; set; }
        /// <summary>
        /// Ability tested when using the weapon
        /// </summary>
        Ability relatedAbility { get; set; }
        /// <summary>
        /// Constitution required to use the item without getting lumbered with penalty
        /// </summary>
        int requiredConst { get; set; }
    }
}