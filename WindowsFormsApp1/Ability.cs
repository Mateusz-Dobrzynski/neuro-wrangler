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
        ///public int baseStat { get; set; }

        /// <summary>
        /// Ability check is used to determine, whether a creature succeded or failed
        /// at a particular action. To perform a check, one has to roll 3d20.
        /// The highest roll is discarded and the other two have to be below
        /// or equal to base stat value. One can lower results of the rools by the total of ability's value
        /// </summary>
        /// 
        public Ability(int modifierInt, int modifierPercentage, int value)
        {
            this.modifierInt = modifierInt;
            this.modifierPercentage = modifierPercentage;
            this.value = value;
        }
        public new bool Check(List<Int16> diceRolls)
        {
            int modifierInt = this.modifierInt;
            int modifierPercentage = this.modifierPercentage;
            int value = this.value;
            int passCount = 0;
            bool passed;
            ///pora na spaghetti code!
            if(modifierPercentage <= 0)
            {
                int diffMod = (int)DifficultyLevels.Easy;
                modifierInt += diffMod;
            }
            else if(modifierPercentage > 0 && modifierPercentage <= 10)
            {
                int diffMod = (int)DifficultyLevels.Normal;
                modifierInt += diffMod;
            }
            else if (modifierPercentage > 10 && modifierPercentage <= 30)
            {
                int diffMod = (int)DifficultyLevels.Problematic;
                modifierInt += diffMod;
            }
            else if (modifierPercentage > 30 && modifierPercentage <= 60)
            {
                int diffMod = (int)DifficultyLevels.Hard;
                modifierInt += diffMod;
            }
            else if (modifierPercentage > 60 && modifierPercentage <= 90)
            {
                int diffMod = (int)DifficultyLevels.VeryHard;
                modifierInt += diffMod;
            }
            else if (modifierPercentage > 90 && modifierPercentage <= 120)
            {
                int diffMod = (int)DifficultyLevels.DamnHard;
                modifierInt += diffMod;
            }
            else
            {
                int diffMod = (int)DifficultyLevels.LuckyHard;
                modifierInt += diffMod;
            }
            value += modifierInt;
            diceRolls.Sort();
            diceRolls.RemoveAt(2);
            foreach(Int16 x in diceRolls)
            {
                if(x <= value)
                {
                    passCount++;
                }
            }
            if(passCount == 2)
            {
                passed = true;
            }
            else { passed = false; }

            return passed;
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
        public int CalculateDifficulty(Stat baseStat)
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