/*
* Author: Jakob Benelli
* Class name: MadOtarGrits.cs
* Purpose: Class used to create the Mad Otar Grits
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing the Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Getter and setter for the size using the size enum
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// Gets the price of the grits depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.22;
                if (Size == Size.Medium) return 1.58;
                if (Size == Size.Large) return 1.93;
                throw new NotImplementedException($"Unknown size of {Size}");
            }


        }

        /// <summary>
        /// Gets the calories of the grits depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 105;
                if (Size == Size.Medium) return 142;
                if (Size == Size.Large) return 179;
                throw new NotImplementedException($"Unknown size of {Size}");
            }

        }

        /// <summary>
        /// Overrides the ToString() method to display "Mad Otar Grits"
        /// </summary>
        /// <returns>A string describing the Mad Otar Grits</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
