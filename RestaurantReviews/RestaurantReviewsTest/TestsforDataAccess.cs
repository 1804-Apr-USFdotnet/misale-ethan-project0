using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviews.Library;
using RestaurantReviews.Models;
using System.Collections.Generic;

namespace RestaurantReviewsTest
{
    [TestClass]
    public class TestsforDataAccess
    {
        [TestMethod]
        public void ShowRestaurantTest()
        {
            RestaurantDataAccess access = new RestaurantDataAccess();
            var test = access.ShowRestaurants();


            Restaurant expected = new Restaurant
            {
                Name = "Miboo",
                Address = "9 5th Hill",
                PhoneNumber = "727-962-8551",
                City = "Clearwater",
                State = "Florida",
                Reviews = new List<Review>()

            };
            bool areTheyEqual = false;
            Restaurant actual = ((List<Restaurant>)test)[0];
            areTheyEqual = expected.Name.Equals(actual.Name) && expected.Address.Equals(actual.Address) &&
                expected.PhoneNumber.Equals(actual.PhoneNumber) && expected.City.Equals(actual.City) && expected.State.Equals(actual.State);
            
            Assert.IsTrue(areTheyEqual);
        }


        [TestMethod]
        public void SearchRestaurantByIdTest()
        {
            RestaurantDataAccess access = new RestaurantDataAccess();
            var test = access.SearchByRestaurantID(1);


            Restaurant expected = new Restaurant
            {
                Name = "Miboo",
                Address = "9 5th Hill",
                PhoneNumber = "727-962-8551",
                City = "Clearwater",
                State = "Florida",
                Reviews = new List<Review>()

            };
            bool areTheyEqual = false;
            Restaurant actual = test;
            areTheyEqual = expected.Name.Equals(actual.Name) && expected.Address.Equals(actual.Address) &&
                expected.PhoneNumber.Equals(actual.PhoneNumber) && expected.City.Equals(actual.City) && expected.State.Equals(actual.State);

            Assert.IsTrue(areTheyEqual);
        }

        [TestMethod]
        public void SearchByPartialName()
        {
            RestaurantDataAccess access = new RestaurantDataAccess();
            var test = access.SearchByPartialName("Mi");


            Restaurant expected = new Restaurant
            {
                Name = "Miboo",
                Address = "9 5th Hill",
                PhoneNumber = "727-962-8551",
                City = "Clearwater",
                State = "Florida",
                Reviews = new List<Review>()

            };
            bool areTheyEqual = false;
            Restaurant actual = ((List<Restaurant>)test)[0];
            areTheyEqual = expected.Name.Equals(actual.Name) && expected.Address.Equals(actual.Address) &&
                expected.PhoneNumber.Equals(actual.PhoneNumber) && expected.City.Equals(actual.City) && expected.State.Equals(actual.State);

            Assert.IsTrue(areTheyEqual);
        }

        [TestMethod]
        public void SortAscending()
        {
            RestaurantDataAccess access = new RestaurantDataAccess();
            var test = access.SortAscending();


            Restaurant expected = new Restaurant
            {
                Name = "Blogtags",
                Address = "4176 Transport Avenue",
                PhoneNumber = "850-305-1338",
                City = "Panama City",
                State = "Florida",
                Reviews = new List<Review>()

            };
            bool areTheyEqual = false;
            Restaurant actual = ((List<Restaurant>)test)[0];
            areTheyEqual = expected.Name.Equals(actual.Name) && expected.Address.Equals(actual.Address) &&
                expected.PhoneNumber.Equals(actual.PhoneNumber) && expected.City.Equals(actual.City) && expected.State.Equals(actual.State);

            Assert.IsTrue(areTheyEqual);
        }

        [TestMethod]
        public void SortDescending()
        {
            RestaurantDataAccess access = new RestaurantDataAccess();
            var test = access.SortDescending();


            Restaurant expected = new Restaurant
            {
                Name = "Yakidoo",
                Address = "5 Tennessee Avenue",
                PhoneNumber = "941-412-3214",
                City = "Bradenton",
                State = "Florida",
                Reviews = new List<Review>()

            };
            bool areTheyEqual = false;
            Restaurant actual = ((List<Restaurant>)test)[0];
            areTheyEqual = expected.Name.Equals(actual.Name) && expected.Address.Equals(actual.Address) &&
                expected.PhoneNumber.Equals(actual.PhoneNumber) && expected.City.Equals(actual.City) && expected.State.Equals(actual.State);

            Assert.IsTrue(areTheyEqual);
        }
    }
    
}
