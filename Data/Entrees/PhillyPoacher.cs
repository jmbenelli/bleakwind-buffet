/*
* Author: Jakob Benelli
* Class name: PhillyPoacher.cs
* Purpose: Class representing the PhillyPoacher. It is a Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        private double price = 7.23;
        /// <summary>
        /// Gets the price of the Cheesesteak
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Gets if the customers wants sirloin
        /// </summary>
        private bool sirloin;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                sirloin = true;
            }
        }

        /// <summary>
        /// Gets if the customer wants onion
        /// </summary>
        private bool onion;
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                onion = true;
            }
        }

        /// <summary>
        /// Gets if the customer wants a roll
        /// </summary>
        private bool roll;
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = true;
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
                if (!Sirloin) specialInstructions.Add("Hold sirloin");
                if (!Onion) specialInstructions.Add("Hold onion");
                if (!Roll) specialInstructions.Add("Hold roll");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() to display "Philly Poacher"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
