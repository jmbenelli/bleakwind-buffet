using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        public void SettingPriceShouldNotifyPrice()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, "Price", () => { c.Price = 1; });
        }

        public void SettingCaloriesShouldNotifyCalories()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, "Calories", () => { c.Calories = 1; });
        }

        public void SettingDrinkShouldNotifyDrink()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, "Drink", () => { _ = c.Drink; });
        }

        public void SettingEntreeShouldNotifyEntree()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, "Entree", () => { _ = c.Entree; });
        }

        public void SettingSidesShouldNotifySides()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, "Side", () => { _ = c.Side; });
        }











    }
}
