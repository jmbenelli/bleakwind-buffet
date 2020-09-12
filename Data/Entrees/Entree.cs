using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the common properties for an Entree
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The price of the Entree
        /// </summary>
        /// <value> In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the Entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the Entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
