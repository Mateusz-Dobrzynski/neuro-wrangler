using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Test
    {
        static void Main(string[] args)
        {
            Abilities testAbilities = new Abilities();
            testAbilities.pistols.value = 4;
            Human test = new Human("", "", "", "", true, "Test Human", new Stats(15, 15, 15, 15, 15), testAbilities, 27);
            int pistols = test.abilities.pistols.value;
            int bow = test.abilities.bow.value;
            test.abilities.pistols.modifierPercentage += 30;
            test.abilities.pistols.modifierInt -= 2;
            bool pistolsCheck = test.abilities.pistols.Check(test.stats.dexterity);
        }
    }
}