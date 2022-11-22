using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace WindowsFormsApp1
{
    public class SerializerTest
    {
       public void TestSerializer()
        {
            string path = @"C:\Users\gryzo\Desktop\neuro-files\";
            Serializer s = new Serializer();

            //Saves and loads creatures
            Creature creature1 = new Creature();
            creature1.name = "Test Creature 1";
            //s.Save(creature1, path);
            Creature loadedCreature1 = s.Load<Creature>($"{path}Test Creature 1.json");

             //Saves and loads humans
            Abilities woodsAbilities = new Abilities();
            woodsAbilities.rifles.value = 4;
            Human woods = new Human("", "", "", "", true, "Jackson Woods", new Stats(10, 10, 10, 10, 10), woodsAbilities, 27);
            //s.Save(woods, path);
            Human loadedWoods = s.Load<Human>($"{path}Jackson Woods.json");

            //Saves and loads weapons
            Firearm ak = new Firearm();
            ak.throwable = false;
            ak.armorPenetration = 2;
            ak.name = "AK-47";
            //s.Save(ak, path);
            Firearm loadedAk = s.Load<Firearm>($"{path}AK-47.json");
       }
    }
}