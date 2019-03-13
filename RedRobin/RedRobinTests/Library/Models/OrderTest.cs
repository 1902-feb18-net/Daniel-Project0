using Microsoft.EntityFrameworkCore;
using RedRobin.DataAccess;
using RedRobin.Library;
using RedRobin.Library.Interfaces;
using RedRobin.Library.Repositories;
using System;
using Xunit;

namespace RedRobinTests.Library.Models
{
    public class OrderTest
    {
        readonly RedRobin.Library.Models.Orders order = new RedRobin.Library.Models.Orders();

        //[Fact]
        //public void Add_Order()
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<RedRobinContext>();
        //    optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);
        //    var options = optionsBuilder.Options;
        //    bool ordAdded = false;

        //    var dbContext = new RedRobinContext(options);

        //    IRedRobinRepo redRobinRepository = new RedRobinRepo(dbContext);

        //    order.CostTotal = 13;
        //    order.orderDate = new DateTime(2019,3,3);
        //    order.restaurantID = 11;
        //    order.cutomerID = 9;

        //    redRobinRepository.AddOrders(order);

        //    dbContext.SaveChanges();

        //    foreach (var item in redRobinRepository.GetAllOrdersDB())
        //    {
        //        if (item.orderDate == new DateTime(2019,3,3))
        //        {
        //            ordAdded = true;
        //        }
        //    }
        //    Assert.True(ordAdded);
        //}
    }
}
