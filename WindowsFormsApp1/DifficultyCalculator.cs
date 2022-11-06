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
    }
}