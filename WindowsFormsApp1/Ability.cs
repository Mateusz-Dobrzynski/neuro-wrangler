using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Ability : Trait
    {
        /// <summary>
        /// Stat related to given ability
        /// </summary>

        public int modifierInt { get; set; } = 0;

        public int modifierPercentage { get; set; } = 0;

        public int value { get; set; } = 0;

        /// <summary>
        /// Ability check is used to determine, whether a creature succeded or failed
        /// at a particular action. To perform a check, one has to roll 3d20.
        /// The highest roll is discarded and the other two have to be below
        /// or equal to base stat value. One can lower results of the rools by the total of ability's value
        /// </summary>
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