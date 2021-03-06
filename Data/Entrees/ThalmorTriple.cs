﻿/*
* Author: Jakob Benelli
* Class name: PhillyPoacher.cs
* Purpose: Class representing the Thalmor Triple. Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A class representing the Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double price = 8.32;
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
        public override uint Calories => 943;

        /// <summary>
        /// Gets whether the customer wants ketchup 
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets if the customer wants tomato
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets if the customer want bacon
        /// </summary>
        private bool bacon = true;

        public bool Bacon
        {
            get
            {
                return bacon;
            }

            set
            {
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets if the customer wants eggs
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (!Bacon) specialInstructions.Add("Hold bacon");
                if (!Egg) specialInstructions.Add("Hold egg");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Thalmor Triple"
        /// </summary>
        /// <returns>A string describing the Thalmor Triple</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

        /// <summary>
        /// Description of item
        /// </summary>
        public string Description
        {
            get
            {
                return " Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
            }
        }
    }
}
