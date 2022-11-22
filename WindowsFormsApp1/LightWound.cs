using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public class LightWound : IWound
    {
        public int damagePoints { get; } = 3;
        public string location { get; set; }
        public DifficultyLevels painResistanceTestDifficulty { get; } = DifficultyLevels.Problematic;
        public int penalty { get; set; } = 15;
    }
}