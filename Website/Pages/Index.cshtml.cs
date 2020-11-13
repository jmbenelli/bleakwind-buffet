using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Declares our Menu Items property
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; set; } = Menu.FullMenu();


        /// <summary>
        /// Declares out categories property that keeps track of our categories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public static string[] Categories { get; set; }

        /// <summary>
        /// Declares out searchterms property that keeps track of the terms we search
        /// </summary>
        public string SearchTerms { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Calls our filter methods
        /// </summary>
        /// <param name="SearchTerms">Our search terms</param>
        /// <param name="MinCal">minimum calories</param>
        /// <param name="MaxCal">maximum calories</param>
        /// <param name="MinPrice">minimum price</param>
        /// <param name="MaxPrice">maximum price</param>
        public void OnGet(string SearchTerms, int? MinCal, int? MaxCal, double? MinPrice, double? MaxPrice, string[] Categories)
        {
            MenuItems = Menu.FullMenu();
            // Search movie titles for the SearchTerms
            if (SearchTerms != null)
            {
                IEnumerable<IOrderItem> results = new List<IOrderItem>();
                string[] temp = SearchTerms.Split(" ");
                List<IOrderItem> final = new List<IOrderItem>();

                foreach (string t in temp)
                {
                    results = MenuItems.Where(menu => menu.ToString() != null && menu.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || menu.Description.Contains(t, StringComparison.InvariantCultureIgnoreCase));
                    final.AddRange(results.ToList());
                }
                MenuItems = final;
            }
            //MenuItems = Menu.Search(MenuItems, SearchTerms);

            
            if (Categories != null && Categories.Length != 0)
            {
                MenuItems = MenuItems.Where(menu => menu is Entree && Categories.Contains("Entree") || menu is Side && Categories.Contains("Side") || menu is Drink && Categories.Contains("Drink"));

            }
            //MenuItems = Menu.FilterByCategory(MenuItems, Categories); 

            if (MinCal != null && MaxCal != null)
            {
                MenuItems = MenuItems.Where(menu => menu.Calories < MaxCal);
                MenuItems = MenuItems.Where(menu => menu.Calories > MinCal);
            }
            //MenuItems = Menu.FilterByCalories(MenuItems, MinCal, MaxCal);

            if (MinPrice != null && MaxPrice != null)
            {
                MenuItems = MenuItems.Where(menu => menu.Price < MaxPrice);
                MenuItems = MenuItems.Where(menu => menu.Price > MinPrice);
            }
            //MenuItems = Menu.FilterByPrice(MenuItems, MinPrice, MaxPrice);

        }
    }
}
