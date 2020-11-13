/*
* Author: Jakob Benelli
* Class name: SailorSoda.cs
* Purpose: Class used to create the Sailor Soda
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class describing the Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the price of the soda depending on the size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public override double Price
        {
            get 
            {
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gets the calories of the soda depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                throw new NotImplementedException($"Unknown size of {Size}");
            }

        }

        private Size s = Size.Small;
        /// <summary>
        /// Overrides the Size property and invokes the property change when the size is changed
        /// </summary>
        public override Size Size
        {
            get
            {
                return s;
            }
            set
            {
                s = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Gets whether the customer wants ice or not
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }


        /// <summary>
        /// Gets the flavor the customer wants
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }

        }

        /// <summary>
        /// Displays the customers special instructions
        /// </summary>
        /// <Returns>A string list describing the customers special instructions</Returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) specialInstructions.Add("Hold ice");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Sailor Soda"
        /// </summary>
        /// <returns>A string describing the soda</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }

        /// <summary>
        /// Description of item
        /// </summary>
        public string Description
        {
            get
            {
                return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            }
        }
    }
}
