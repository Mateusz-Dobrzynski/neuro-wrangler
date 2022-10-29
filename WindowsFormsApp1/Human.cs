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

        public bool alive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int[,] coordinatesPostion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Stats stats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int maxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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