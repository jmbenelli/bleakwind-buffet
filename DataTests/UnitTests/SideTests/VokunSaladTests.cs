/*
 * Author: Jakob Benelli
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Test class for the Vokun Salad
    /// </summary>
    public class VokunSaladTests
    {
        /// <summary>
        /// Checks to see if the size is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad v = new VokunSalad();
            Assert.Equal(Size.Small, v.Size);
        }

        /// <summary>
        /// Checks to see if the user can set the size to small, medium, or large
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad v = new VokunSalad();
            v.Size = Size.Large;
            Assert.Equal(Size.Large, v.Size);
            v.Size = Size.Medium;
            Assert.Equal(Size.Medium, v.Size);
            v.Size = Size.Small;
            Assert.Equal(Size.Small, v.Size);
        }

        /// <summary>
        /// Checks to see if the correct special instructions are returned,
        /// but in this case there are no special instructions for sides
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            return;
        }

        /// <summary>
        /// Checks to see if the correct price is returned depending on size
        /// </summary>
        /// <param name="size">The size of the salad</param>
        /// <param name="price">The price of the salad</param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad v = new VokunSalad();
            v.Size = size;
            Assert.Equal(price, v.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are retruned depending on size
        /// </summary>
        /// <param name="size">The size of the salad</param>
        /// <param name="calories">The calories of the salad</param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad v = new VokunSalad();
            v.Size = size;
            Assert.Equal(calories, v.Calories);
        }

        /// <summary>
        /// Checks to see if the correct tostring value is returned
        /// </summary>
        /// <param name="size">The size of the salad</param>
        /// <param name="name">The toString return value</param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad v = new VokunSalad();
            v.Size = size;
            Assert.Equal(name, v.ToString());
        }
    }
}