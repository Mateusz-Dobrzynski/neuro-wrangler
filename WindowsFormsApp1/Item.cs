using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Item : INeuroObject
    {
        public string name { get; set; }
        /// <summary>
        /// Type of item used to determine prices in different regions (e.g. Drugs, Weapons, Food)
        /// </summary>
        public string gamblingType { get; set; }
        /// <summary>
        /// Bool regarding whether an item can be thrown
        /// </summary>
        public bool throwable { get; set; }
    }
}