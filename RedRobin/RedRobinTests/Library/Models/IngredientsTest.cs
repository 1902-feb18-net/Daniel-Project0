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
    public class IngredientsTest
    {
        readonly IngredientsInventory ingredient = new IngredientsInventory();

        [Fact]
        public void ValidNameIsStored()
        {
            const string randomNameValue = "Bread";
            ingredient.Name = randomNameValue;
            Assert.Equal(randomNameValue, ingredient.Name);
        }

        [Fact]
        public void Name_EmptyValue_ThrowsArgumentException()
        {
            Assert.ThrowsAny<ArgumentException>(() => ingredient.Name = string.Empty);
        }

        //[Fact]
        //public void Add_Ingredient()
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<RedRobinContext>();
        //    optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);
        //    var options = optionsBuilder.Options;
        //    bool ingAdded = false;

        //    var dbContext = new RedRobinContext(options);

        //    IRedRobinRepo redRobinRepository = new RedRobinRepo(dbContext);

        //    ingredient.Name = "Ingredient Test";
        //    ingredient.Cost = 1;

        //    redRobinRepository.AddIngredient(ingredient);

        //    dbContext.SaveChanges();

        //    foreach (var item in redRobinRepository.GetAllIngredients())
        //    {
        //        if (item.Name == "Ingredient Test")
        //        {
        //            ingAdded = true;
        //        }
        //    }
        //    Assert.True(ingAdded);
        //}
    }
}
