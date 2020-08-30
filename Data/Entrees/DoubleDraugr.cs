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
    public class DoubleDraugr
    {
        private double price = 7.32;
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the Calories of the burger
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// Gets if the customer wants ketchup
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
        /// Gets if the customer wants a bun
        /// </summary>
        private bool bun;

        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = true;
            }
        }

        /// <summary>
        /// Gets if the customer wants mustard
        /// </summary>
        private bool mustard;

        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = true;
            }
        }

        /// <summary>
        /// Gets if the customer wants a pickle
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
        /// Gets if the customer wants cheese
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
        /// Gets if the customer wants tomato.
        /// </summary>
        private bool tomato;

        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                tomato = true;
            }
        }

        /// <summary>
        /// Gets if the customer wants lettuce
        /// </summary>
        private bool lettuce;

        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                lettuce = true;
            }
        }

        /// <summary>
        /// Gets if the customer wants mayo
        /// </summary>
        private bool mayo;

        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                mayo = true;
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
                if (!Bun)
                {
                    specialInstructions.Add("Hold bun.");
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
