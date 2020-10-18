using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing a combo
    /// </summary>
    public class Combo : INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// Property change event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor that creates our combo
        /// </summary>
        /// <param name="e">Entree</param>
        /// <param name="s">Side</param>
        /// <param name="d">Drink</param>
        public Combo(Entree e, Side s, Drink d)
        {
            Entree = e;
            Side = s;
            Drink = d;
        }

        public Combo()
        {
        }

        /// <summary>
        /// Price property that gets the price of our combo
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 1;
            }
            set
            {
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));

            }
        }

        /// <summary>
        /// Calories property that gets the calories of our combo
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
            set
            {
                calories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));

            }
        }

        /// <summary>
        /// Special Instructions property that gets the special instructions of our combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                specialInstructions.Add(Entree.ToString());
                specialInstructions.AddRange(Entree.SpecialInstructions);
                specialInstructions.Add(Drink.ToString());
                specialInstructions.AddRange(Drink.SpecialInstructions);
                specialInstructions.Add(Side.ToString());
                specialInstructions.AddRange(Side.SpecialInstructions);
                return specialInstructions;

            }
        }

        /// <summary>
        /// Drink property that gets and sets our drink for our combo
        /// </summary>
        private Drink d;
        public Drink Drink
        {
            get
            {
                return d;
            } 
            set
            {
                d = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));

            }
        }

        /// <summary>
        /// Entree property that gets and sets our entree for our combo
        /// </summary>
        private Entree e;
        public Entree Entree
        {
            get
            {
                return e;
            }
            set
            {
                e = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));

            }
        }

        /// <summary>
        /// Side property that gets and sets our Side for our combo
        /// </summary>
        private Side s;
        public Side Side
        {
            get
            {
                return s;
            }
            set
            {
                s = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
            }
        }
    }
}
