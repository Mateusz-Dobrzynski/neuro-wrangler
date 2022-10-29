using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Firearm : Weapon
    {
        /// <summary>
        /// Firearm type which determines distance penalty
        /// </summary>
        private string firearmType;
        /// <summary>
        /// Value of damage dealt
        /// </summary>
        int damage;
        /// <summary>
        /// Minimal time in segments it takes to take a shot
        /// </summary>
        private int shootingTime;
        /// <summary>
        /// Time in segments it takes for the weapon to reload
        /// </summary>
        private int reloadTime;
        /// <summary>
        /// If true, firearm has to be reloaded after every shot
        /// </summary>
        private bool repeating;
        /// <summary>
        /// How many points of armor damage reduction will be subtracted
        /// </summary>
        private int armorPenetration;
    }
}