using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Core.Domain
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        public IList<RestaurantCategory> RestaurantCategories { get; set; }
    }
}