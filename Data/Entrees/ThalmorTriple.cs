/*
* Author: Jakob Benelli
* Class name: PhillyPoacher.cs
* Purpose: Class representing the Thalmor Triple. Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        private double price = 8.32;
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
        public uint Calories => 943;

        /// <summary>
        /// Gets whether the customer wants ketchup 
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
        /// Gets if the customer wants tomato
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
        /// Gets if the customer want bacon
        /// </summary>
        private bool bacon;

        public bool Bacon
        {
            get
            {
                return bacon;
            }

            set
            {
                bacon = true;
            }
        }

        /// <summary>
        /// Gets if the customer wants eggs
        /// </summary>
        private bool egg;

        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                egg = true;
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
                if (!Bacon) specialInstructions.Add("Hold bacon");
                if (!Egg) specialInstructions.Add("Hold egg");


                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Thalmor Triple"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
