using RedRobin.Library.Models;
using RedRobin.Library.Interfaces;
using RedRobin.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RedRobin.DataAccess;
using RedRobin.Library;
using Restaurant = RedRobin.Library.Models.Restaurant;
using NLog;

namespace RedRobin.ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LogManager.GetCurrentClassLogger();

            var optionsBuilder = new DbContextOptionsBuilder<RedRobinContext>();
            optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);

            var options = optionsBuilder.Options;

            var dbContext = new RedRobinContext(options);
            IRedRobinRepo redRobinRepository = new RedRobinRepo(dbContext);

            Console.WriteLine("WELCOME TO RED ROBIN");

            while (true)
            {
                //Main Menu with several options to display
                Console.WriteLine();

                Console.WriteLine("1:\tRestaurants.");
                Console.WriteLine("2:\tCustomers.");
                Console.WriteLine("3:\tIngredients.");
                Console.WriteLine("4:\tProducts.");
                Console.WriteLine("5:\tOrders.");

                Console.WriteLine();
                Console.Write("Enter valid menu option, or \"q\" to quit: ");

                var input = Console.ReadLine();
                bool quit = false;

                switch (input.ToString())
                {
                    case "1":
                        Console.WriteLine("1:\tAdd new restaurant location.");
                        Console.WriteLine("2:\tShow All Restaurants.");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            createRestaurant(input);
                        }
                        else if(input=="2")
                        {
                            showRestaurants();
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid option.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("1:\tAdd new customer.");
                        Console.WriteLine("2:\tSearch Customer.");
                        Console.WriteLine("3:\tDisplay order history for a customer.");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            createCustomer(input);
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("Enter Customer's name:");
                            input = Console.ReadLine();                          
                            searchCustomer(input);
                        }
                        else if (input == "3")
                        {
                            orderCustomer();
                        }
                        break;
                    case "3":
                        Console.WriteLine("1:\tAdd new ingredient.");
                        Console.WriteLine("2:\tShow Ingredients in stock.");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            createIngredient(input);
                        }
                        if (input == "2")
                        {
                            showIngredients(input);
                        }
                        break;
                    case "4":
                        Console.WriteLine("1:\tAdd new product.");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            createProduct(input);
                        }
                        break;
                    case "5":
                        Console.WriteLine("1:\tAdd new order.");
                        Console.WriteLine("2:\tShow Orders by Restaurant.");
                        Console.WriteLine("3:\tShow Orders Earliest/Lastest/Cheapest/Expensive.");
                        Console.WriteLine("4:\tShow Orders Statistics.");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            createOrder(input);
                        }
                        if (input == "2")
                        {
                            showOrders();
                        }
                        if (input == "3")
                        {
                            showOrdersCostDate();
                        }
                        if (input == "4")
                        {
                            showOrdersStatistics();
                        }
                        break;
                    case "q":
                        quit = true;
                        break;
                    default:
                        break;
                        
                }
                if (quit)
                { break; }
            }

            void createRestaurant(string input)
            {
                var newRestaurantModel = new Restaurant();

                while (newRestaurantModel.Location == null)
                {
                    Console.WriteLine();
                    Console.Write("Enter Restaurant's location: ");
                    input = Console.ReadLine();
                    try
                    {
                        newRestaurantModel.Location = input;

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }
                }

                while (newRestaurantModel.Phone == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Restaurant's phone number: ");
                    Console.WriteLine("Format: (xxx)xxx-xxxx: ");
                    input = Console.ReadLine();
                    try
                    {
                        newRestaurantModel.Phone = input;

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                redRobinRepository.AddRestaurant(newRestaurantModel);
                dbContext.SaveChanges();
                logger.Debug("Restaurant in: " + newRestaurantModel.Location + " created!");
            }

            void createCustomer(string input)
            {
                var newCustomerModel = new Customers();

                while (newCustomerModel.Name == null)
                {
                    Console.WriteLine();
                    Console.Write("Enter Customer's name: ");
                    input = Console.ReadLine();
                    try
                    {
                        newCustomerModel.Name = input;

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                while (newCustomerModel.Phone == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Customer's phone number: ");
                    Console.WriteLine("Format: (xxx)xxx-xxxx: ");
                    input = Console.ReadLine();
                    try
                    {
                        newCustomerModel.Phone = input;

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }
                }
                redRobinRepository.AddCustomer(newCustomerModel);
                dbContext.SaveChanges();
                logger.Debug("Customer: " + newCustomerModel.Name + " created!");
            }

            void createIngredient(string input)
            {
                var newIngredientModel = new IngredientsInventory();
                RestIng resIngModel = new RestIng();
                var restaurants = redRobinRepository.GetAllRestaurants();
                Dictionary<int, int> restaurantDic = new Dictionary<int, int>();
                int restCount = 1;               

                Console.WriteLine("Select a Restaurant to add the ingredient:");
                foreach (var restaurant in dbContext.Restaurant)
                {
                    Console.WriteLine(restCount+ ": " + "Location: {0} - Phone: {1}", restaurant.RestLocation, restaurant.RestPhone);
                    restaurantDic.Add(restCount, restaurant.RestaurantId);
                    restCount++;
                }

                var ingredientID = Console.ReadLine();
                int RestID = 0;

                try
                {
                    RestID = restaurantDic[int.Parse(ingredientID)];
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    logger.Error(e);
                }           
                
                while (newIngredientModel.Name == null)
                {
                    Console.WriteLine();
                    Console.Write("Enter Ingredients's name: ");
                    input = Console.ReadLine();
                    try
                    {
                        newIngredientModel.Name = input;

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }
                }

                while (resIngModel.resIngQty == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Ingredient's lbs to add in stock: ");
                    input = Console.ReadLine();
                    try
                    {
                        resIngModel.resIngQty = decimal.Parse(input);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }
                }

                while (newIngredientModel.Cost == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Ingredient's cost per lbs: ");
                    input = Console.ReadLine();

                    try
                    {
                        newIngredientModel.Cost = decimal.Parse(input);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Must be a valid cost");
                        logger.Error(e);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }
                }

                redRobinRepository.AddIngredient(newIngredientModel);
                dbContext.SaveChanges();
                logger.Debug("Ingredient: " + newIngredientModel.Name + " created!");

                Ingredients ingTable = dbContext.Ingredients.Last();
                int ingId = ingTable.IngredientId;

                resIngModel.ingredientId = ingId;
                resIngModel.restaurantId = RestID;

                redRobinRepository.AddRestaurantIngredient(resIngModel);
                dbContext.SaveChanges();
            }

            void createProduct(string input)
            {
                var newProductModel = new Products();
                var restaurants = redRobinRepository.GetAllRestaurants();
                Dictionary<int, int> restaurantDic = new Dictionary<int, int>();
                List<Library.Models.IngPro> ingProList = new List<Library.Models.IngPro>();
                
                int RestID;

                Dictionary<int, IngredientsInventory> ingredientInRes = new Dictionary<int, IngredientsInventory>();

                int restCount = 1;
                bool done = false;

                Console.WriteLine("Select a Restaurant to add the product:");
                foreach (var restaurant in dbContext.Restaurant)
                {
                    Console.WriteLine(restCount + ": " + "Location: {0} - Phone: {1}", restaurant.RestLocation, restaurant.RestPhone);
                    restaurantDic.Add(restCount, restaurant.RestaurantId);
                    restCount++;
                }

                var ingredientID = Console.ReadLine();

                RestID = restaurantDic[int.Parse(ingredientID)];

                while (newProductModel.Type == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter product type: ");
                    Console.WriteLine("1: Burger");
                    Console.WriteLine("2: Drink");
                    Console.WriteLine("3: Side");

                    var prodType = Console.ReadLine();
                    string producType = "";

                    switch (prodType)
                    {
                        case "1":
                            producType = "BURGER";
                            break;
                        case "2":
                            producType = "DRINK";
                            break;
                        case "3":
                            producType = "SIDE";
                            break;
                        default:
                            break;
                    }

                    try
                    {
                        newProductModel.Type = producType;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }
                }

                while (newProductModel.Name == null)
                {
                    Console.WriteLine();
                    Console.Write("Enter product's name: ");
                    input = Console.ReadLine();
                    try
                    {
                        newProductModel.Name = input;

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }
                }

                while (newProductModel.Ingredients.Count == 0)
                {
                    Console.WriteLine();
                    var ingredients = redRobinRepository.GetRestautantIngredient(RestID);
 
                    int ingredientCount = 1;
                    
                    Console.WriteLine("Add ingredients to the product");
                    Console.WriteLine("Type DONE when finish adding");

                    foreach (var item in ingredients)
                    {                  
                        Console.WriteLine(ingredientCount + ": " + item.Name);
                        ingredientInRes.Add(ingredientCount, item);
                        ingredientCount++;
                    }

                    while (done == false)
                    {
                        input = Console.ReadLine();
                        if (input.ToUpper() == "DONE")
                        {
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("How much lbs of "+ ingredientInRes[int.Parse(input)].Name + " would youlike to ad to ");
                            var inputQty = Console.ReadLine();
                            Library.Models.IngPro ingPro = new Library.Models.IngPro();
                            ingPro.ingProQty = int.Parse(inputQty);
                            ingPro.ingredientId  = ingredientInRes[int.Parse(input)].Id;

                            newProductModel.Ingredients.Add(ingredientInRes[int.Parse(input)]);
                            
                            ingProList.Add(ingPro);
                            Console.WriteLine("ingredient added!");
                        }
                    }

                    decimal totalCost = newProductModel.Ingredients.Sum(r => r.Cost);

                    try
                    {
                        newProductModel.Cost = totalCost;

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        logger.Error(ex);
                    }                    
                }

                redRobinRepository.AddProduct(newProductModel);
                dbContext.SaveChanges();
                logger.Debug("Product: " + newProductModel.Name + " created!");

                Product proTable = dbContext.Product.Last();
                foreach (var item in ingProList)
                {
                    Library.Models.IngPro IngPro = new Library.Models.IngPro();
                    IngPro.productId = proTable.ProductId;
                    IngPro.ingredientId = item.ingredientId;
                    IngPro.ingProQty = item.ingProQty;

                    redRobinRepository.AddIngredientProduct(IngPro);
                }

                Library.Models.ResPro ResPro = new Library.Models.ResPro();
                ResPro.productId = proTable.ProductId;
                ResPro.restaurantId = RestID;
                redRobinRepository.AddRestaurantProduct(ResPro);

                dbContext.SaveChanges();
            }

            void createOrder(string input)
            {
                var listProd = new List<Products>();
                var newOrderModel = new Library.Models.Orders();
                bool done = false;

                Dictionary<int, int> restaurantDic = new Dictionary<int, int>();
                Dictionary<int, Products> productsInRes = new Dictionary<int, Products>();
                int restCount = 1;
                int proCount = 1;

                Console.WriteLine("Select a Restaurant to add the order:");
                foreach (var restaurant in dbContext.Restaurant)
                {
                    Console.WriteLine(restCount + ": " + "Location: {0} - Phone: {1}", restaurant.RestLocation, restaurant.RestPhone);
                    restaurantDic.Add(restCount, restaurant.RestaurantId);
                    restCount++;
                }

                var ingredientID = Console.ReadLine();

                int RestID = restaurantDic[int.Parse(ingredientID)];
                newOrderModel.restaurantID = RestID;
                listProd = redRobinRepository.GetAllProducts(RestID).ToList();

                Console.WriteLine("Choose Cheese Burger Combo? (Y/N)");
                var answer = Console.ReadLine();

                try
                {
                    if (answer.ToUpper() == "Y")
                    {
                        foreach (var product in listProd)
                        {
                            if (product.Name == "Cheese Burger" || product.Name == "Coke")
                            {
                                newOrderModel.products.Add(product);
                            }
                        }

                        Console.WriteLine("Cheese Burger combo added!");
                    }
                    else if (answer.ToUpper() == "N")
                    {
                        Console.WriteLine("Choose a product to add:");
                        foreach (var product in listProd)
                        {
                            Console.WriteLine(proCount + ": " + "Product Name: {0} - Product Type: {1}", product.Name, product.Type);
                            productsInRes.Add(proCount, product);
                            proCount++;
                        }

                        while (done == false)
                        {
                            input = Console.ReadLine();
                            if (input.ToUpper() == "DONE")
                            {
                                done = true;
                            }
                            else
                            {
                                newOrderModel.products.Add(productsInRes[int.Parse(input)]);
                                Console.WriteLine("product:" + productsInRes[int.Parse(input)].Name + "added!");
                            }
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }


                createCustomer(input);
                Customer custTable = dbContext.Customer.Last();

                decimal totalCost = newOrderModel.products.Sum(r => r.Cost);
                newOrderModel.CostTotal = totalCost;
                newOrderModel.orderDate = DateTime.Now;
                newOrderModel.cutomerID = custTable.CustomerId;
                redRobinRepository.AddOrders(newOrderModel);
                dbContext.SaveChanges();
                logger.Debug("Order for customer: " + custTable.CustName +" - Date: " + newOrderModel.orderDate + " - Price: "+ newOrderModel.CostTotal+" created!");

                DataAccess.Orders orderTable = dbContext.Orders.Last();

                List<RestIng> idsResIngQty = new List<RestIng>();

                foreach (var item in newOrderModel.products)
                {
                    OrdPro ordPro = new OrdPro();
                    ordPro.productId = item.Id;
                    ordPro.orderId = orderTable.OrderId;
                    redRobinRepository.AddOrderProduct(ordPro);
                    dbContext.SaveChanges();

                    foreach (var ingredient in redRobinRepository.GetAllIngredientProductsToSubs(item.Id))
                    {
                        foreach (var resIngItem in redRobinRepository.GetAllRestautantIngredient(RestID, ingredient.ingredientId))
                        {
                            RestIng restIng = new RestIng();
                            restIng.resIngID = resIngItem.resIngID;
                            restIng.ingredientId = resIngItem.ingredientId;
                            restIng.restaurantId = resIngItem.restaurantId;
                            restIng.resIngQty = resIngItem.resIngQty - ingredient.ingProQty;
                            if (restIng.resIngQty <= 20)
                            {
                                Console.WriteLine("INGREDIENT: " + ingredient.ingredientId + "IS TO LOW IN THE INVENTORY!, QUANTITY: " + restIng.resIngQty);
                                break;
                            }
                            redRobinRepository.UpdateRestaurantIngredient(restIng);                           
                        }
                    }

                    dbContext.SaveChanges();
                }               
            }

            void searchCustomer(string input)
            {
                var customer = redRobinRepository.GetCustomer(input).ToList();

                foreach (var item in customer)
                {
                    Console.WriteLine("Customer: "+ item.Name);
                    Console.WriteLine("Phone Number:" + item.Phone);
                }
            }

            void showOrders()
            {
                Dictionary<int, int> restaurantDic = new Dictionary<int, int>();
                Dictionary<int, Library.Models.Orders> ordersDic = new Dictionary<int, Library.Models.Orders>();
                Console.WriteLine("Select a Restaurant to show the orders:");
                int restCount = 1;
                int RestID = 0;
                int OrderID = 0;

                foreach (var restaurant in dbContext.Restaurant)
                {
                    Console.WriteLine(restCount + ": " + "Location: {0} - Phone: {1}", restaurant.RestLocation, restaurant.RestPhone);
                    try
                    {
                        restaurantDic.Add(restCount, restaurant.RestaurantId);
                        restCount++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Enter a valid option");
                    }
                }

                var resttID = Console.ReadLine();
                RestID = restaurantDic[int.Parse(resttID)];

                int countOrders = 1;
                foreach (var item in redRobinRepository.GetOrdersfromRestaurant(RestID))
                {
                    Console.WriteLine("Select order for details:");
                    Console.WriteLine(countOrders + ": " + item.orderDate.Month + "/" + item.orderDate.Day + "/" + item.orderDate.Year + " - Price:" + item.CostTotal + "$");
                    ordersDic.Add(countOrders,item);
                    countOrders++;
                }

                var orderID = Console.ReadLine();

                try
                {
                    OrderID = ordersDic[int.Parse(orderID)].Id;


                    string customerName = "";
                    string customerPhone = "";

                    foreach (var item in redRobinRepository.GetOrdersfromCustomer(OrderID))
                    {
                        customerName = item.Name;
                        customerPhone = item.Phone;
                    }

                    Console.WriteLine("CUSTOMER NAME: " + customerName);
                    Console.WriteLine("PHONE NUMBER: " + customerPhone);
                    Console.WriteLine("DATE:" + ordersDic[int.Parse(orderID)].orderDate.Month + "/" + ordersDic[int.Parse(orderID)].orderDate.Day + "/" + ordersDic[int.Parse(orderID)].orderDate.Year);


                    foreach (var item in redRobinRepository.GetAllOrderProducts(OrderID))
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("PRODUCT NAME: " + item.Name);
                        Console.WriteLine("PRODUCT TYPE: " + item.Type);
                        Console.WriteLine("PRODUCT PRICE: " + item.Cost + "$");
                        Console.WriteLine("--------------------------");
                    }

                    Console.WriteLine("--------------------------");
                    Console.WriteLine("TOTAL PRICE:" + ordersDic[int.Parse(orderID)].CostTotal);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Must enter a valid option");
                }
            }

            void orderCustomer()
            {
                Dictionary<int, int> customerDic = new Dictionary<int, int>();
                Dictionary<int, Library.Models.Orders> ordersDic = new Dictionary<int, Library.Models.Orders>();
                Console.WriteLine("Select a customer to show the orders:");
                int custCount = 1;
                int CustID = 0;
                int OrderID = 0;

                foreach (var customer in dbContext.Customer)
                {

                    Console.WriteLine(custCount + ": " + "Name: {0} - Phone: {1}", customer.CustName, customer.CustPhone);
                    customerDic.Add(custCount, customer.CustomerId);
                    custCount++;
                }

                var custID = Console.ReadLine();
                CustID = customerDic[int.Parse(custID)];

                int countOrders = 1;
                foreach (var item in redRobinRepository.GetOrdersCustomer(CustID))
                {
                    Console.WriteLine("Select order for details:");
                    Console.WriteLine(countOrders + ": " + item.orderDate.Month + "/" + item.orderDate.Day + "/" + item.orderDate.Year + " - Price:" + item.CostTotal + "$");
                    ordersDic.Add(countOrders, item);
                    countOrders++;
                }

                var orderID = Console.ReadLine();

                OrderID = ordersDic[int.Parse(orderID)].Id;
                string customerName = "";
                string customerPhone = "";

                foreach (var item in redRobinRepository.GetOrdersfromCustomer(OrderID))
                {
                    customerName = item.Name;
                    customerPhone = item.Phone;
                }

                Console.WriteLine("CUSTOMER NAME: " + customerName);
                Console.WriteLine("PHONE NUMBER: " + customerPhone);
                Console.WriteLine("DATE:" + ordersDic[int.Parse(orderID)].orderDate.Month + "/" + ordersDic[int.Parse(orderID)].orderDate.Day + "/" + ordersDic[int.Parse(orderID)].orderDate.Year);

                foreach (var item in redRobinRepository.GetAllOrderProducts(OrderID))
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("PRODUCT NAME: " + item.Name);
                    Console.WriteLine("PRODUCT TYPE: " + item.Type);
                    Console.WriteLine("PRODUCT PRICE: " + item.Cost + "$");
                    Console.WriteLine("--------------------------");
                }

                Console.WriteLine("--------------------------");
                Console.WriteLine("TOTAL PRICE:" + ordersDic[int.Parse(orderID)].CostTotal);
            }


            void showOrdersCostDate()
            {
                Dictionary<int, int> restaurantDic = new Dictionary<int, int>();
                Dictionary<int, Library.Models.Orders> ordersDic = new Dictionary<int, Library.Models.Orders>();
                Console.WriteLine("Select a Restaurant to show the orders:");
                int restCount = 1;
                int RestID = 0;
                int OrderID = 0;

                foreach (var restaurant in dbContext.Restaurant)
                {
                    Console.WriteLine(restCount + ": " + "Location: {0} - Phone: {1}", restaurant.RestLocation, restaurant.RestPhone);
                    restaurantDic.Add(restCount, restaurant.RestaurantId);
                    restCount++;
                }

                var resttID = Console.ReadLine();
                RestID = restaurantDic[int.Parse(resttID)];

                Console.WriteLine("SORT ORDERS BY:");
                Console.WriteLine("1: Earliest");
                Console.WriteLine("2: Latest");
                Console.WriteLine("3: Cheapest");
                Console.WriteLine("4: Most Expensive");

                var sort = Console.ReadLine();
                int countOrders = 1;

                switch (sort)
                {               
                    case "1":
                        Console.WriteLine("Select order for details:");
                        foreach (var item in redRobinRepository.GetOrdersfromRestaurantEarliest(RestID))
                        {
                            Console.WriteLine(countOrders + ": " + item.orderDate.Hour + ":" + item.orderDate.Minute + ":" + item.orderDate.Second + " - " + item.orderDate.Month + "/" + item.orderDate.Day + "/" + item.orderDate.Year + " - Price:" + item.CostTotal + "$");
                            Console.WriteLine();
                            ordersDic.Add(countOrders, item);
                            countOrders++;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Select order for details:");
                        foreach (var item in redRobinRepository.GetOrdersfromRestaurantLatest(RestID))
                        {
                            Console.WriteLine(countOrders + ": " + item.orderDate.Hour + ":" + item.orderDate.Minute + ":" + item.orderDate.Second + " - " + item.orderDate.Month + "/" + item.orderDate.Day + "/" + item.orderDate.Year + " - Price:" + item.CostTotal + "$");
                            Console.WriteLine();
                            ordersDic.Add(countOrders, item);
                            countOrders++;
                        }

                        break;
                    case "3":
                        
                        Console.WriteLine("Select order for details:");
                        foreach (var item in redRobinRepository.GetOrdersfromRestaurantCheapest(RestID))
                        {                
                            Console.WriteLine(countOrders + ": " + item.orderDate.Hour +":" + item.orderDate.Minute +":"+ item.orderDate.Second + " - " + item.orderDate.Month + "/" + item.orderDate.Day + "/" + item.orderDate.Year + " - Price:" + item.CostTotal + "$");
                            Console.WriteLine();
                            ordersDic.Add(countOrders, item);
                            countOrders++;
                        }

                        break;
                    case "4":
                        
                        Console.WriteLine("Select order for details:");
                        foreach (var item in redRobinRepository.GetOrdersfromRestaurantExpensive(RestID))
                        {
                            Console.WriteLine(countOrders + ": " + item.orderDate.Hour + ":" + item.orderDate.Minute + ":" + item.orderDate.Second + " - " + item.orderDate.Month + "/" + item.orderDate.Day + "/" + item.orderDate.Year + " - Price:" + item.CostTotal + "$");
                            Console.WriteLine();
                            ordersDic.Add(countOrders, item);
                            countOrders++;
                        }

                        break;
                    default:
                        break;
                }

                var orderID = Console.ReadLine();

                OrderID = ordersDic[int.Parse(orderID)].Id;
                string customerName = "";
                string customerPhone = "";

                foreach (var item in redRobinRepository.GetOrdersfromCustomer(OrderID))
                {
                    customerName = item.Name;
                    customerPhone = item.Phone;
                }

                Console.WriteLine("CUSTOMER NAME: " + customerName);
                Console.WriteLine("PHONE NUMBER: " + customerPhone);
                Console.WriteLine("DATE:" + ordersDic[int.Parse(orderID)].orderDate.Month + "/" + ordersDic[int.Parse(orderID)].orderDate.Day + "/" + ordersDic[int.Parse(orderID)].orderDate.Year);

                foreach (var item in redRobinRepository.GetAllOrderProducts(OrderID))
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("PRODUCT NAME: " + item.Name);
                    Console.WriteLine("PRODUCT TYPE: " + item.Type);
                    Console.WriteLine("PRODUCT PRICE: " + item.Cost + "$");
                    Console.WriteLine("--------------------------");
                }

                Console.WriteLine("--------------------------");
                Console.WriteLine("TOTAL PRICE:" + ordersDic[int.Parse(orderID)].CostTotal);
            }

            void showOrdersStatistics()
            {
                Dictionary<int, int> restaurantDic = new Dictionary<int, int>();
                Dictionary<int, Library.Models.Orders> ordersDic = new Dictionary<int, Library.Models.Orders>();
                Console.WriteLine("Select a Restaurant to show the orders:");
                int restCount = 1;
                int RestID = 0;
                int OrderID = 0;

                foreach (var restaurant in dbContext.Restaurant)
                {
                    Console.WriteLine(restCount + ": " + "Location: {0} - Phone: {1}", restaurant.RestLocation, restaurant.RestPhone);
                    restaurantDic.Add(restCount, restaurant.RestaurantId);
                    restCount++;
                }

                var resttID = Console.ReadLine();
                RestID = restaurantDic[int.Parse(resttID)];

                Console.WriteLine("STATISTICS:");
                Console.WriteLine("1: Revenue per period");
                Console.WriteLine("2: Product selled");

                var sort = Console.ReadLine();
                int countOrders = 1;

                switch (sort)
                {
                    case "1":
                        Console.WriteLine("1: Revenue per day");
                        Console.WriteLine("2: Revenue per month");
                        Console.WriteLine("3: Revenue per year");
                        Console.WriteLine("4: Revenue for today");
                        var period = Console.ReadLine();

                        if (period == "1")
                        {
                            Console.WriteLine("Enter Year: ");
                            var year = Console.ReadLine();
                            Console.WriteLine("Enter Month: ");
                            var month = Console.ReadLine();
                            Console.WriteLine("Enter Day: ");
                            var day = Console.ReadLine();
                            try
                            {
                                DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

                                Console.WriteLine("Revenue for: " + year + "/" + month + "/" + day);
                                Console.WriteLine(redRobinRepository.GetOrdersRevenueDay(RestID, date).Sum(r => r.CostTotal) + "$");
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Please Enter a valid date");
                            }
                        }
                        else if(period == "2")
                        {                          
                            Console.WriteLine("Enter Year: ");
                            var year = Console.ReadLine();
 
                            Console.WriteLine("Enter Month: ");
                            var month = Console.ReadLine();
                            try
                            {
                                DateTime date = new DateTime(int.Parse(year), int.Parse(month), 1);
                                Console.WriteLine("Revenue for: " + year + "/" + month);
                                Console.WriteLine(redRobinRepository.GetOrdersRevenueMonth(RestID, date).Sum(r => r.CostTotal) + "$");
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Please Enter a valid date");
                            }                          
                        }
                
                        else if (period == "3")
                        {
                            Console.WriteLine("Enter Year: ");
                            var year = Console.ReadLine();
                            try
                            {
                                DateTime date = new DateTime(int.Parse(year), 1, 1);
                                Console.WriteLine("Revenue for: " + year);
                                Console.WriteLine(redRobinRepository.GetOrdersRevenueYear(RestID, date).Sum(r => r.CostTotal) + "$");
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Please Enter a valid date");
                            }
                        }
                        else if (period == "4")
                        {
                            DateTime date = DateTime.Now;
                            Console.WriteLine("Revenue for: " + date.Year + "/" + date.Month + "/" + date.Day);
                            Console.WriteLine(redRobinRepository.GetOrdersRevenueDay(RestID, date).Sum(r => r.CostTotal) + "$");
                        }

                        break;
                    case "2":
                        
                        foreach (var item in redRobinRepository.GetAllProducts(RestID))
                        {
                            int count = redRobinRepository.GetCountProducts(item.Id).Count();
 
                            Console.WriteLine("Product Type: "+ item.Type+"Product Name: "+item.Name);
                            Console.WriteLine("Has being selled: " + count + " times" );
                        }
                        break;
                    default:
                        break;
                }
            }

            void showRestaurants()
            {
                var restaurants = redRobinRepository.GetAllRestaurants().ToList();

                foreach (var item in restaurants)
                {
                    Console.WriteLine(item.Location);
                }
            }

            void showIngredients(string input)
            {
                Dictionary<int, int> restaurantDic = new Dictionary<int, int>();
                Console.WriteLine("Select a Restaurant to show the ingredients:");
                int restCount = 1;
                int RestID = 0;
       

                foreach (var restaurant in dbContext.Restaurant)
                {
                    Console.WriteLine(restCount + ": " + "Location: {0} - Phone: {1}", restaurant.RestLocation, restaurant.RestPhone);
                    restaurantDic.Add(restCount, restaurant.RestaurantId);
                    restCount++;
                }

                var resttID = Console.ReadLine();
                RestID = restaurantDic[int.Parse(resttID)];

                foreach (var item in redRobinRepository.GetAllIngredientsDB(RestID))
                {
                    foreach (var ingredient in redRobinRepository.GetAllIngredients(item.ingredientId))
                    {
                        Console.WriteLine("Ingrdient: " + ingredient.Name + " has QTY of: " + item.resIngQty + " lbs left");
                    }                   
                }
            }
        }
    }
}
