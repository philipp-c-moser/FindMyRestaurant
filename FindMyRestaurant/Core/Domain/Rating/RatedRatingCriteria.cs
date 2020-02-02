using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyRestaurant.Core.Domain.Rating
{
    public class RatedRatingCriteria
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string Comment { get; set; }
        public DateTime RatingDate { get; set; }

        public int RatingId { get; set; }
        public Rating Rating { get; set; }

        public int RatingCriteriaId { get; set; }
        public RatingCriteria RatingCriteria { get; set; }
    }
}