using RedRobin.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedRobin.Library.Interfaces
{
    public interface IRedRobinRepo
    {
        //Restaurants

        IEnumerable<Restaurant> GetAllRestaurants();
        //Restaurant GetRestaurantById(int id);
        //IEnumerable<Movie> GetMoviesByGenre(Genre genre);
        void AddRestaurant(Restaurant restaurant);
        //void UpdateRestaurant(Restaurant restaurant);
        //void DeleteRestaurant(Restaurant restaurant);
        Restaurant GetRestaurantById(int resID);
        void UpdateRestaurant(Restaurant restaurant);
        void DeleteRestaurant(int restaurantId);
        void DeleteRestaurantInRestIng(int restaurantId);
        void DeleteRestaurantInRestPro(int restaurantId);
        void DeleteRestaurantInOrders(int restaurantId);


        //Customers
        IEnumerable<Customers> GetCustomer(string custName);
        void AddCustomer(Customers restaurant);
        IEnumerable<Customers> GetOrdersfromCustomer(int orderID);
        IEnumerable<Customers> GetAllCustomers();
        Customers GetCustomerById(int custID);
        // IEnumerable<Customers> GetLastCust();
        Models.Customers GetLastCust();
        IEnumerable<Models.Customers> GetCustomerByName(string name);

        //Ingredients
        void AddIngredient(IngredientsInventory ingredient);
        IngredientsInventory GetIngredientById(int ingID);
        IEnumerable<IngredientsInventory> GetLastIng();

        //RestaurantIngredients
        IEnumerable<RestIng> GetAllRestautantIngredient(int resID, int ingID);
        IEnumerable<RestIng> GetAllRestautantIngredientToSubs(int resID);
        IEnumerable<IngredientsInventory> GetRestautantIngredient(int resID);
        void AddRestaurantIngredient(RestIng restIngredient);
        void UpdateRestaurantIngredient(RestIng restIngredient);
        IEnumerable<RestIng> GetAllIngredientsDB(int ResID);
        IEnumerable<IngredientsInventory> GetAllIngredients(int ingID);
        RestIng GetIngredientByIdIngRes(int ingID);


        //Products
        IEnumerable<Products> GetAllProducts(int restID);
        void AddProduct(Products burger);
        IEnumerable<Products> GetAllProductsDB();
        Products GetProductById(int proID);
        IEnumerable<Products> GetLastPro();
        void UpdateProduct(Products product);
        IEnumerable<Models.Products> GetProductRevenue(int proID);

        //IngredientsProducts
        IEnumerable<IngredientsInventory> GetAllIngredientProducts(int proID);
        IEnumerable<IngPro> GetAllIngredientProductsToSubs(int proID);
        //IEnumerable<RestIng> GetRestautantIngredient(int resID, int ingID);
        void AddIngredientProduct(IngPro ingProduct);
        void UpdateIngredientProduct(IngPro ingProduct);

        //RestauranrProducts
        void AddRestaurantProduct(ResPro resProducts);
        IEnumerable<ResPro> GetAllProductsDB(int ResID);

        //Orders
        void AddOrders(Orders orders);
        IEnumerable<Orders> GetOrdersfromRestaurant(int RestID);
        IEnumerable<Orders> GetOrdersCustomer(int custID);
        IEnumerable<Orders> GetOrdersfromRestaurantCheapest(int restID);
        IEnumerable<Orders> GetOrdersfromRestaurantExpensive(int restID);
        IEnumerable<Orders> GetOrdersfromRestaurantEarliest(int restID);
        IEnumerable<Orders> GetOrdersfromRestaurantLatest(int restID);
        IEnumerable<Orders> GetOrdersRevenueDay(int restID, DateTime date);
        IEnumerable<Orders> GetOrdersRevenueMonth(int restID, DateTime date);
        IEnumerable<Orders> GetOrdersRevenueYear(int restID, DateTime date);
        IEnumerable<Orders> GetAllOrdersDB();
        IEnumerable<Orders> GetLastOrd();
        void UpdateOrder(Orders order);
        Orders GetOrdersById(int ordID);

        //OrderProduct
        void AddOrderProduct(OrdPro ordPro);
        IEnumerable<Products> GetAllOrderProducts(int orderID);
        IEnumerable<OrdPro> GetCountProducts(int proID);

        void Save();
    }
}
