using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class CriticalWound : IWound
    {
        public int damagePoints { get; } = 27;
        public string location { get; set; }
        public DifficultyLevels painResistanceTestDifficulty { get; set; }
        public int penalty { get; set; } = 160;
    }
}