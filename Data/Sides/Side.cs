/*
* Author: Jakob Benelli
* Class name: Side.cs
* Purpose: Class used to create the base class for sides
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing the common properties for a Side
    /// </summary>
    public abstract class Side
    {

        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value> In US dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the side
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> emptyList = new List<string>();
                return emptyList;
            }
        }


    }
}
