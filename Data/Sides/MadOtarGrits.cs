/*
* Author: Jakob Benelli
* Class name: MadOtarGrits.cs
* Purpose: Class used to create the Mad Otar Grits
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwinBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        public Size Size { get; set; }
        /// <summary>
        /// Gets the price of the grits depending on size
        /// </summary>
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
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
