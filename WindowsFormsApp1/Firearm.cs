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
        public string firearmType;
        /// <summary>
        /// Value of damage dealt
        /// </summary>
        public IWound damage;
        /// <summary>
        /// Minimal time in segments it takes to take a shot
        /// </summary>
        public int shootingTime;
        /// <summary>
        /// Time in segments it takes for the weapon to reload
        /// </summary>
        public int reloadTime;
        /// <summary>
        /// If true, firearm has to be reloaded after every shot
        /// </summary>
        public bool repeating;
       /// <summary>
        /// If true, burst shooting is possible with this weapon.
        /// </summary>
        public bool burstShooting;
        /// <summary>
        /// Defines a multiplier used to determine how many bullets will be shot
        /// during brust shooting.
        /// </summary>
        public int fireRate = 0;
    }
}