using Microsoft.EntityFrameworkCore;
using RedRobin.DataAccess;
using RedRobin.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RedRobin.Library.Repositories
{
    public class RedRobinRepo : IRedRobinRepo
    {
        private readonly RedRobinContext _db;

        public RedRobinRepo(RedRobinContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        //Restaurants

        public IEnumerable<Models.Restaurant> GetAllRestaurants()
        {

            return Mapper.Map(_db.Restaurant);
        }


        public Models.Restaurant GetRestaurantById(int resID)
        {

            return Mapper.Map(_db.Restaurant.AsNoTracking().First(r => r.RestaurantId == resID));
        }

        public void AddRestaurant(Models.Restaurant restaurant)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(restaurant));
        }

        public void UpdateRestaurant(Models.Restaurant restaurant)
        {
            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            _db.Entry(_db.Restaurant.Find(restaurant.Id)).CurrentValues.SetValues(Mapper.Map(restaurant));
        }

        public void DeleteRestaurant(int restaurantId)
        {
            _db.Remove(_db.Restaurant.Find(restaurantId));
        }

        public void DeleteRestaurantInRestIng(int restaurantId)
        {
            _db.Remove(_db.ResIng.Find(restaurantId));
        }

        public void DeleteRestaurantInRestPro(int restaurantId)
        {
            _db.Remove(_db.ResPro.Find(restaurantId));
        }

        public void DeleteRestaurantInOrders(int restaurantId)
        {
            _db.Remove(_db.Orders.Find(restaurantId));
        }

        //Customers

        public IEnumerable<Models.Customers> GetCustomer(string custName)
        {
            return Mapper.Map(from s in _db.Customer
                              where s.CustName == custName
                              select s);
        }

        public Models.Customers GetCustomerById(int custID)
        {

            return Mapper.Map(_db.Customer.AsNoTracking().First(r => r.CustomerId == custID));
        }

        public Models.Customers GetLastCust()
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(_db.Customer.Last());
        }

        public IEnumerable<Models.Customers> GetCustomerByName(string name)
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.Customer
                              where s.CustName == name
                              select s);
        }

        public void AddCustomer(Models.Customers customer)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(customer));
        }

        public IEnumerable<Models.Customers> GetOrdersfromCustomer(int orderID)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(from s in _db.Customer
                              join sa in _db.Orders on s.CustomerId
                              equals sa.CustomerId
                              where sa.OrderId == orderID
                              select s);
        }

        public IEnumerable<Models.Customers> GetAllCustomers()
        {
            return Mapper.Map(_db.Customer);
        }

        //Ingredients

        public IEnumerable<Models.RestIng> GetAllIngredientsDB(int ResID)
        {
            return Mapper.Map(from s in _db.ResIng
                              join sa in _db.Ingredients on s.IngredientId
                              equals sa.IngredientId
                              where s.RestaurantId == ResID
                              select s);
        }

        public IEnumerable<Models.IngredientsInventory> GetAllIngredients(int ingID)
        {
            return Mapper.Map(from s in _db.Ingredients
                              where s.IngredientId == ingID
                              select s);
        }

        public void AddIngredient(Models.IngredientsInventory ingredient)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(ingredient));
        }

        //RestaurantIngredients

        public IEnumerable<Models.RestIng> GetAllRestautantIngredient(int resID, int IngID)
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.ResIng
                              join sa in _db.Ingredients on s.IngredientId
                              equals sa.IngredientId
                              where s.RestaurantId == resID && s.IngredientId == IngID
                              select s);
        }

        public IEnumerable<Models.RestIng> GetAllRestautantIngredientToSubs(int resID)
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.ResIng
                              where s.RestaurantId == resID
                              select s);
        }

        public IEnumerable<Models.IngredientsInventory> GetRestautantIngredient(int resID)
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.Ingredients
                              join sa in _db.ResIng on s.IngredientId
                              equals sa.IngredientId
                              where sa.RestaurantId == resID
                              select s);
        }

        public Models.IngredientsInventory GetIngredientById(int ingID)
        {

            return Mapper.Map(_db.Ingredients.AsNoTracking().First(r => r.IngredientId == ingID));
        }

        public Models.RestIng GetIngredientByIdIngRes(int ingID)
        {

            return Mapper.Map(_db.ResIng.AsNoTracking().First(r => r.IngredientId == ingID));
        }

        public void AddRestaurantIngredient(Models.RestIng restIng)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(restIng));
        }

        public void UpdateRestaurantIngredient(Models.RestIng restIng)
        {
            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            _db.Entry(_db.ResIng.Find(restIng.resIngID)).CurrentValues.SetValues(Mapper.Map(restIng));
        }

        //Products

        public void UpdateProduct(Models.Products product)
        {
            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            _db.Entry(_db.Product.Find(product.Id)).CurrentValues.SetValues(Mapper.Map(product));
        }

        public IEnumerable<Models.Products> GetAllProducts(int restID)
        {
            return Mapper.Map(from s in _db.Product
                              join sa in _db.ResPro on s.ProductId
                              equals sa.ProductId
                              where sa.RestaurantId == restID
                              select s);
        }

        public Models.Products GetProductById(int proID)
        {

            return Mapper.Map(_db.Product.AsNoTracking().First(r => r.ProductId == proID));
        }

        public IEnumerable<Models.ResPro> GetAllProductsDB(int ResID)
        {
            return Mapper.Map(from s in _db.ResPro
                              join sa in _db.Product on s.ProductId
                              equals sa.ProductId
                              where s.RestaurantId == ResID
                              select s);
        }

        public void AddProduct(Models.Products product)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(product));
        }

        public IEnumerable<Models.Products> GetAllProductsDB()
        {

            return Mapper.Map(_db.Product);
        }

        public IEnumerable<Models.Products> GetLastPro()
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.Product
                              select s);
        }

        //IngredientsProducts

        public IEnumerable<Models.IngredientsInventory> GetAllIngredientProducts(int proID)
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.Ingredients
                              join sa in _db.IngPro on s.IngredientId
                              equals sa.IngredientId
                              where sa.ProductId == proID
                              select s);
        }

        public IEnumerable<Models.IngredientsInventory> GetLastIng()
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.Ingredients
                              select s);
        }

        public IEnumerable<Models.IngPro> GetAllIngredientProductsToSubs(int proID)
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.IngPro
                              where s.ProductId == proID
                              select s);
        }

        public void AddIngredientProduct(Models.IngPro ingPro)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(ingPro));
        }

        public void UpdateIngredientProduct(Models.IngPro ingPro)
        {
            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            _db.Entry(_db.ResIng.Find(ingPro.ingProID)).CurrentValues.SetValues(Mapper.Map(ingPro));
        }

        //RestaurantProduct

        public void AddRestaurantProduct(Models.ResPro resPro)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(resPro));
        }

        //Orders

        public void AddOrders(Models.Orders orders)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(orders));
        }

        public IEnumerable<Models.Orders> GetLastOrd()
        {
            //return Mapper.Map(_db.ResIngPro.Where(r=>r.RestaurantId== resID));
            return Mapper.Map(from s in _db.Orders
                              select s);
        }

        public IEnumerable<Models.Orders> GetOrdersfromRestaurant(int restID)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(_db.Orders.OrderByDescending(r=>r.RestaurantId==restID));
        }

        public IEnumerable<Models.Orders> GetOrdersfromRestaurantCheapest(int restID)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(_db.Orders.OrderBy(r => r.OrdCost).Where(t => t.RestaurantId == restID));
        }

        public IEnumerable<Models.Orders> GetOrdersfromRestaurantExpensive(int restID)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(_db.Orders.OrderByDescending(r => r.OrdCost).Where(t => t.RestaurantId == restID));
        }

        public IEnumerable<Models.Orders> GetOrdersfromRestaurantEarliest(int restID)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(_db.Orders.OrderBy(r => r.OrdDate).Where(t => t.RestaurantId == restID));
        }

        public IEnumerable<Models.Orders> GetOrdersfromRestaurantLatest(int restID)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(_db.Orders.OrderByDescending(r => r.OrdDate).Where(t => t.RestaurantId == restID));
        }

        public IEnumerable<Models.Orders> GetOrdersRevenueDay(int restID, DateTime date)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(from s in _db.Orders
                              where s.RestaurantId == restID 
                              && s.OrdDate.Year.Equals(date.Year)
                              && s.OrdDate.Month.Equals(date.Month)
                              && s.OrdDate.Day.Equals(date.Day)
                              select s);
        }

        public IEnumerable<Models.Orders> GetOrdersRevenueMonth(int restID, DateTime date)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(from s in _db.Orders
                              where s.RestaurantId == restID
                              && s.OrdDate.Year.Equals(date.Year)
                              && s.OrdDate.Month.Equals(date.Month)                              
                              select s);
        }

        public IEnumerable<Models.Orders> GetOrdersRevenueYear(int restID, DateTime date)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(from s in _db.Orders
                              where s.RestaurantId == restID
                              && s.OrdDate.Year.Equals(date.Year)
                              select s);
        }

        public IEnumerable<Models.Orders> GetOrdersCustomer(int custID)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(from s in _db.Orders
                              where s.CustomerId == custID
                              select s);
        }

        public IEnumerable<Models.Orders> GetAllOrdersDB()
        {
            return Mapper.Map(_db.Orders);
        }

        public void UpdateOrder(Models.Orders order)
        {
            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            _db.Entry(_db.Orders.Find(order.Id)).CurrentValues.SetValues(Mapper.Map(order));
        }
        public Models.Orders GetOrdersById(int ordID)
        {

            return Mapper.Map(_db.Orders.AsNoTracking().First(r => r.OrderId == ordID));
        }

        public IEnumerable<Models.Products> GetProductRevenue(int proID)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            return Mapper.Map(from s in _db.Product
                              join sa in _db.OrderProduct on s.ProductId
                              equals sa.ProductId
                              where sa.ProductId == proID
                              select s);
        }


        //OrdersProducts

        public void AddOrderProduct(Models.OrdPro ordPro)
        {
            //if (_data.Any(r => r.Id == restaurant.Id))
            //{
            //    throw new InvalidOperationException($"Restaurant located at {restaurant.Location} already exists.");
            //}
            _db.Add(Mapper.Map(ordPro));
        }

        public IEnumerable<Models.Products> GetAllOrderProducts(int orderID)
        {
            return Mapper.Map(from s in _db.Product
                              join sa in _db.OrderProduct on s.ProductId
                              equals sa.ProductId
                              where sa.OrderId == orderID
                              select s);
        }

        public IEnumerable<Models.OrdPro> GetCountProducts(int proID)
        {
            return Mapper.Map(from s in _db.OrderProduct
                              where s.ProductId == proID
                              select s);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
