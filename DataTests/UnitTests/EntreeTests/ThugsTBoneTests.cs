/*
 * Author: Jakob Benelli
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Test class for Thugs T-Bone
    /// </summary>
    public class ThugsTBoneTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            ThugsT_Bone t = new ThugsT_Bone();
            Assert.IsAssignableFrom<IOrderItem>(t);
        }

        /// <summary>
        /// Checks to see if the it is an Entree
        /// </summary>
        [Fact]
        public void ShouldBeEntree()
        {
            ThugsT_Bone t = new ThugsT_Bone();
            Assert.IsAssignableFrom<Entree>(t);
        }

        /// <summary>
        /// Checks to see if the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsT_Bone t = new ThugsT_Bone();
            Assert.Equal(6.44, t.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsT_Bone t = new ThugsT_Bone();
            Assert.Equal(982, (int) t.Calories);
        }

        /// <summary>
        /// Checks to see if the correct user special instructions are displayed
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsT_Bone t = new ThugsT_Bone();
            Assert.Empty(t.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the correct ToString value is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsT_Bone t = new ThugsT_Bone();
            Assert.Equal("Thugs T-Bone", t.ToString());
        }
    }
}