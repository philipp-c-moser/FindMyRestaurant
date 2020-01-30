using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Core.Dto.Visit
{
    public class SaveVisitDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfVisit { get; set; }
        public Domain.Restaurant Restaurant { get; set; }
    }
}