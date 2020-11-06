using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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
        public string[] Categories { get; set; } = new string[0];

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
        public void OnGet(string SearchTerms, int? MinCal, int? MaxCal, double? MinPrice, double? MaxPrice)
        {
            MenuItems = Menu.Search(MenuItems, SearchTerms);
            MenuItems = Menu.FilterByCategory(MenuItems, Categories);
            MenuItems = Menu.FilterByCalories(MenuItems, MinCal, MaxCal);
            MenuItems = Menu.FilterByPrice(MenuItems, MinPrice, MaxPrice);

        }
    }
}
