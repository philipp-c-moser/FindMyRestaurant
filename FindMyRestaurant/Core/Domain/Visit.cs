
using System;

namespace FindMyRestaurant.Core.Domain
{
    public class Visit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfVisit { get; set; }
        public Restaurant Restaurant { get; set; }

    }
}