using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Core.Domain
{
    public class RestaurantCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Restaurant> Restaurants { get; set; }
    }
}