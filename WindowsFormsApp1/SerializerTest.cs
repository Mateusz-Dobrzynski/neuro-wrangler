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
            //TestSaving();
            TestLoading();
        }

        private void TestSaving()
        {
            Abilities woodsAbilities = new Abilities();
            woodsAbilities.rifles.value = 4;
            Human woods = new Human("", "", "", "", true, "Jackson Woods", new Stats(10, 10, 10, 10, 10), woodsAbilities, 27);
            Serializer s = new Serializer();
            s.Save(woods, @"C:\Users\gryzo\Desktop\neuro-files");
        }
        private void TestLoading()
        {
            Serializer s = new Serializer();
            Human loadedWoods = s.Load(@"C:\Users\gryzo\Desktop\neuro-files\Jackson Woods.json");
        }
    }
}