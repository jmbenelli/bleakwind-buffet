/*
* Author: Jakob Benelli
* Class name: DoubleDraugr.cs
* Purpose: Class representing the Double Draugr. It is a Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem
    {
        private double price = 7.32;
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the Calories of the burger
        /// </summary>
        public override uint Calories => 843;

        /// <summary>
        /// Gets if the customer wants ketchup
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
        /// Gets if the customer wants a bun
        /// </summary>
        private bool bun = true;

        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = value;
            }
        }

        /// <summary>
        /// Gets if the customer wants mustard
        /// </summary>
        private bool mustard = true;

        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = value;
            }
        }

        /// <summary>
        /// Gets if the customer wants a pickle
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
        /// Gets if the customer wants cheese
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
        /// Gets if the customer wants tomato.
        /// </summary>
        private bool tomato = true;

        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                tomato = value;
            }
        }

        /// <summary>
        /// Gets if the customer wants lettuce
        /// </summary>
        private bool lettuce = true;

        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                lettuce = value;
            }
        }

        /// <summary>
        /// Gets if the customer wants mayo
        /// </summary>
        private bool mayo = true;

        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                mayo = value;
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
                if (!Bun)
                {
                    specialInstructions.Add("Hold bun");
                }
                if (!Ketchup) specialInstructions.Add("Hold ketchup");
                if (!Mustard) specialInstructions.Add("Hold mustard");
                if (!Pickle) specialInstructions.Add("Hold pickle");
                if (!Cheese) specialInstructions.Add("Hold cheese");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Lettuce) specialInstructions.Add("Hold lettuce");
                if (!Mayo) specialInstructions.Add("Hold mayo");
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Double Draugr"
        /// </summary>
        /// <returns>A string describing the Double Draugr</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
