/*
 * Author: Jakob Benelli
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Test class for the Philly Poacher
    /// </summary>
    public class PhillyPoacherTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(p);
        }

        /// <summary>
        /// Checks to see if the it is an Entree
        /// </summary>
        [Fact]
        public void ShouldBeEntree()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(p);
        }

        /// <summary>
        /// Checks to see if the boolean value for sirloin is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Sirloin);
        }

        /// <summary>
        /// Checks to see if the boolean value for onion is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Onion);
        }

        /// <summary>
        /// Checks to see if the boolean value for roll is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Roll);
        }

        /// <summary>
        /// Checks to see if the user is able to set the value for sirloin to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = true;
            Assert.True(p.Sirloin);
            p.Sirloin = false;
            Assert.False(p.Sirloin);
        }

        /// <summary>
        /// Checks to see if the user is able to set the value for onions to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Onion = true;
            Assert.True(p.Onion);
            p.Onion = false;
            Assert.False(p.Onion);
        }

        /// <summary>
        /// Checks to see if the user is able to set the value for rolls to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Roll = true;
            Assert.True(p.Roll);
            p.Roll = false;
            Assert.False(p.Roll);
        }

        /// <summary>
        /// Checks to see if the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal(7.23, p.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal(784, (int) p.Calories);
        }

        /// <summary>
        /// Checks to see if the users special instructions are displayed
        /// </summary>
        /// <param name="includeSirloin">Whether or not the user wants sirloin</param>
        /// <param name="includeOnion">Whether or not the user wants onion</param>
        /// <param name="includeRoll">Whether or not the user wants a roll</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = includeSirloin;
            p.Onion = includeOnion;
            p.Roll = includeRoll;
            if (!includeSirloin) Assert.Contains("Hold sirloin", p.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onion", p.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", p.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the corect ToString value is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal("Philly Poacher", p.ToString());
        }
    }
}