/*
* Author: Jakob Benelli
* Class name: Menu.cs
* Purpose: Class used to create the full menu
*/
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.Linq;

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

        /// <summary>
        /// Method that searches through the terms and returns what the user searched for
        /// </summary>
        /// <param name="menuItems">The menu items</param>
        /// <param name="s">The string the user enters</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menuItems, string s)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (s == null) return menuItems;
            if (menuItems == null) return menuItems;

            foreach (IOrderItem item in menuItems)
            {
                if (item.ToString() != null && item.ToString().Contains(s))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Populates our categories
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink",
            };
        }

        /// <summary>
        /// This method filters through our categories and returns what category the user enters
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="s">The category the user enters</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> s)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (s == null || s.Count() == 0) return items;

            foreach (IOrderItem i in items)
            {
                if (s.Contains("Entree") && i is Entree)
                {
                    results.Add(i);
                }
                else if (s.Contains("Side") && i is Side)
                {
                    results.Add(i);
                }
                else if (s.Contains("Drink") && i is Drink)
                {
                    results.Add(i);
                }
                else return items;
            }
            return results;  
        }

        /// <summary>
        /// This method filters through the menu items that fits the users entered calories
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="min">The minimum calories</param>
        /// <param name="max">The maximum calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null && max == null) return items;

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }


            foreach (IOrderItem i in items)
            {
                if (i.Calories >= min && i.Calories <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }

        /// <summary>
        /// This method filters through the menu items for a users desired price
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="min">The minimum price</param>
        /// <param name="max">The maximum price</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null && max == null) return items;

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem i in items)
            {
                if (i.Price > min && i.Price < max)
                {
                    results.Add(i);
                }
            }
            return results;
        }
    }
}
