/*
* Author: Jakob Benelli
* Class name: MarkarthMilk.cs
* Purpose: Class used to create the Markarth Milk
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Gets the price of the milk deepending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.05;
                if (Size == Size.Medium) return 1.11;
                if (Size == Size.Large) return 1.22;
                throw new NotImplementedException($"Unknown size of {Size}");
            }
        }

        /// <summary>
        /// Gtets the calories of the milk depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the calories for the size is not known 
        /// </exception>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 56;
                if (Size == Size.Medium) return 72;
                if (Size == Size.Large) return 93;
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
        private bool ice = false;
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
        /// Displays the users special instructions
        /// </summary>
        /// <Returns>A string list describing the customers special instructions</Returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!Ice) specialInstructions.Add("Add ice");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to display "Markarth Milk"
        /// </summary>
        /// <returns>A string describing the milk</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }

        /// <summary>
        /// Description of item
        /// </summary>
        public string Description
        {
            get
            {
                return "Hormone-free organic 2% milk.";
            }
        }


    }
}
