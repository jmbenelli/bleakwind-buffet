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
    public class BriarheartBurger
    {
        private double price = 6.32;
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories
        /// </summary>
        public uint Calories => 743;

        /// <summary>
        /// Gets whether or not the customer wants ketchup
        /// </summary>
        private bool ketchup;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                ketchup = true;
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
        private bool pickle;

        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                pickle = true;
            }
        }

        /// <summary>
        /// Gets whether or not the customer wants cheese
        /// </summary>
        private bool cheese;
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                cheese = true;
            }
        }

        /// <summary>
        /// If the customer has special instructions it says them here
        /// </summary>
        public List<string> SpecialInstructions
        {
            get 
            {
                List<string> specialInstructions = new List<string>();
                if (!Bun)
                {
                    specialInstructions.Add("Hold bun.");
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
