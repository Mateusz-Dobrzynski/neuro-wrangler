using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class AbilityTest
    {
        public void TestAbility()
        {
            Human collinwood = new Human("", "", "", "", true, "James Collinwood", new Stats(15, 15, 15, 15, 15), new Abilities(), 27);
            //ApplyModifierPercentage used on all the stats modifies the modifierPercentage of all stats
            collinwood.stats.ApplyModifierPercentage(60);
            Debug.Assert(collinwood.stats.charisma.modifierPercentage == 60);
            Debug.Assert(collinwood.stats.constitution.modifierPercentage == 60);
            Debug.Assert(collinwood.stats.dexterity.modifierPercentage == 60);
            Debug.Assert(collinwood.stats.intelligence.modifierPercentage == 60);
            Debug.Assert(collinwood.stats.perception.modifierPercentage == 60);

            //ApplyModifierPercentage used on a single ability modfifies its ModifierPercentage
            collinwood.stats.dexterity.ApplyModifierPercentage(-30);
            Debug.Assert(collinwood.stats.dexterity.modifierPercentage == 30);
            collinwood.stats.intelligence.ApplyModifierPercentage(40);
            Debug.Assert(collinwood.stats.intelligence.modifierPercentage == 100);

            //ApplyModifierPercentage used on a single ability modifies its ModifierPercentage
            collinwood.abilities.rifles.ApplyModifierPercentage(-30);
            collinwood.abilities.painResistance.ApplyModifierPercentage(50);
            Debug.Assert(collinwood.abilities.painResistance.modifierPercentage == 50);
            Debug.Assert(collinwood.abilities.rifles.modifierPercentage == -30);

            //ApplyModifierInt used on a single stat modifies its AbilityInt
            collinwood.stats.ApplyModifierInt(-3);
            Debug.Assert(collinwood.stats.charisma.modifierInt == -3);
            Debug.Assert(collinwood.stats.constitution.modifierInt == -3);
            Debug.Assert(collinwood.stats.dexterity.modifierInt == -3);
            Debug.Assert(collinwood.stats.intelligence.modifierInt == -3);
            Debug.Assert(collinwood.stats.perception.modifierInt == -3);
        }
    }
}