using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Wound : IWound
    {
        public string location { get; set; } = "undefined";
        public DifficultyLevels painResillienceTestDifficulty { get; set; }
        public int penalty { get; set; }

        public Wound(DifficultyLevels painResillienceTestDifficulty, int penalty)
        {
            this.painResillienceTestDifficulty = painResillienceTestDifficulty;
            this.penalty = penalty;
        }
    }
}