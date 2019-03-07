using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedRobin.DataAccess
{
    public static class Mapper
    {

        //Restaurants
        public static Library.Models.Restaurant Map(Restaurant restaurant) => new Library.Models.Restaurant
        {
            Id = restaurant.RestaurantId,
            Location = restaurant.RestLocation,
            Phone = restaurant.RestPhone
        };

        public static Restaurant Map(Library.Models.Restaurant restaurant) => new Restaurant
        {
            RestaurantId = restaurant.Id,
            RestLocation = restaurant.Location,
            RestPhone = restaurant.Phone
        };

        public static IEnumerable<Library.Models.Restaurant> Map(IEnumerable<Restaurant> restaurants) => restaurants.Select(Map);
        public static IEnumerable<Restaurant> Map(IEnumerable<Library.Models.Restaurant> restaurants) => restaurants.Select(Map);



        //Customers

        public static Library.Models.Customers Map(Customer customer) => new Library.Models.Customers
        {
            Name = customer.CustName,
            Phone = customer.CustPhone
        };

        public static Customer Map(Library.Models.Customers customer) => new Customer
        {
            CustName = customer.Name,
            CustPhone = customer.Phone
        };

        public static IEnumerable<Library.Models.Customers> Map(IEnumerable<Customer> customers) => customers.Select(Map);
        public static IEnumerable<Customer> Map(IEnumerable<Library.Models.Customers> customers) => customers.Select(Map);

        //Ingredients

        public static Library.Models.IngredientsInventory Map(Ingredients ingredient) => new Library.Models.IngredientsInventory
        {
            Id = ingredient.IngredientId,
            Name = ingredient.IngName,
            Cost = ingredient.IngCost,
        };

        public static Ingredients Map(Library.Models.IngredientsInventory ingredient) => new Ingredients
        {
            IngredientId = ingredient.Id,
            IngName = ingredient.Name,
            IngCost = ingredient.Cost,
        };

        public static IEnumerable<Library.Models.IngredientsInventory> Map(IEnumerable<Ingredients> ingredients) => ingredients.Select(Map);
        public static IEnumerable<Ingredients> Map(IEnumerable<Library.Models.IngredientsInventory> ingredients) => ingredients.Select(Map);

        //RestaurantIngredients

        public static Library.Models.RestIng Map(ResIng resIngredient) => new Library.Models.RestIng
        {
            resIngID = resIngredient.ResIngId,
            ingredientId = resIngredient.IngredientId,
            restaurantId = resIngredient.RestaurantId,
            resIngQty = resIngredient.Qty,


        };

        public static ResIng Map(Library.Models.RestIng resIngredient) => new ResIng
        { 
            ResIngId = resIngredient.resIngID,
            IngredientId = resIngredient.ingredientId,
            RestaurantId = resIngredient.restaurantId,
            Qty = resIngredient.resIngQty,

        };

        public static IEnumerable<Library.Models.RestIng> Map(IEnumerable<ResIng> resIngredientPro) => resIngredientPro.Select(Map);
        public static IEnumerable<ResIng> Map(IEnumerable<Library.Models.RestIng> resIngredientPro) => resIngredientPro.Select(Map);



        //Products

        public static Library.Models.Products Map(Product product) => new Library.Models.Products
        {
            Id = product.ProductId,
            Name = product.ProName,
            Type = product.ProType,
            Cost = product.ProCost,
        };

        public static Product Map(Library.Models.Products product) => new Product
        {
            ProductId = product.Id,
            ProName = product.Name,
            ProType = product.Type,
            ProCost = product.Cost,
        };

        public static IEnumerable<Library.Models.Products> Map(IEnumerable<Product> product) => product.Select(Map);
        public static IEnumerable<Product> Map(IEnumerable<Library.Models.Products> product) => product.Select(Map);

        //IngredientsProducts

        public static Library.Models.IngPro Map(IngPro ingProducts) => new Library.Models.IngPro
        {
            ingProID = ingProducts.IngProId,
            productId = ingProducts.ProductId,
            ingredientId = ingProducts.IngredientId,
            ingProQty = ingProducts.Qty,


        };

        public static IngPro Map(Library.Models.IngPro ingProducts) => new IngPro
        {
            IngProId = ingProducts.ingProID,
            ProductId = ingProducts.productId,
            IngredientId = ingProducts.ingredientId,
            Qty = ingProducts.ingProQty,

        };

        public static IEnumerable<Library.Models.IngPro> Map(IEnumerable<IngPro> ingProducts) => ingProducts.Select(Map);
        public static IEnumerable<IngPro> Map(IEnumerable<Library.Models.IngPro> ingProducts) => ingProducts.Select(Map);

        //RestaurantProduct

        public static Library.Models.ResPro Map(ResPro resProducts) => new Library.Models.ResPro
        {
            resProID = resProducts.ResProId,
            productId = resProducts.ProductId,
            restaurantId = resProducts.RestaurantId,
        };

        public static ResPro Map(Library.Models.ResPro resProducts) => new ResPro
        {
            ResProId = resProducts.resProID,
            ProductId = resProducts.productId,
            RestaurantId = resProducts.restaurantId,
        };

        public static IEnumerable<Library.Models.ResPro> Map(IEnumerable<ResPro> resProducts) => resProducts.Select(Map);
        public static IEnumerable<ResPro> Map(IEnumerable<Library.Models.ResPro> resProducts) => resProducts.Select(Map);

        //Orders

        public static Library.Models.Orders Map(Orders orders) => new Library.Models.Orders
        {
            Id = orders.OrderId,
            restaurantID = orders.RestaurantId,
            cutomerID = orders.CustomerId,
            orderDate = orders.OrdDate,
            CostTotal = orders.OrdCost,

        };

        public static Orders Map(Library.Models.Orders orders) => new Orders
        {
            OrderId = orders.Id,
            CustomerId = orders.cutomerID,
            OrdDate = orders.orderDate,
            OrdCost = orders.CostTotal,
            RestaurantId = orders.restaurantID,
        };

        public static IEnumerable<Library.Models.Orders> Map(IEnumerable<Orders> orders) => orders.Select(Map);
        public static IEnumerable<Orders> Map(IEnumerable<Library.Models.Orders> orders) => orders.Select(Map);


        //OrdersProducts

        public static Library.Models.OrdPro Map(OrderProduct ordPro) => new Library.Models.OrdPro
        {
            ordProID = ordPro.OrdProId,
            productId = ordPro.ProductId,
            orderId = ordPro.OrderId,
        };

        public static OrderProduct Map(Library.Models.OrdPro ordPro) => new OrderProduct
        {
            OrdProId = ordPro.ordProID,
            ProductId = ordPro.productId,
            OrderId = ordPro.orderId,
        };

        public static IEnumerable<Library.Models.OrdPro> Map(IEnumerable<OrderProduct> ordPro) => ordPro.Select(Map);
        public static IEnumerable<OrderProduct> Map(IEnumerable<Library.Models.OrdPro> ordPro) => ordPro.Select(Map);


    }
}
