﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Models.Interfaces
{
    interface IReviewable
    {
        
        double CalculateAverageRating();
        void AddReview(Review review);

    }
}
