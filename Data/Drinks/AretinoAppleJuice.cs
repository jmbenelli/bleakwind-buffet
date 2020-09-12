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
    /// <summary>
    /// Class representing the Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        

        /// <summary>
        /// Gets the price of the juice depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public override double Price
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
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public override uint Calories
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
        private bool ice = false;
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// Displays the customers special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (Ice) specialInstructions.Add("Add ice");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display " Aretino Apple Juice"
        /// </summary>
        /// <returns>A string describing the juice</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
