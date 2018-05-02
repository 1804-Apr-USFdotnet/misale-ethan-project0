using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using RestaurantReviews.Models;



namespace RestuarantReviews.DAL
{
    public class RestaurantCRUD
    {
        RestaurantDBEntities db = new RestaurantDBEntities();
            
        public IEnumerable<Restaurant> ShowRestaurants()
        {
            return db.Restaurants.ToList();
        }

        public Restaurant SearchByRestaurantID(int id)
        {
            Restaurant restaurant = db.Restaurants.Find(id);
            return restaurant;

        }

        public void InsertRestaurant(RestaurantReviews.Models.Restaurant restaurant)
        {
            db.Restaurants.Add(LibraryToDataRestaurant(restaurant));
            db.SaveChanges();
        }

        public void DeleteRestaurant(int id)
        {
            Restaurant restaurant = db.Restaurants.Find(id);
            db.Restaurants.Remove(restaurant);
            db.SaveChanges();

        }

        public Restaurant LibraryToDataRestaurant(RestaurantReviews.Models.Restaurant restaurant)
        {
            Restaurant rest = new Restaurant()
            {
                Address = restaurant.Address,
                City = restaurant.City,
                PhoneNumber = restaurant.PhoneNumber,
                State = restaurant.State,
                Id = restaurant.Id,
                Name = restaurant.Name,
               
                
            };

            return rest;
        }

        public RestaurantReviews.Models.Restaurant DataToLibraryRestaurant(Restaurant restaurant)
        {
            RestaurantReviews.Models.Restaurant rest = new RestaurantReviews.Models.Restaurant()
            {
                Address = restaurant.Address,
                City = restaurant.City,
                PhoneNumber = restaurant.PhoneNumber,
                State = restaurant.State,
                Id = restaurant.Id,
                Name = restaurant.Name
            };
                if (restaurant.AvgRating is null) {
                rest.AvgRating = 0;
                }
                 else
                {
                rest.AvgRating = (double)(restaurant.AvgRating);
                }
            

            return rest;
        }

        public IEnumerable<Review> ShowReviews()
        {
            return db.Reviews.ToList();
        }

        public Review SearchByReviewID(int id)
        {
            Review review = db.Reviews.Find(id);
            return review;
        }


        public void InsertReview(RestaurantReviews.Models.Review review)
        {
            db.Reviews.Add(LibrayToDataReview(review));
            db.SaveChanges();
        }

        public void DeleteReview(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
            db.SaveChanges();

        }
        public Review LibrayToDataReview(RestaurantReviews.Models.Review review)
        {
            Review rev = new Review()
            {
                Id = review.Id,
                Comment = review.Comment,
                RestaurantId = review.RestaurantId,
                Rating = review.Rating

            };

            return rev;
        }

        public RestaurantReviews.Models.Review DataToLibraryReview(Review review)
        {
            RestaurantReviews.Models.Review rev = new RestaurantReviews.Models.Review()
            {
                Id = review.Id,
                Comment = review.Comment,
                RestaurantId = review.RestaurantId,
                Rating = review.Rating
            };

            return rev;

        }

        public IEnumerable<Restaurant> SearchByPartialName(string name)
        {
            var part = name.Length;
            var rest = db.Restaurants.ToList();
            var partname = rest.FindAll(x => x.Name.Substring(0, part).Equals(name));
            return partname;
        }


    }

}
