﻿/*
* Author: Jakob Benelli
* Class name: VokunSalad.cs
* Purpose: Class used to create the Vokun Salad
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwinBuffet.Data.Sides
{
    public class VokunSalad
    {
        public Size Size { get; set; } 

        /// <summary>
        /// Gets the price of the salad depending on size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return .93;
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                throw new NotImplementedException($"Unknown size of {Size}");
            }


        }

        /// <summary>
        /// Gets the calories of the salad depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                throw new NotImplementedException($"Unknown size of {Size}");
            }

        }

        /// <summary>
        /// Overrides the ToString() value to display "Vokun Salad"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }
    }
}
