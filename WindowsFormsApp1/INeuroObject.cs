using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    /// <summary>
    /// The most basic interface which stores information needed to save an object as a JSON file
    /// </summary>
    public interface INeuroObject
    {
        /// <summary>
        /// Name of the object. Object will be saved under this name
        /// </summary>
        string name { get; set; }
    }
}