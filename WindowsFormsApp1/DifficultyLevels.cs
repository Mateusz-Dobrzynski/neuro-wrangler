using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /*
     * The difficulty levels are modifiers used to
     * increase or decrease difficulty of stats and ability
     * checks. They can be decided upon by the Game Master
     * upfront, but during combat are usually
     * determined by multiplicity of factors such as
     * type of weapon, penalties and others.
     * 
     * Difficulty level is determined in two stages.
     * Firstly, the total modifier percentage is summed.
     * Secondly, it is converted to a specific difficulty
     * level based upon its value.
     */
    public enum DifficultyLevels
    {
        /// <summary>
        /// Below 0%
        /// </summary>
        Easy = 2,
        /// <summary>
        /// Up to 10%
        /// </summary>
        Normal = 0,
        /// <summary>
        /// Up to 30%
        /// </summary>
        Problematic = -2,
        /// <summary>
        /// Up to 60%
        /// </summary>
        Hard = -5,
        /// <summary>
        /// Up to 90%
        /// </summary>
        VeryHard = -8,
        /// <summary>
        /// Up to 120%
        /// </summary>
        DamnHard = -11,
        /// <summary>
        /// Up to 160%
        /// </summary>
        LuckyHard = -15
    }
}