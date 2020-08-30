/*
* Author: Jakob Benelli
* Class name: GardenOrcOmelette.cs
* Purpose: Class representing the Garden Orc Omelette. It is a Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        private double price = 4.57;
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Gets if the customer wants broccoli
        /// </summary>
        private bool broccoli;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }

            set
            {
                broccoli = true;
            }
        }

        /// <summary>
        /// Gets if the user wants mushrooms
        /// </summary>
        private bool mushrooms;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                mushrooms = true;
            }
        }

        /// <summary>
        /// Gets if the user wants tomato
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
        /// Gets if the user wants cheddar
        /// </summary>
        private bool cheddar;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                cheddar = true;
            }
        }

        /// <summary>
        /// Displays the users special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Broccoli) specialInstructions.Add("Hold broccoli");
                if (!Mushrooms) specialInstructions.Add("Hold mushrooms");
                if (!Tomato) specialInstructions.Add("Hold tomato");
                if (!Cheddar) specialInstructions.Add("Hold cheddar");
                     
                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Garden Orc Omelette"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }


}
