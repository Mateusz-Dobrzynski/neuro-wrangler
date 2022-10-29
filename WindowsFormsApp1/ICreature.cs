using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public interface ICreature
    {
        bool alive { get; set; }
        int[,] coordinatesPostion { get; set; }
        int maxHealth { get; set; }
        string name { get; set; }
        Stats stats { get; set; }

        void Attack();
        void Damage();
        void Heal();
    }
}