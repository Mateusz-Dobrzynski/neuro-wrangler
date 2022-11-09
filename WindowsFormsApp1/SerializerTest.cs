using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class SerializerTest
    {
       public void TestSerializer()
        {
            Abilities woodsAbilities = new Abilities();
            woodsAbilities.rifles.value = 4;
            Human woods = new Human("", "", "", "", true, "Jackson Woods", new Stats(10, 10, 10, 10, 10), woodsAbilities, 27);
            Serializer s = new Serializer();
            s.Save(woods, @"c:/");
            
        }
    }
}