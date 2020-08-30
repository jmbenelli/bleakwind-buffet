﻿/*
* Author: Jakob Benelli
* Class name: SailorSoda.cs
* Purpose: Class used to create the Sailor Soda
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        public Size Size { get; set; }

        /// <summary>
        /// Gets the price of the soda depending on the size
        /// </summary>
        public double Price
        {
            get 
            {
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the calories of the soda depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                throw new NotImplementedException($"Unknown size of {Size}");
            }

        }

        /// <summary>
        /// Gets whether the customer wants ice or not
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
                ice = true;
            }
        }


        /// <summary>
        /// Gets the flavor the customer wants
        /// </summary>
        private SodaFlavor flavor;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                Flavor = SodaFlavor.Cherry;
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
                if (!Ice) specialInstructions.Add("Hold Ice");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Sailor Soda"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }


    }
}
