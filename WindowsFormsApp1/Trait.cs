using System;
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
        /// Modifier expressed as intereger
        /// </summary>
        int modifierInt { get; set; }
        /// <summary>
        /// Modifier expressed as percentage
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
        /// Not all actions require a trait check
        /// </summary>
        bool Check()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Contests are performed when two characters try to perform opposing actions. This method returns the winner of the contest
        /// </summary>
        object Contest()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Open check determines, how well a certain action was performed. Open checks are used for example during contests or when initiative order is being determined
        /// </summary>
        int OpenCheck()
        {
            throw new NotImplementedException();
        }
    }
}