using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    public class Restaurant
    {
        public string  Name { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public float AverageRating { get; set; }
        public string PhoneNumber { get; set; }


        public Restaurant()
        {

        }

        public void AddReview(Review rate)
        {
            Reviews.Add(rate);
        }

       

    }
}
