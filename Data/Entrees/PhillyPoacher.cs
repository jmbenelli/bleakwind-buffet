/*
* Author: Jakob Benelli
* Class name: PhillyPoacher.cs
* Purpose: Class representing the PhillyPoacher. It is a Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Philly Poacher
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double price = 7.23;
        /// <summary>
        /// Gets the price of the Cheesesteak
        /// </summary>
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Gets if the customers wants sirloin
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
            }
        }

        /// <summary>
        /// Gets if the customer wants onion
        /// </summary>
        private bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
            }
        }

        /// <summary>
        /// Gets if the customer wants a roll
        /// </summary>
        private bool roll = true;
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
            }
        }

        /// <summary>
        /// Displays the customers special instructions
        /// </summary>
        /// <Returns>A string list of the customers special instructions</Returns>
        public override List<string> SpecialInstructions
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
        /// <returns>A string describing the Philly Poacher</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
