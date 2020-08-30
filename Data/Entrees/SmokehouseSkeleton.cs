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
    public class SmokehouseSkeleton
    {
        private double price = 5.62;
        /// <summary>
        /// Gets the price of the smokehouse skeleton
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the smokehouse skeleton
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Gets whether the user customer sauasage link or not
        /// </summary>

        private bool sausageLink;

        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                sausageLink = true;
            }
        }

        /// <summary>
        /// Gets whether the customer wants eggs or not
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
        /// Gets whether the customer wants hash browns or not
        /// </summary>
        private bool hashBrowns;

        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }

            set
            {
                hashBrowns = true;
            }
        }

        /// <summary>
        /// Gets whether the customer wants pancakes or not
        /// </summary>
        private bool pancake;

        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                pancake = true;
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
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
