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
    public class CustomerTest
    {
        readonly Customers customer = new Customers();

        [Fact]
        public void ValidNameIsStored()
        {
            const string randomNameValue = "Daniel Rendon";
            customer.Name = randomNameValue;
            Assert.Equal(randomNameValue, customer.Name);
        }

        [Fact]
        public void Name_EmptyValue_ThrowsArgumentException()
        {
            Assert.ThrowsAny<ArgumentException>(() => customer.Name = string.Empty);
        }

        [Fact]
        public void Add_Customer()
        {
            var optionsBuilder = new DbContextOptionsBuilder<RedRobinContext>();
            optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);
            var options = optionsBuilder.Options;
            bool custAdded = false;

            var dbContext = new RedRobinContext(options);

            IRedRobinRepo redRobinRepository = new RedRobinRepo(dbContext);

            customer.Name = "Customer Test";
            customer.Phone = "(111)111-1111";

            redRobinRepository.AddCustomer(customer);

            dbContext.SaveChanges();

            foreach (var item in redRobinRepository.GetAllCustomers())
            {
                if (item.Name == "Customer Test")
                {
                    custAdded = true;
                }
            }
            Assert.True(custAdded);
        }
    }
}
