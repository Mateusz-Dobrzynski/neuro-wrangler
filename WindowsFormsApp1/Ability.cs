using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace WindowsFormsApp1
{
    public class Ability : Stat
    {
        /// <summary>
        /// Stat related to given ability
        /// </summary>


        /// <summary>
        /// Ability check is used to determine, whether a creature succeded or failed
        /// at a particular action. To perform a check, one has to roll 3d20.
        /// The highest roll is discarded and the other two have to be below
        /// or equal to base stat value. One can lower results of the rools by the total of ability's value
        /// </summary>
        /// <remarks>
        /// TO-DO: If ability value equals 0, difficulty level should increase by one tier
        /// <br></br>
        /// To research: Can the method somehow get the base stat value without taking an argument?
        /// </remarks>
        /// <returns>
        /// A boolean value representing either passed (true) or failed (false) ability check
        /// </returns>
        public bool Check(Stat baseStat, DifficultyLevels difficulty = DifficultyLevels.Normal)
        {
            int modifierInt = this.modifierInt;
            int modifierPercentage = this.modifierPercentage;
            int abilityValue = this.value;
            int passCount = 0;
            int upperRollValue = baseStat.value;
            //modifierPercentage is converted into an int and added to modifierInt
            DifficultyCalculator difficultyCalculator = new DifficultyCalculator();
            modifierInt += difficultyCalculator.ModifierPercentageConversion(modifierPercentage);
            upperRollValue += modifierInt;
            //3d20 roll is performed
            DiceRoller diceRoller = new DiceRoller();
            List < Int16 > diceRolls = diceRoller.Roll3d20();
            diceRolls.Sort();
            //For every roll equal to 1, difficulty is decreased
            //For every roll equal to 20, difficulty is increased
            for (int i = 0; i < 3; i++)
            {
                if (diceRolls[i] == 1)
                {
                    difficulty = difficultyCalculator.Slider(difficulty, -1);
                }
                else if (diceRolls[i] == 20)
                {
                    difficulty = difficultyCalculator.Slider(difficulty, 1);
                }
            }
            upperRollValue += (int)difficulty;
            //The highest roll is discarded
            diceRolls.RemoveAt(2);
            //The other two rolls have to be lower or equal to upper roll value
            for (int i = 0; i < 2; i++)
            {
                int currentRoll = diceRolls[i];
                if (currentRoll <= upperRollValue) passCount++;
                else if (abilityValue > 0)
                {
                    int missingPoints = currentRoll - upperRollValue; 
                    //Reducing the rollCurrent by abilityValue to pass the test
                    if (missingPoints <= abilityValue)
                    {
                        passCount++;
                        abilityValue -= missingPoints;
                    }
                }
            }
            if (passCount == 2) return true;
            else return false;
        }

        public bool Contest(Ability ability, Stat baseStat, Ability opponentAbility, Stat opponentBaseStat)
        {
            while (true)
            {
                int advantagePoints = this.OpenCheck(baseStat);
                int opponentPoints = opponentAbility.OpenCheck(opponentBaseStat);
                if (advantagePoints > opponentPoints) return true;
                else if (opponentPoints > advantagePoints) return false;
            }
        }

        public int OpenCheck(Stat baseStat, int additionalDifficulty = 0)
        {
            int modifierInt = this.modifierInt;
            int modifierPercentage = this.modifierPercentage;
            int abilityValue = this.value;
            int upperRollValue = baseStat.value;
            //modifierPercentage is converted into an int and added to modifierInt
            DifficultyCalculator difficultyCalculator = new DifficultyCalculator();
            modifierInt += difficultyCalculator.ModifierPercentageConversion(modifierPercentage);
            modifierInt += additionalDifficulty;
            upperRollValue += modifierInt;
            //3d20 roll is performed
            DiceRoller diceRoller = new DiceRoller();
            List<Int16> diceRolls = diceRoller.Roll3d20();
            diceRolls.Sort();
            //The highest and lowest roll is discarded
            diceRolls.RemoveAt(2);
            diceRolls.RemoveAt(0);
            int currentRoll = diceRolls[0];
            int advantagePoints;
            if (currentRoll - abilityValue <= upperRollValue) { advantagePoints = upperRollValue - currentRoll - abilityValue; }
            else { advantagePoints = upperRollValue - currentRoll - abilityValue; }
            return advantagePoints;

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