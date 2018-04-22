using RestaurantReviews.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantReviews.Library
{
    public class Restaurant:IReviewable
    {
        public string  Name { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public string PhoneNumber { get; set; }




        public float CalculateAverageRating()
        {
            float sum = 0f;
            
            foreach(var i in Reviews)
            {
                sum += i.Rating;
            }

            return sum / Reviews.Count;

        }

        public void AddReview(Review rate)
        {
            Reviews.Add(rate);
        }

       

    }
}
