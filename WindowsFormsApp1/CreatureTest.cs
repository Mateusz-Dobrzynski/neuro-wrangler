using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class CreatureTest
    {
        public void TestCreature()
        {
            Creature testCreature = new Creature();
            testCreature.maxHealth = testCreature.currentHealth = 27;

            //Every type of wound can be dealt and healed
            damageAndHealTest(testCreature);
        }
        private void damageAndHealTest(Creature creature)
        {
            //Wound is dealt
            creature.Damage(new SeriousWound(), new Weapon());
            Debug.Assert(creature.currentHealth == 18);
            Debug.Assert(creature.wounds.Count == 1);
            Debug.Assert(creature.wounds[0].penalty == 30 || creature.wounds[0].penalty == 60);
            creature.Heal(60);
            //Health is restored and wound is removed
            Debug.Assert(creature.currentHealth == creature.maxHealth);
            Debug.Assert(creature.wounds.Count == 0);
            //Penalties are removed
            Debug.Assert(creature.stats.charisma.modifierPercentage == 0);
            Debug.Assert(creature.stats.constitution.modifierPercentage == 0);
            Debug.Assert(creature.stats.dexterity.modifierPercentage == 0);
            Debug.Assert(creature.stats.intelligence.modifierPercentage == 0);
            Debug.Assert(creature.stats.perception.modifierPercentage == 0);

            //Critical wound puts creature into an agonal state
            creature.Damage(new CriticalWound(), new Weapon());
            Debug.Assert(creature.alive == true);
            Debug.Assert(creature.currentHealth == 0);

            //Critical wound can be healed
            creature.Heal(160);
            Debug.Assert(creature.currentHealth == 27);
            Debug.Assert(creature.alive == true);

            //Creature can wear armor
            creature.armor = new Armor();
            creature.armor.damageReduction = 2;
            creature.armor.durability = 10;

            //Armor reduces damage from wounds
            Weapon weapon = new Weapon();
            weapon.armorPenetration = 1;
            creature.Damage(new CriticalWound(), weapon);
            Debug.Assert(creature.currentHealth == 18);

            //Healing value can surpass creature's penalties
            creature.Heal(100);
            creature.armor = null;

            //Two critical wounds kill a creature outright
            creature.Damage(new CriticalWound(), new Weapon());
            creature.Damage(new CriticalWound(), new Weapon());
            Debug.Assert(creature.currentHealth == -27);
            Debug.Assert(creature.alive == false);

            //Dead creature cannot be healed
            creature.Heal(160);
            Debug.Assert(creature.currentHealth == -27);
            Debug.Assert(creature.alive == false);

        }
    }
}