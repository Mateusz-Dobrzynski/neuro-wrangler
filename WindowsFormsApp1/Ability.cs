using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Ability : ITrait
    {
        /// <summary>
        /// Stat related to given ability
        /// </summary>
        public Stat baseStat { get; set; }

        public int modifierInt { get; set; }

        public int modifierPercentage { get; set; }

        public int value { get; set; }

        public bool Check()
        {
            throw new System.NotImplementedException();
        }

        public object Contest()
        {
            throw new System.NotImplementedException();
        }

        public int OpenCheck()
        {
            throw new System.NotImplementedException();
        }
    }
}