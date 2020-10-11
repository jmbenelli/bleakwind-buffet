/*
 * Author: Jakob Benelli
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Test class for the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeletonTests
    {
        /// <summary>
        /// Checks to see if the IOrderInterface Class is implemented
        /// </summary>
        [Fact]
        public void ShouldBeAssignableToAbstractIOrderInterfaceClass()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(s);
        }

        /// <summary>
        /// Checks to see if the it is an Entree
        /// </summary>
        [Fact]
        public void ShouldBeEntree()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(s);
        }

        /// <summary>
        /// Checks to see if the boolean value for sausages is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.SausageLink);
        }

        /// <summary>
        /// Checks to see if the boolean value for egg is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.Egg);
        }

        /// <summary>
        /// Checks to see if the boolean value for hashbrowns is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.HashBrowns);
        }

        /// <summary>
        /// Checks to see if the boolean value for pancakes is set to true by default
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.Pancake);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for sausage to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.SausageLink = true;
            Assert.True(s.SausageLink);
            s.SausageLink = false;
            Assert.False(s.SausageLink);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for egg to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.Egg = true;
            Assert.True(s.Egg);
            s.Egg = false;
            Assert.False(s.Egg);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for hasbrowns to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.HashBrowns = true;
            Assert.True(s.HashBrowns);
            s.HashBrowns = false;
            Assert.False(s.HashBrowns);
        }

        /// <summary>
        /// Checks to see if the user is able to set the boolean value for pancakes to either true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.Pancake = true;
            Assert.True(s.Pancake);
            s.Pancake = false;
            Assert.False(s.Pancake);
        }

        /// <summary>
        /// Checks to see if the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal(5.62, s.Price);
        }

        /// <summary>
        /// Checks to see if the correct calories are returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal(602, (int) s.Calories);
        }

        /// <summary>
        /// Checks to see if the correct special instructions are displayed
        /// </summary>
        /// <param name="includeSausage">Whether or not the user wants sausage</param>
        /// <param name="includeEgg">Whether or not the user wants eggs</param>
        /// <param name="includeHashbrowns">Whether or not the user wants hashbrowns</param>
        /// <param name="includePancake">Whether or not the user wants pancakes</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.SausageLink = includeSausage;
            s.Egg = includeEgg;
            s.HashBrowns = includeHashbrowns;
            s.Pancake = includePancake;
            if (!includeSausage) Assert.Contains("Hold sausage", s.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", s.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", s.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancake", s.SpecialInstructions);

        }

        /// <summary>
        /// Checks to see if the correct ToString value is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", s.ToString());
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            var s = new SmokehouseSkeleton();

            Assert.PropertyChanged(s, "Sausage Link", () =>
            {
                s.SausageLink = true;
            });

            Assert.PropertyChanged(s, "Sausage Link", () =>
            {
                s.SausageLink = false;
            });
        }

        [Fact]
        public void ChangingEggLinkNotifiesEggProperty()
        {
            var s = new SmokehouseSkeleton();

            Assert.PropertyChanged(s, "Egg", () =>
            {
                s.Egg = true;
            });

            Assert.PropertyChanged(s, "Egg", () =>
            {
                s.Egg = false;
            });
        }

        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownsProperty()
        {
            var s = new SmokehouseSkeleton();

            Assert.PropertyChanged(s, "Hash Browns", () =>
            {
                s.HashBrowns = true;
            });

            Assert.PropertyChanged(s, "Hash Browns", () =>
            {
                s.HashBrowns = false;
            });
        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            var s = new SmokehouseSkeleton();

            Assert.PropertyChanged(s, "Pancake", () =>
            {
                s.Pancake = true;
            });

            Assert.PropertyChanged(s, "Pancake", () =>
            {
                s.Pancake = false;
            });
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var c = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }
    }
}