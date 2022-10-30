using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Wounds in Neuroshima come in 4 tiers.
    /// Every tier is three times as severe
    /// as the previous one - they scale exponentially.
    /// Every human can take wounds with
    /// total value no bigger than 27.
    /// Beyond that, their life is at danger
    /// </summary>
    public enum WoundTiers
    {
        Graze = 1,
        LightWound = 3,
        SeriousWound = 9,
        CriticalWound = 27
    }
}