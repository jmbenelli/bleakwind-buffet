﻿/*
 * Author: Jakob Benelli
 * Class: WarriorWaterTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{

    /// <summary>
    /// Test class for the Warrior Water
    /// </summary>
    public class WarriorWaterTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(w);
        }

        /// <summary>
        /// Checks to see if it is a drink
        /// </summary>
        [Fact]
        public void ShouldBeDrink()
        {
            WarriorWater w = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(w);
        }
        /// <summary>
        /// Checks to see if the boolean value of ice is set to true by default
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.True(w.Ice);
        }

        /// <summary>
        /// Checks to see if the boolean value of lemon is set to false by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.False(w.Lemon);
        }

        /// <summary>
        /// Checks to see if the size is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.Equal(Size.Small, w.Size);
        }

        /// <summary>
        /// Checks to see if the user can set the ice to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater w = new WarriorWater();
            w.Ice = true;
            Assert.True(w.Ice);
            w.Ice = false;
            Assert.False(w.Ice);
        }

        /// <summary>
        /// Checks to see if the user can set the size to small, medium, or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater w = new WarriorWater();
            w.Size = Size.Large;
            Assert.Equal(Size.Large, w.Size);
            w.Size = Size.Medium;
            Assert.Equal(Size.Medium, w.Size);
            w.Size = Size.Small;
            Assert.Equal(Size.Small, w.Size);
        }

        /// <summary>
        /// Checks to see if the price matches the correct size
        /// </summary>
        /// <param name="size">The size of the water</param>
        /// <param name="price">The price of the water</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(price, w.Price);

        }

        /// <summary>
        /// Checks to see if the calories match the correct size
        /// </summary>
        /// <param name="size">The size of the water</param>
        /// <param name="cal">The calories of the water</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(cal, w.Calories);
        }

        /// <summary>
        /// Checks to see if the customers special instructions are displayed
        /// </summary>
        /// <param name="includeIce">Whether the customer wants ice or not</param>
        /// <param name="includeLemon">Whether the customer wants lemon or not</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater w = new WarriorWater();
            w.Ice = includeIce;
            w.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", w.SpecialInstructions);
            if (!includeLemon) Assert.Contains("Add lemon", w.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the correct ToString value is returned
        /// </summary>
        /// <param name="size">The size of the water</param>
        /// <param name="name">The tostring return value of the water</param>
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(name, w.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var s = new WarriorWater();

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
        public void ChangingLemonNotifiesLemonProperty()
        {
            var s = new WarriorWater();

            Assert.PropertyChanged(s, "Lemon", () =>
            {
                s.Lemon = true;
            });

            Assert.PropertyChanged(s, "Lemon", () =>
            {
                s.Lemon = false;
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

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var c = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        /// <summary>
        /// Checks to see if the correct Description value is returned
        /// </summary>
        /// <param name="d">The Description return value for the item</param>
        [Theory]
        [InlineData("It’s water. Just water.")]
        public void ShouldReturnCorrectDescription(string d)
        {
            WarriorWater aj = new WarriorWater();
            Assert.Equal(d, aj.Description);
        }
    }
}