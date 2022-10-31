using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Abilities testAbilities = new Abilities();
            testAbilities.pistols.value = 4;
            Human test = new Human("", "", "", "", true, "Test Human", new Stats(10, 10, 10, 10, 10), testAbilities, 27, 27);
            int pistols = test.abilities.pistols.value;
            int bow = test.abilities.bow.value;
            int sum = pistols + bow;
        }
    }
}