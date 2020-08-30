/*
* Author: Jakob Benelli
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to create the Aretino Apple Juice
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        public Size Size { get; set; }

        /// <summary>
        /// Gets the price of the juice depending on size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return .62;
                if (Size == Size.Medium) return .87;
                if (Size == Size.Large) return 1.01;
                throw new NotImplementedException($"Unknown size of {Size}");
            }


        }

        /// <summary>
        /// Gets the calories of the juice depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 44;
                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                throw new NotImplementedException($"Unknown size of {Size}");
            }

        }

        /// <summary>
        /// Gets if the customer wants ice or not
        /// </summary>
        private bool ice;
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = false;
            }
        }

        /// <summary>
        /// Displays the customers special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) specialInstructions.Add("Add Ice");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display " Aretino Apple Juice"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
