using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class MeleeWeapon : Weapon
    {
        /// <summary>
        /// Dexterity bonus granted in defense during melee combat.
        /// </summary>
        int defenseBonus { get; set; }
        /// <summary>
        /// Dexterity bonus granted in offence during melee combat
        /// </summary>
        int offenceBonus { get; set; }
        /// <summary>
        /// 3 tiers of wounds dealt depending on the amount
        /// of successful tests during melee combat
        /// </summary>
        List<int> damage { get; set; }
    }
}