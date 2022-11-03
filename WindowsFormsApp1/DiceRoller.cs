using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class DiceRoller
    {
        /// <summary>
        /// Allows to simulate 3d20 rolls
        /// </summary>
        /// <returns>
        /// List containing 3 random integers between 1 and 20 representing 3d20 roll
        /// </returns>
        public List<Int16> Roll3d20()
        {
            List<Int16> diceRolls = new List<Int16>(3);
            for(int i = 0; i < 3; i++)
            {
                Random randNum = new Random();
                int x = randNum.Next(1, 21);
                diceRolls.Add(x);
            }
            return diceRolls;
        }

        /// <summary>
        /// Allows to simulate any number of d20 rolls
        /// </summary>
        /// <returns>
        /// List of x random integers between 1 and 20
        /// </returns>
        public List<int> Rollxd20(int x)
        {
            throw new System.NotImplementedException();
        }
    }
}