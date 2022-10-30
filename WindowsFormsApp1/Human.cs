using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Human : ICreature
    {
        public string background;
        public string backgroundTrait;
        public string profession;
        public string professionTrait;

        public bool alive { get; set; }
        public int[,] coordinatesPostion { get; set; }
        public string name { get; set; }
        public Stats stats { get; set; }
        public int maxHealth { get; set; }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Damage()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }
    }
}