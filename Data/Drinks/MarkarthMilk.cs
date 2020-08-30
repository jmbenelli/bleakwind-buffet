/*
* Author: Jakob Benelli
* Class name: MarkarthMilk.cs
* Purpose: Class used to create the Markarth Milk
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffetData.Drinks
{
    public class MarkarthMilk
    {
        public Size Size { get; set; }

        /// <summary>
        /// Gets the price of the milk deepending on size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.05;
                if (Size == Size.Medium) return 1.11;
                if (Size == Size.Large) return 1.22;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gtets the calories of the milk depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 56;
                if (Size == Size.Medium) return 72;
                if (Size == Size.Large) return 93;
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
                ice = false;
            }
        }

        /// <summary>
        /// Displays the users special instructions
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
        /// Overrides the ToString() method to display "Markarth Milk"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
