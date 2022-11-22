using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Wounds in Neuroshima come in 4 tiers.
    /// Every tier has its respective implementation
    /// in a derived class of this interface.
    /// </summary>
    public interface IWound
    {
        /// <summary>
        /// Number of health points subtracted from creature's health upon taking damage.
        /// </summary>
        int damagePoints { get; }
        string location { get; set; }
        /// <summary>
        /// Difficulty level of Pain Resistance check.
        /// </summary>
        DifficultyLevels painResistanceTestDifficulty { get; }
        /// <summary>
        /// Percentage modifier applied to all stats upon taking damage.
        /// If Pain Resistance check is failed, the penalty gets doubled
        /// (except the Critical Wound)
        /// </summary>
        int penalty { get; set; }
    }
}