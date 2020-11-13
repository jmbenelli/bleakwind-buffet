/*
* Author: Jakob Benelli
* Class name: VokunSalad.cs
* Purpose: Class used to create the Vokun Salad
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing the Vokun Salad
    /// </summary>
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
        /// Gets the price of the salad depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return .93;
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                throw new NotImplementedException($"Unknown size of {Size}");
            }


        }

        /// <summary>
        /// Gets the calories of the salad depending on size
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the price for the size is not known 
        /// </exception>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                throw new NotImplementedException($"Unknown size of {Size}");
            }

        }

        /// <summary>
        /// Overrides the ToString() value to display "Vokun Salad"
        /// </summary>
        /// <returns>A string describing the salad</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }

        /// <summary>
        /// Description of item
        /// </summary>
        public string Description
        {
            get
            {
                return "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
            }
        }
    }
}
