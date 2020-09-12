using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Menu class that represents the full Menu of Bleakwind Buffet
    /// </summary>
    public class Menu
    { 
        /// <summary>
        /// Creates a list of Entrees in IOrderItem
        /// </summary>
        /// <returns>List of IOrderItem entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List <IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new BriarheartBurger());
            entree.Add(new DoubleDraugr());
            entree.Add(new GardenOrcOmelette());
            entree.Add(new PhillyPoacher());
            entree.Add(new SmokehouseSkeleton());
            entree.Add(new ThalmorTriple());
            entree.Add(new ThugsT_Bone());
            return entree;
        }

        /// <summary>
        /// Creates a list of Sides in IOrderItem
        /// </summary>
        /// <returns>List of IOrderItem Sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonbornWaffleFries() { Size = s });
                sides.Add(new FriedMiraak() { Size = s });
                sides.Add(new MadOtarGrits() { Size = s });
                sides.Add(new VokunSalad() { Size = s });
            }
            return sides;

        }

        /// <summary>
        /// Creates a list of Drinks in IOrderItem
        /// </summary>
        /// <returns>List of IOrderItem Drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor i in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drinks.Add(new SailorSoda() { Size = s, Flavor = i }); 
                }
                drinks.Add(new AretinoAppleJuice() { Size = s });
                drinks.Add(new CandlehearthCoffee() { Size = s });
                drinks.Add(new MarkarthMilk() { Size = s });
                drinks.Add(new WarriorWater() { Size = s });
            }
            return drinks;
        }

        /// <summary>
        /// Creates a list of the full Menu in IOrderItem
        /// </summary>
        /// <returns>List of IOrderItem of the full menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(Sides());
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Drinks());
            return fullMenu; 
        }
   
    }
}
