﻿/*
 * Author: Jakob Benelli
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Test class for the Sailor Soda
    /// </summary>
    public class SailorSodaTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            SailorSoda s = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(s);
        }

        /// <summary>
        /// Checks to see if it is a drink
        /// </summary>
        [Fact]
        public void ShouldBeDrink()
        {
            SailorSoda s = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(s);
        }

        /// <summary>
        /// Checks to see if the boolean value for ice is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.True(s.Ice);
        }

        /// <summary>
        /// Checks to see if the size is set to small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.Equal(Size.Small, s.Size);
        }

        /// <summary>
        /// Checks to see if the flavor is cherry by default
        /// </summary>
        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, s.Flavor);
        }

        /// <summary>
        /// Checks to see if the user can set the boolean value of ice to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda s = new SailorSoda();
            s.Ice = true;
            Assert.True(s.Ice);
            s.Ice = false;
            Assert.False(s.Ice);
        }

        /// <summary>
        /// Checks to see if the user can set the size to small, medium or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda s = new SailorSoda();
            s.Size = Size.Large;
            Assert.Equal(Size.Large, s.Size);
            s.Size = Size.Medium;
            Assert.Equal(Size.Medium, s.Size);
            s.Size = Size.Small;
            Assert.Equal(Size.Small, s.Size);
        }

        /// <summary>
        /// Checks to see if the user can choose or "set" the flavor
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda s = new SailorSoda();
            s.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, s.Flavor);
            s.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, s.Flavor);
            s.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, s.Flavor);
            s.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, s.Flavor);
            s.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, s.Flavor);
            s.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, s.Flavor);
        }

        /// <summary>
        /// Checks to see if the correct price matches the correct size
        /// </summary>
        /// <param name="size">The size of the soda</param>
        /// <param name="price">The price of the soda</param>
        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda s = new SailorSoda();
            s.Size = size;
            Assert.Equal(price, s.Price);
        }

        /// <summary>
        /// Checks to see if the calories match the correct size
        /// </summary>
        /// <param name="size"></param>
        /// <param name="cal"></param>
        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda s = new SailorSoda();
            s.Size = size;
            Assert.Equal(cal, s.Calories);
        }

        /// <summary>
        /// Checks to see if the correct special instructions are displayed
        /// </summary>
        /// <param name="includeIce">Whether or not the customer wants ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]

        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda s = new SailorSoda();
            s.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", s.SpecialInstructions);
            else Assert.Empty(s.SpecialInstructions);
        }
        
        /// <summary>
        /// Checks to see if the correct toString value is returned
        /// </summary>
        /// <param name="flavor">The flavor of the soda</param>
        /// <param name="size">The size of the soda</param>
        /// <param name="name">The toString return value of the soda</param>
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda s = new SailorSoda();
            s.Flavor = flavor;
            s.Size = size;
            Assert.Equal(name, s.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var s = new SailorSoda();

            Assert.PropertyChanged(s, "Ice", () =>
            {
                s.Ice = true;
            });

            Assert.PropertyChanged(s, "Ice", () =>
            {
                s.Ice = false;
            });
        }

        [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            var s = new SailorSoda();

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.Flavor = SodaFlavor.Cherry;
            });

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.Flavor = SodaFlavor.Grapefruit;
            });

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.Flavor = SodaFlavor.Lemon;
            });

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.Flavor = SodaFlavor.Peach;
            });

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.Flavor = SodaFlavor.Watermelon;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeNotifiesSizeProperty(Size s)
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.PropertyChanged(a, "Size", () =>
            {
                a.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeNotifiesPriceProperty(Size s)
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.PropertyChanged(a, "Price", () =>
            {
                a.Size = s;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeChangeNotifiesCaloriesProperty(Size s)
        {
            MarkarthMilk a = new MarkarthMilk();
            Assert.PropertyChanged(a, "Calories", () =>
            {
                a.Size = s;
            });
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var c = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        /// <summary>
        /// Checks to see if the correct Description value is returned
        /// </summary>
        /// <param name="d">The Description return value for the item</param>
        [Theory]
        [InlineData("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.")]
        public void ShouldReturnCorrectDescription(string d)
        {
            SailorSoda aj = new SailorSoda();
            Assert.Equal(d, aj.Description);
        }
    }
}
