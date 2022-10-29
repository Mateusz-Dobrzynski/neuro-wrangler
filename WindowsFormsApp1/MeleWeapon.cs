using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class MeleWeapon : Weapon
    {
        int defenseBonus;
        int offenceBonus;
        private int initiativeBonus;
        private List<Int16> damage;
    }
}