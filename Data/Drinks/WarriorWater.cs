/*
* Author: Jakob Benelli
* Class name: WarriorWater.cs
* Purpose: Class used to create the WarriorWater
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        public Size Size { get; set; }

        /// <summary>
        /// Gets the price of the water depending on size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 0;
                if (Size == Size.Medium) return 0;
                if (Size == Size.Large) return 0;
                throw new NotImplementedException($"Unknown size of {Size}");
            }


        }

        /// <summary>
        /// Gets the calories of the water depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 0;
                if (Size == Size.Medium) return 0;
                if (Size == Size.Large) return 0;
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
        /// Gets whether the customer wants lemon or not
        /// </summary>
        private bool lemon;
        public bool Lemon
        {
            get
            {
                return lemon;
            }

            set
            {
                lemon = false;
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
                if (!Ice) specialInstructions.Add("Hold ice");
                if (!lemon) specialInstructions.Add("Add lemon");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString method to display "Warrior Water
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
