using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Stat
    {
        /// <summary>
        /// Modifier expressed as intereger. The bigger the value, the easier a trait check becomes.
        /// </summary>
        public int modifierInt { get; set; }
        /// <summary>
        /// Modifier expressed as percentage. The bigger the value, the more difficult a trait check becomes.
        /// </summary>
        public int modifierPercentage { get; set; }
        /// <summary>
        /// Trait value
        /// </summary>
        public int value { get; set; }
        /// <summary>
        /// Trait check is used to determine, whether a creature succeded or failed
        /// at a particular action. To perform a check, one has to roll 3d20.
        /// The highest roll is discarded and the other two have to be below
        /// or equal to trait value.
        /// Not all actions require a trait check.
        /// </summary>
        /// <param name="difficulty">
        /// Parameter representing difficulty of a check. Is set to normal by default.
        /// </param>
        /// <returns>
        /// A boolean value representing whether a creature passed a check or not.
        /// </returns>
        public bool Check(DifficultyLevels difficulty = DifficultyLevels.Normal)
        {
            //Fields' values are assigned to temporary variables, as they will be modified by this method
            int upperRollValue = this.value;
            int modifierInt = this.modifierInt;
            int modifierPercentage = this.modifierPercentage;
            int passCount = 0;
            DifficultyCalculator difficultyCalculator = new DifficultyCalculator();
            modifierInt += difficultyCalculator.ModifierPercentageConversion(modifierPercentage);
            //Dice rolls are made
            DiceRoller diceRoller = new DiceRoller();
            List < Int16 > diceRolls = diceRoller.Roll3d20();
            //For every roll that equals 1, difficulty is reduced by 1
            //For every roll that equals 20, difficulty is increased by 1
            foreach (int roll in diceRolls) {
                switch (roll)
                {
                    case 1:
                        difficulty = difficultyCalculator.Slider(difficulty, -1);
                        break;
                    case 20:
                        difficulty = difficultyCalculator.Slider(difficulty, 1);
                        break;
                }
            }
            //Final upper roll value is calculated
            modifierInt += (int) difficulty;
            upperRollValue += modifierInt;
            //The highest roll is discarded
            diceRolls.Sort();
            diceRolls.RemoveAt(2);
            //The other two rolls have to be lower or equal to upper roll value
            for (int i = 0; i < 2; i++)
            {
                int currentRoll = diceRolls[i];
                if (currentRoll <= upperRollValue) passCount++;
            }
            if (passCount == 2) return true;
            else return false;
        }
        /// <summary>
        /// Contests are performed when two characters try to perform opposing actions.
        /// The opponents make open checks and compare their scores.
        /// The one with higher open check score wins the contest.
        /// The opponents can make open checks regarding different traits.
        /// </summary>
        /// <returns>
        /// The winner of the contest.
        /// </returns>
        public object Contest()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Open check determines, how well a certain action was performed. Open checks are used for example during contests or when initiative order is being determined
        /// </summary>
        /// <returns>
        /// Integer representing creature's score. The higher, the better.
        /// </returns>
        public int OpenCheck()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Can be used to determine a trait check modifier as a single integer.
        /// </summary>
        public int CalculateDifficulty()
        {
            int difficulty;
            DifficultyCalculator difficultyCalculator = new DifficultyCalculator();
            difficulty = difficultyCalculator.ModifierPercentageConversion(this.modifierPercentage);
            difficulty += this.modifierInt;
            return difficulty;
        }

        /// <summary>
        /// This method allows to modify stat's modifierInt
        /// </summary>
        /// <param name="modifier">
        /// Modifier to be applied.
        /// </param>
        public void ApplyModifierInt(int modifier)
        {
            this.modifierInt += modifier;
        }

        /// <summary>
        /// This method allows to modify stat's modifierPercentage
        /// </summary>
        /// <param name="modifier">
        /// Modifier to be applied.
        /// </param>
        public void ApplyModifierPercentage (int modifier)
        {
            this.modifierPercentage += modifier;
        }
    }
}