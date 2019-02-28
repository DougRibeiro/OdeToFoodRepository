// using System;
// using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        public string Message { get; set; }
        public string MessageAppConfig { get; set; }
        public IRestaurantData restaurantData { get; set; }
        public IEnumerable<Restaurant> Restaruants { get; set; } 

        [BindProperty(SupportsGet=true)]
        public string SearchTerm {get; set;}
        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Message = "Hello World!";
            MessageAppConfig = config["MessageAppConfig"];
            Restaruants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}