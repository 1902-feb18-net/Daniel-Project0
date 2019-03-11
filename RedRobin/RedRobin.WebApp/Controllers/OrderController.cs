using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedRobin.Library.Interfaces;
using RedRobin.Library.Models;

namespace RedRobin.WebApp.Controllers
{
    public class OrderController : Controller
    {
        public static int restID = 0;
        public static decimal totalCost = 0;
        public static Dictionary<decimal, int> dicQtyOrder = new Dictionary<decimal, int>();

        public IRedRobinRepo Repo { get; }

        public OrderController(IRedRobinRepo repo)
        {
            Repo = repo;
        }
        // GET: Order
        public ActionResult Index()
        {
            IEnumerable<Library.Models.Restaurant> libRests = Repo.GetAllRestaurants();
            IEnumerable<Models.Restaurant> webRests = libRests.Select(x => new Models.Restaurant
            {
                Id = x.Id,
                Location = x.Location,
                Phone = x.Phone
            });
            return View(webRests);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id,int sort)
        {         
            restID = id;

            switch (sort)
            {
                case 1:
                    IEnumerable<Orders> libOrderEar = Repo.GetOrdersfromRestaurantEarliest(restID).ToList();
                    IEnumerable<Models.Orders> webRestsEarl = libOrderEar.Select(x => new Models.Orders
                    {
                        Id = x.Id,
                        custName = Repo.GetCustomerById(x.cutomerID).Name,
                        orderDate = x.orderDate,
                        orderTotal = x.CostTotal
                    });

                    return View(webRestsEarl);
                    
                case 2:
                    IEnumerable<Orders> libOrderLast = Repo.GetOrdersfromRestaurantLatest(restID).ToList();
                    IEnumerable<Models.Orders> webRestsLast = libOrderLast.Select(x => new Models.Orders
                    {
                        Id = x.Id,
                        custName = Repo.GetCustomerById(x.cutomerID).Name,
                        orderDate = x.orderDate,
                        orderTotal = x.CostTotal
                    });

                    return View(webRestsLast);
                default:
                    IEnumerable<Orders> libOrder = Repo.GetOrdersfromRestaurantLatest(restID).ToList();
                    IEnumerable<Models.Orders> webRests = libOrder.Select(x => new Models.Orders
                    {
                        Id = x.Id,
                        custName = Repo.GetCustomerById(x.cutomerID).Name,
                        orderDate = x.orderDate,
                        orderTotal = x.CostTotal
                    });

                    return View(webRests);
            }

            

        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Orders orders)
        {
            dicQtyOrder = new Dictionary<decimal, int>();
            try
            {
                if (ModelState.IsValid)
                {
                    Repo.AddCustomer(new Customers
                    { 
                    Name = orders.custName,
                    Phone = orders.custPhone
                    });
                    Repo.Save();

                    Repo.AddOrders(new Orders
                    {
                        orderDate = DateTime.Now,
                        cutomerID = Repo.GetLastCust().Id,
                        restaurantID = restID,
                        CostTotal = 0
                    });
                    Repo.Save();

                    return RedirectToAction(nameof(ProductsList));
                }
                return View(orders);
            }
            catch
            { 

                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ProductsList()
        {
            //restID = id;
            IEnumerable<ResPro> libRestIng = Repo.GetAllProductsDB(restID);
            IEnumerable<Models.Product> webRests = libRestIng.Select(x => new Models.Product
            {
                Id = x.productId,
                productName = Repo.GetProductById(x.productId).Name,
                TotalCost = Repo.GetProductById(x.productId).Cost,
                Type = Repo.GetProductById(x.productId).Type
            });

            return View(webRests);
        }

        public ActionResult AddProduct(int id)
        {
            Products libRest = Repo.GetProductById(id);
            
            var webRest = new Models.Product
            {
                productName = libRest.Name,
                TotalCost = libRest.Cost,
                Type = libRest.Type,
            };
            return View(webRest);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(Models.Product product)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    Repo.AddOrderProduct(new OrdPro
                    {
                        productId = product.Id,
                        orderId = Repo.GetLastOrd().Last().Id
                    });

                    dicQtyOrder.Add(product.TotalCost,product.QtyOrder);

                    totalCost = totalCost + product.TotalCost * product.QtyOrder;
                    Repo.Save();


                    Orders ord = Repo.GetLastOrd().Last();
                    foreach (var item in Repo.GetAllOrderProducts(ord.Id))
                    {
                        foreach (var item1 in Repo.GetAllIngredientProductsToSubs(item.Id))
                        {
                            foreach (var item2 in Repo.GetAllRestautantIngredient(restID, item1.ingredientId))
                            {
                                RestIng restIng = new RestIng();
                                restIng.resIngID = item2.resIngID;
                                restIng.ingredientId = item2.ingredientId;
                                restIng.restaurantId = item2.restaurantId;
                                restIng.resIngQty = item2.resIngQty - item1.ingProQty * product.QtyOrder;
                                Repo.UpdateRestaurantIngredient(restIng);                               
                            }
                        }
                    }
                    Repo.Save();

                    return RedirectToAction(nameof(ProductsList));
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditTotalCost()
        {
            try
            {
                Orders ord = Repo.GetLastOrd().Last();
                ord.CostTotal = totalCost;
                Repo.UpdateOrder(ord);
                Repo.Save();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult OrdersDetails(int id)
        {
            Orders libOrder = Repo.GetOrdersById(id);

            var listPro = Repo.GetAllOrderProducts(id).ToList();

            //int num = dicQtyOrder[Repo.GetProductById(y.Id).Cost];

            var webRest = new Models.Orders
            {
                Id = libOrder.Id,
                orderTotal = libOrder.CostTotal,
                orderDate = libOrder.orderDate,
                custName = Repo.GetCustomerById(libOrder.cutomerID).Name,
                custPhone = Repo.GetCustomerById(libOrder.cutomerID).Phone,

                products = listPro.Select(y => new Models.Product
                {

                    productName = Repo.GetProductById(y.Id).Name,
                    Type = Repo.GetProductById(y.Id).Type,
                    TotalCost = Repo.GetProductById(y.Id).Cost,
                    QtyOrder = dicQtyOrder[Repo.GetProductById(y.Id).Cost]
                }),
            };
            return View(webRest);
        }
    }
}