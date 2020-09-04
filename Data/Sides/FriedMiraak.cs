﻿/*
* Author: Jakob Benelli
* Class name: FriedMiraak.cs
* Purpose: Class used to create the Fried Miraak
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing the Fried Miraak
    /// </summary>
    public class FriedMiraak
    {
        /// <summary>
        /// Getter and setter using the size enum
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Gets the price of the fried miraak depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.78;
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Large) return 2.88;
                throw new NotImplementedException($"Unknown size of {Size}");
            }


        }

        /// <summary>
        /// Gets the calories of the fried miraak depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 151;
                if (Size == Size.Medium) return 236;
                if (Size == Size.Large) return 306;
                throw new NotImplementedException($"Unknown size of {Size}");
            }

        }


        /// <summary>
        /// Overrides the ToString() method to display "Fried Miraak"
        /// </summary>
        /// <returns>A string describing the Fried Miraak</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
