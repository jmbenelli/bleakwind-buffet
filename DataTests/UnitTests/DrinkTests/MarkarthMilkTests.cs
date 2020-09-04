﻿/*
 * Author: Jakob Benelli
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Test class for the Markarth Milk
    /// </summary>
    public class MarkarthMilkTests
    {
        /// <summary>
        /// Checks to see if the boolean value for ice is false by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.False(m.Ice);
        }

        /// <summary>
        /// Checks to see if the size is small by default
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.Equal(Size.Small, m.Size);
        }

        /// <summary>
        /// Checks to see if the user is able to set ice to either true or false
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Ice = true;
            Assert.True(m.Ice);
            m.Ice = false;
            Assert.False(m.Ice);
        }

        /// <summary>
        /// Checks to see if the user is able to set the size to small, medium, or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = Size.Large;
            Assert.Equal(Size.Large, m.Size);
            m.Size = Size.Medium;
            Assert.Equal(Size.Medium, m.Size);
            m.Size = Size.Small;
            Assert.Equal(Size.Small, m.Size);
        }

        /// <summary>
        /// Checks to see if the correct price matches with the correct size
        /// </summary>
        /// <param name="size">The size of the milk</param>
        /// <param name="price">The price of the milk</param>
        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(price, m.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories match with the correct size
        /// </summary>
        /// <param name="size">The size of the milk</param>
        /// <param name="cal">The calories of the milk</param>
        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(cal, m.Calories);
        }

        /// <summary>
        /// Checks to see if the customers special instructions are displayed correctly
        /// </summary>
        /// <param name="includeIce">Whether or not the customer wants ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Ice = includeIce;
            if (!includeIce) Assert.Contains("Add ice", m.SpecialInstructions);
            else Assert.Empty(m.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the tostring value of the milk is returned correctly
        /// </summary>
        /// <param name="size">The size of the milk</param>
        /// <param name="name">The tostring return value of the milk</param>
        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(name, m.ToString());
        }
    }
}