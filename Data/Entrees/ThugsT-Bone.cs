/*
* Author: Jakob Benelli
* Class name: PhillyPoacher.cs
* Purpose: Class representing Thugs T-Bone. Juicy T-Bone not much else to say
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsT_Bone
    {
        private double price = 6.44;
        /// <summary>
        /// Gets the price of the T-Bone
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// Displays the users special instructions
        /// </summary>
        public List<string> SpecialInstructions
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
