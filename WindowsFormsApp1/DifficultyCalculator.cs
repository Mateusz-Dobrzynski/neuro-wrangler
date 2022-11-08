using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class DifficultyCalculator
    {
        /// <summary>
        /// This function performs a simple conversion from modfier expressed as percentage to modifier expressed as an int
        /// </summary>
        /// <returns>A single integer representing modifier expressed as an int</returns>
        public int ModifierPercentageConversion(int modifierPercentage)
        {
            if(modifierPercentage <= 0) return (int)(DifficultyLevels.Easy);
            else if(modifierPercentage > 0 && modifierPercentage <= 10) return (int)(DifficultyLevels.Normal);
            else if (modifierPercentage > 10 && modifierPercentage <= 30) return(int)(DifficultyLevels.Problematic);
            else if (modifierPercentage > 30 && modifierPercentage <= 60) return (int)(DifficultyLevels.Hard);
            else if (modifierPercentage > 60 && modifierPercentage <= 90) return (int)(DifficultyLevels.VeryHard);
            else if (modifierPercentage > 90 && modifierPercentage <= 120) return (int)(DifficultyLevels.DamnHard);
            else return (int)(DifficultyLevels.LuckyHard);
        }

        /// <summary>
        /// This method allows to modify difficulty levels by scaling them up or down.
        /// </summary>
        /// <param name="slide">
        /// Defines by how many levels the difficulty should be increased.
        /// Negative value of the parameter indicates reduced difficulty.
        /// </param>
        /// <returns>
        /// Difficulty level increased or decreased in accordance with provided slide
        /// </returns>
        public DifficultyLevels Slider(DifficultyLevels initialDifficulty, int slide)
        {
            int difficultyIndex = (int)initialDifficulty;
            difficultyIndex += slide;
            if (difficultyIndex < 0) difficultyIndex = 0;
            else if (difficultyIndex > 6) difficultyIndex = 6;
            switch(difficultyIndex)
            {
                case 0:
                    return DifficultyLevels.Easy;
                case 1:
                    return DifficultyLevels.Normal;
                case 2:
                    return DifficultyLevels.Problematic;
                case 3:
                    return DifficultyLevels.Hard;
                case 4:
                    return DifficultyLevels.VeryHard;
                case 5:
                    return DifficultyLevels.DamnHard;
                case 6:
                    return DifficultyLevels.LuckyHard;
                default:
                    throw new Exception("Slider error");
            }
        }
    }
}