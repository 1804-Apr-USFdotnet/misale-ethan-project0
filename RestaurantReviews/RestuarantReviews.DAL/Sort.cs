using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviews.Models;

namespace RestuarantReviews.DAL
{
    public class Sort
    {

        public static IEnumerable<RestuarantReviews.DAL.Restaurant> SortAscending()
        {
            using (RestaurantDBEntities db = new RestaurantDBEntities())
            {
                var restaurants = db.Restaurants.ToList();
                return restaurants.OrderBy(r => r.Name);
            }

        }

        public static IEnumerable<RestuarantReviews.DAL.Restaurant> SortDescending()
        {
            using (RestaurantDBEntities db = new RestaurantDBEntities())
            {
                var restaurants = db.Restaurants.ToList();
                return restaurants.OrderByDescending(r => r.Name).ToList();
            }

        }

        public static IEnumerable<RestuarantReviews.DAL.Restaurant> SortTopRating()
        {
            using (RestaurantDBEntities db = new RestaurantDBEntities())
            {
                var restaurants = db.Restaurants.ToList();
                return restaurants.OrderByDescending(r => r.CalculateAverageRating()).ToList();



            }

        }


        public static IEnumerable<RestuarantReviews.DAL.Restaurant> SortTop3Rating()
        {
            using (RestaurantDBEntities db = new RestaurantDBEntities())
            {

                var top3 = SortTopRating().ToList();
                return top3.GetRange(0, 3);

            }

        }
    }
}
