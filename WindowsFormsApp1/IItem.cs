using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public interface IItem
    {
        /// <summary>
        /// Type of item used to determine prices in different regions (e.g. Drugs, Weapons, Food)
        /// </summary>
        string gamblingType { get; set; }
        /// <summary>
        /// Name of the item
        /// </summary>
        string name { get; set; }
        /// <summary>
        /// Determines whether item can be thrown or not
        /// </summary>
        bool throwable { get; set; }
    }
}