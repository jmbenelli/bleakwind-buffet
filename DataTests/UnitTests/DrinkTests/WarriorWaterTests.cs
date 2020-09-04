/*
 * Author: Jakob Benelli
 * Class: WarriorWaterTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;


namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Test class for the Warrior Water
    /// </summary>
    public class WarriorWaterTests
    {
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
    }
}