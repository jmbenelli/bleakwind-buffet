/*
* Author: Jakob Benelli
* Class name: BriarheartBuger.cs
* Purpose: Class representing the Briarheart Buger. It is a Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class describing the Briarheart Buger
    /// </summary>
    public class BriarheartBurger : Entree, IOrderItem
    {
        private double price = 6.32;
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories
        /// </summary>
        public override uint Calories => 743;

        /// <summary>
        /// Gets whether or not the customer wants ketchup
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                ketchup = value;
            }
        }

        /// <summary>
        /// Gets whther or not the customer wants a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets whether or not the customer wants mustard
        /// </summary>
        private bool mustard = true;
        public bool Mustard 
        {
            get => mustard;
            set => mustard = value;
        }

        /// <summary>
        /// Gets whether or not the customer wants a pickle
        /// </summary>
        private bool pickle = true;

        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                pickle = value;
            }
        }

        /// <summary>
        /// Gets whether or not the customer wants cheese
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                cheese = value;
            }
        }

        /// <summary>
        /// If the customer has special instructions it says them here
        /// </summary>
        /// <Returns>A string list of the customers special instructions</Returns>
        public override List<string> SpecialInstructions
        {
            get 
            {
                List<string> specialInstructions = new List<string>();
                if (!Bun)
                {
                    specialInstructions.Add("Hold bun");
                }
                if (!Ketchup) specialInstructions.Add("Hold ketchup");
                if (!Mustard) specialInstructions.Add("Hold mustard");
                if (!Pickle) specialInstructions.Add("Hold pickle");
                if (!Cheese) specialInstructions.Add("Hold cheese");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Briarheart Burger"
        /// </summary>
        /// <returns>A string describing the burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
