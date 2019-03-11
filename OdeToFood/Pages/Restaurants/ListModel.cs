// using System;
// using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private  ILogger logger;
        public string Message { get; set; }
        public string MessageAppConfig { get; set; }
        public IRestaurantData restaurantData { get; set; }
        
        public IEnumerable<Restaurant> Restaruants { get; set; } 

        [BindProperty(SupportsGet=true)]
        public string SearchTerm {get; set;}
        public ListModel(IConfiguration config, IRestaurantData restaurantData, ILogger <ListModel> logger)
        {
            this.config = config;
            this.restaurantData = restaurantData;
            this.logger = logger;
        }

        public void OnGet()
        {

            logger.LogError("Hello from the logger service!!!");
            Message = "Hello World!";
            MessageAppConfig = config["MessageAppConfig"];
            Restaruants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}