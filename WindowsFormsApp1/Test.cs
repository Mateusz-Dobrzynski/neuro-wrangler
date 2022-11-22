using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Test
    {
        static void Main(string[] args)
        {

            Abilities testAbilities = new Abilities();
            testAbilities.pistols.value = 1;
            Human test = new Human("", "", "", "", true, "Test Human", new Stats(15, 15, 15, 15, 15), testAbilities, 27);
            int pistols = test.abilities.pistols.value;
            int bow = test.abilities.bow.value;
            test.abilities.pistols.modifierPercentage += 30;
            test.abilities.pistols.modifierInt -= 2;
            bool pistolsCheck = test.abilities.pistols.Check(test.stats.dexterity);
            int openPistolsCheck = test.abilities.pistols.OpenCheck(test.stats.dexterity);
            AbilityTest abilityTest = new AbilityTest();
            abilityTest.TestAbility();

            Graze graze = new Graze();
            LightWound l = new LightWound();
            SeriousWound s = new SeriousWound();
            test.Damage(graze, new Weapon());
            test.Damage(s, new Weapon());
            test.Damage(l, new Weapon());

            CreatureTest creatureTest = new CreatureTest();
            creatureTest.TestCreature();

           SerializerTest serializerTest = new SerializerTest();
           //serializerTest.TestSerializer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}