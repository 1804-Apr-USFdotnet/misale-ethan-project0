﻿using RestaurantReviews.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


        
namespace RestaurantReviews.Library
{      
    
    public class Restaurant:IReviewable
    {
        
        public string  Name { get; set; }
        
        public string Address { get; set; }

        public List<Review> Reviews { get; set; }
        
        public string PhoneNumber { get; set; }
       
        public string City { get; set; }
     
        public string State { get; set; }
        [JsonIgnore]
        public float AvgRating { get; set; }

        public float CalculateAverageRating()
        {
            AvgRating = 0f;
            
            foreach(var i in Reviews)
            {
                AvgRating += i.Rating;
            }

            return AvgRating /= Reviews.Count;

        }



        public void AddReview(Review review)
        {

            Reviews.Add(review);
        }



    }
}
