using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Graze : IWound
    {
        public int damagePoints { get; } = 1;
        public string location { get; set; }
        public DifficultyLevels painResistanceTestDifficulty { get; } = DifficultyLevels.Normal;
        public int penalty { get; set; } = 5;
    }
}