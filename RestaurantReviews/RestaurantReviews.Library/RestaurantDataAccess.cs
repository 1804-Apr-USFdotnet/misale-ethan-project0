﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestuarantReviews.DAL;


namespace RestaurantReviews.Library
{
    public class RestaurantDataAccess
    {
        RestaurantCRUD crud = new RestaurantCRUD();
        public IEnumerable<Models.Restaurant> ShowRestaurants()
        {

           var show =  crud.ShowRestaurants();
           var test = new List<Models.Restaurant>();
           foreach(Restaurant rest in show)
            {
                var show1 = crud.DataToLibraryRestaurant(rest);
                test.Add(show1);
            }

            return test;

        }

        public Models.Restaurant SearchByRestaurantID(int id)
        {
           var search = crud.SearchByRestaurantID(id);
            var show =  crud.DataToLibraryRestaurant(search);
            return show;
        }

        public void InsertRestaurant(RestaurantReviews.Models.Restaurant restaurant)
        {
            crud.InsertRestaurant(restaurant);
        }

        public void DeleteRestaurant(int id)
        {
           crud.DeleteRestaurant(id);
        }

        public IEnumerable<Models.Review> ShowReviews()
        {

            var show = crud.ShowReviews();
            var test = new List<Models.Review>();
            foreach (Review rev in show)
            {
                var show1 = crud.DataToLibraryReview(rev);
                test.Add(show1);
            }

            return test;

        }


        public Models.Review SearchByReviewtID(int id)
        {
            var search = crud.SearchByReviewID(id);
            var show = crud.DataToLibraryReview(search);
            return show;
        }

        public void InsertRestaurant(RestaurantReviews.Models.Review review)
        {
            crud.InsertReview(review);
        }

        public void DeleteReview(int id)
        {
            crud.DeleteReview(id);
        }
    }
}
