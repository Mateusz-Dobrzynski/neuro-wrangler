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
            Human test = new Human("", "", "", "", true, "Test Human", new Stats(10, 10, 10, 10, 10), testAbilities, 27);
            int pistols = test.abilities.pistols.value;
            int bow = test.abilities.bow.value;
            test.abilities.pistols.modifierPercentage += 30;
            /*if (test.abilities.pistols.Check())
            {
                Console.WriteLine("Check passed");
            }*/
            test.abilities.pistols.modifierInt -= 2;
            DiceRoller diceRoller = new DiceRoller();
            List<Int16> diceRolls = diceRoller.Roll3d20();
            Ability ability = new Ability(0, 30, 15);
            bool abilityCheck = ability.Check(diceRolls);
        }
    }
}