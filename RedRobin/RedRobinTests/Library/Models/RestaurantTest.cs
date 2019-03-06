using Microsoft.EntityFrameworkCore;
using RedRobin.DataAccess;
using RedRobin.Library;
using RedRobin.Library.Interfaces;
using RedRobin.Library.Repositories;
using System;
using Xunit;

namespace RedRobinTests
{
    public class RestaurantTest
    {

        readonly RedRobin.Library.Models.Restaurant restaurant = new RedRobin.Library.Models.Restaurant();

        [Fact]
        public void ValidLocationIsStored()
        {

            const string randomLocationValue = "Los Angeles";
            restaurant.Location = randomLocationValue;
            Assert.Equal(randomLocationValue, restaurant.Location);
        }

        [Fact]
        public void Location_EmptyValue_ThrowsArgumentException()
        {
            Assert.ThrowsAny<ArgumentException>(() => restaurant.Location = string.Empty);
        }

        [Fact]
        public void Add_Restaurant()
        {
            var optionsBuilder = new DbContextOptionsBuilder<RedRobinContext>();
            optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);
            var options = optionsBuilder.Options;
            bool restAdded = false;

            var dbContext = new RedRobinContext(options);

            IRedRobinRepo redRobinRepository = new RedRobinRepo(dbContext);

            restaurant.Location = "Location Test";
            restaurant.Phone = "(111)111-1111";

            redRobinRepository.AddRestaurant(restaurant);

            dbContext.SaveChanges();

            foreach (var item in redRobinRepository.GetAllRestaurants())
            {
                if (item.Location == "Location Test")
                {
                    restAdded = true;
                }
            }
            Assert.True(restAdded);
        }
    }
}
