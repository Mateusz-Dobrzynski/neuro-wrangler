using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class MeleeWeapon : Weapon
    {
        int defenseBonus { get; set; }
        int offenceBonus { get; set; }
        int initiativeBonus { get; set; }
        /// <summary>
        /// 3 tiers of wounds dealt depending on the amount
        /// of successful tests during melee combat
        /// </summary>
        List<int> damage { get; set; }
    }
}