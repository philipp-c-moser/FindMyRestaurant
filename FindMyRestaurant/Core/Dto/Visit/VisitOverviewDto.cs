using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Core.Dto.Visit
{
    public class VisitOverviewDto
    {
        public int Id { get; set; }
        public string VisitName { get; set; }
        public string RestaurantName { get; set; }

    }
}