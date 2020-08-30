/*
* Author: Jakob Benelli
* Class name: CandlehearthCoffee.cs
* Purpose: Class used to create the CandleHearthCoffee
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        public Size Size { get; set; }

        /// <summary>
        /// Gets the price of the coffee depending on size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return .75;
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Large) return 1.75;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the calories of the coffee depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 7;
                if (Size == Size.Medium) return 10;
                if (Size == Size.Large) return 20;
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
        /// Gets whether the customer wants cream or not
        /// </summary>
        private bool roomForCream;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }

            set
            {
                roomForCream = false;
            }
        }

        /// <summary>
        /// Gets if the customer wants decaf or not
        /// </summary>
        private bool decaf;
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = false;
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
                if (!Ice) specialInstructions.Add("Add ice");
                if (!roomForCream) specialInstructions.Add("Add cream");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Candlehearth Coffee"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Candlehearth Coffee";
        }
    }
}
