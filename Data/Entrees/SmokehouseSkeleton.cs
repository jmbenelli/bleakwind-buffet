/*
* Author: Jakob Benelli
* Class name: PhillyPoacher.cs
* Purpose: Class representing the Smokehouse Skeleton. Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        private double price = 5.62;
        /// <summary>
        /// Gets the price of the smokehouse skeleton
        /// </summary>
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the smokehouse skeleton
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets whether the user customer sauasage link or not
        /// </summary>

        private bool sausageLink = true;

        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                sausageLink = value;
            }
        }

        /// <summary>
        /// Gets whether the customer wants eggs or not
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                egg = value;
            }
        }


        /// <summary>
        /// Gets whether the customer wants hash browns or not
        /// </summary>
        private bool hashBrowns = true;

        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }

            set
            {
                hashBrowns = value;
            }
        }

        /// <summary>
        /// Gets whether the customer wants pancakes or not
        /// </summary>
        private bool pancake = true;

        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                pancake = value;
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
                if (!SausageLink) specialInstructions.Add("Hold sausage");
                if (!Egg) specialInstructions.Add("Hold egg");
                if (!HashBrowns) specialInstructions.Add("Hold hash browns");
                if (!Pancake) specialInstructions.Add("Hold pancake");
                
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Smokehouse Skeleton"
        /// </summary>
        /// <returns>A string describing the Smokehouse Skeleton</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
