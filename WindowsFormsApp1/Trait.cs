﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /*
     * Trait is an interface for Stat and Ability,
     * as they both can be tested in ability or stat checks.
     */
    public class Trait
    {
        /// <summary>
        /// Modifier expressed as intereger. The bigger the value, the easier a trait check becomes.
        /// </summary>
        int modifierInt { get; set; }
        /// <summary>
        /// Modifier expressed as percentage. The bigger the value, the more difficult a trait check becomes.
        /// </summary>
        int modifierPercentage { get; set; }
        /// <summary>
        /// Trait value
        /// </summary>
        int value { get; set; }
        /// <summary>
        /// Trait check is used to determine, whether a creature succeded or failed
        /// at a particular action. To perform a check, one has to roll 3d20.
        /// The highest roll is discarded and the other two have to be below
        /// or equal to trait value.
        /// Not all actions require a trait check.
        /// </summary>
        public bool Check()
        {
            int value = this.value;
            int modifierInt = this.modifierInt;
            int modifierPercentage = this.modifierPercentage;
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}