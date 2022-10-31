using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public interface IWound
    {
        string location { get; set; }
        DifficultyLevels painResillienceTestDifficulty { get; set; }
        int penalty { get; set; }
    }
}