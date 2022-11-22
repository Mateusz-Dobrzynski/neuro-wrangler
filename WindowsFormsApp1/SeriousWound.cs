using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class SeriousWound : IWound
    {
        public int damagePoints { get; } = 9;
        public string location { get; set; }
        public DifficultyLevels painResistanceTestDifficulty { get; } = DifficultyLevels.Hard;
        public int penalty { get; set; } = 30;
    }
}