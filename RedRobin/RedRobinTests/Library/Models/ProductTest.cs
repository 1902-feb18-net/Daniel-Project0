using Microsoft.EntityFrameworkCore;
using RedRobin.DataAccess;
using RedRobin.Library;
using RedRobin.Library.Interfaces;
using RedRobin.Library.Models;
using RedRobin.Library.Repositories;
using System;
using Xunit;

namespace RedRobinTests
{
    public class ProductTest
    {
        readonly Products burger = new Products();

        //[Fact]
        //public void ValidNameIsStored()
        //{
        //    const string randomNameValue = "BBQ Chicken Burger";
        //    burger.Name = randomNameValue;
        //    Assert.Equal(randomNameValue, burger.Name);
        //}

        //[Fact]
        //public void Name_EmptyValue_ThrowsArgumentException()
        //{
        //    Assert.ThrowsAny<ArgumentException>(() => burger.Name = string.Empty);
        //}

        //[Fact]
        //public void Add_Product()
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<RedRobinContext>();
        //    optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);
        //    var options = optionsBuilder.Options;
        //    bool proAdded = false;

        //    var dbContext = new RedRobinContext(options);

        //    IRedRobinRepo redRobinRepository = new RedRobinRepo(dbContext);

        //    burger.Name = "Product Test";
        //    burger.Cost = 10;
        //    burger.Type = "BURGER";

        //    redRobinRepository.AddProduct(burger);

        //    dbContext.SaveChanges();

        //    foreach (var item in redRobinRepository.GetAllProductsDB())
        //    {
        //        if (item.Name == "Product Test")
        //        {
        //            proAdded = true;
        //        }
        //    }
        //    Assert.True(proAdded);
        //}
    }
}
