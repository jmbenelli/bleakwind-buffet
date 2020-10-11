using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void SettingSubTotalShouldNotifySubTotal()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "SubTotal", () => { order.SubTotal = 1; });
        }

        [Fact]
        public void SettingSalesTaxRateShouldNotifySalesTaxRate()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "SalesTaxRate", () => { order.SalesTaxRate = 1; });
        }

        [Fact]
        public void SettingTaxShouldNotifyTax()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Tax", () => { order.Tax = 1; });
        }

        [Fact]
        public void SettingTotalShouldNotifyTotal()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Total", () => { order.Total = 1; });
        }

        [Fact]
        public void SettingNumberShouldNotifyNumber()
        {
            var order = new Order();
            Assert.PropertyChanged(order, "Number", () => { order.Number = 1; });
        }

        [Fact]
        public void ShouldBeAbleToRemoveItemsFromOrder()
        {
            var b = new BriarheartBurger();
            var order = new Order();
            order.Add = b;
            order.Remove = b;
            Assert.Equal(0, order.SubTotal);
            Assert.Equal(order, order.Tax);
            Assert.Equal(0, order.Total);

        }
    }
}
