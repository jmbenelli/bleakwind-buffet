/*
* Author: Jakob Benelli
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to create the Dragon Born Waffle Fries
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        public Size Size { get; set; }
        /// <summary>
        /// Used to get the price of the fries depending on size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return .42;
                if (Size == Size.Medium) return .76;
                if (Size == Size.Large) return .96;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Used to get the calories of the fries depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                if (Size == Size.Medium) return 89;
                if (Size == Size.Large) return 100;
                throw new NotImplementedException($"Unknown size of {Size}");
            }

        }

        /// <summary>
        /// Overrides the ToString() method to display Dragonbron Waffle Fries
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
