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
        public int baseStat { get; set; }

        /// <summary>
        /// Ability check is used to determine, whether a creature succeded or failed
        /// at a particular action. To perform a check, one has to roll 3d20.
        /// The highest roll is discarded and the other two have to be below
        /// or equal to base stat value. One can lower results of the rools by the total of ability's value
        /// </summary>
        public new bool Check()
        {
            throw new NotImplementedException();
        }

        public new object Contest()
        {
            throw new System.NotImplementedException();
        }

        public new int OpenCheck()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Allows to determine a modifier for a given ability.
        /// </summary>
        /// <returns>
        /// A signle integer representing modifier for a given ability.
        /// The bigger the modifier, the easier the ability check becomes.
        /// Modifier can have negative values.
        /// </returns>
        public new int CalculateDifficulty(Stat baseStat)
        {
            int abilityVal = this.value;
            int abilityModInt = this.modifierInt;
            int abilityModPercentage = this.modifierPercentage;
            int baseStatVal = baseStat.value;
            int baseStatModInt = baseStat.modifierInt;
            int baseStatModPercentage = baseStat.modifierPercentage;
            throw new NotImplementedException();
        }
    }
}