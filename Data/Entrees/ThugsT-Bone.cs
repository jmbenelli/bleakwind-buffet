/*
* Author: Jakob Benelli
* Class name: PhillyPoacher.cs
* Purpose: Class representing Thugs T-Bone. Juicy T-Bone not much else to say
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing Thugs T-Bone
    /// </summary>
    public class ThugsT_Bone : Entree, IOrderItem
    {
        private double price = 6.44;
        /// <summary>
        /// Gets the price of the T-Bone
        /// </summary>
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        /// Displays the users special instructions
        /// </summary>
        /// <Returns>A string list of the customers special instructions</Returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display ""Thugs T-Bone"
        /// </summary>
        /// <returns>A string decribing Thugs T-Bone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
