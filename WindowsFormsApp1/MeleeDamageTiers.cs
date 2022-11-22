using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Some melee weapons deal different damage depending on the constitution
    /// of the character wealding it.
    /// </summary>
    public class MeleeDamageTiers
    {
        /// <summary>
        /// Constitution required to deal given damage
        /// </summary>
        int requiredConst { get; }
        List<IWound> damageTiers { get; set; }

        public MeleeDamageTiers(int requiredConst, IWound firstTier, IWound secondTier, IWound thirdTier)
        {
            this.requiredConst = requiredConst;
            this.damageTiers[0] = firstTier;
            this.damageTiers[1] = secondTier;
            this.damageTiers[2] = thirdTier;
        }
    }
}