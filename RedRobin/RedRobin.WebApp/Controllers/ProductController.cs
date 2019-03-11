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
    public class ProductController : Controller
    {
        public static int restID = 0;
        public static decimal totalCost = 0;
        public static List<Models.Ingredient> modelsList = new List<Models.Ingredient>();

        public IRedRobinRepo Repo { get; }

        public ProductController(IRedRobinRepo repo)
        {
            Repo = repo;
        }
        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<Restaurant> libRests = Repo.GetAllRestaurants();
            IEnumerable<Models.Restaurant> webRests = libRests.Select(x => new Models.Restaurant
            {
                Id = x.Id,
                Location = x.Location,
                Phone = x.Phone
            });
            return View(webRests);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            restID = id;
            IEnumerable<ResPro> libResPro = Repo.GetAllProductsDB(id);
            Restaurant libRest = Repo.GetRestaurantById(id);
            IEnumerable<Models.Product> webPros = libResPro.Select(x => new Models.Product
            {
                Id = x.productId,
                productName = Repo.GetProductById(x.productId).Name,
                Type = Repo.GetProductById(x.productId).Type,
                TotalCost = Repo.GetProductById(x.productId).Cost,
                Restaurant = libRest.Location
            });

            return View(webPros);
        }

        // GET: Ingredient/Details/5
        public ActionResult IngredientsList()
        {
            //restID = id;
            IEnumerable<RestIng> libRestIng = Repo.GetAllIngredientsDB(restID);
            Library.Models.Restaurant libRest = Repo.GetRestaurantById(restID);
            IEnumerable<Models.Ingredient> webRests = libRestIng.Select(x => new Models.Ingredient
            {
                Id = x.ingredientId,
                name = Repo.GetIngredientById(x.ingredientId).Name,
                QtyToStock = x.resIngQty,
                Cost = Repo.GetIngredientById(x.ingredientId).Cost,
                Restaurant = libRest.Location
            });

  
            return View(webRests);
        }

        //POST: Product/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
         public ActionResult IngredientsList(Models.Ingredient ingredient)
        {
            //modelsList = ingredient;

            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repo.AddProduct(new Products
                    {
                        Name = product.productName,
                        Type = product.Type
                    });
                    Repo.Save();

                    Repo.AddRestaurantProduct(new ResPro
                    {
                        productId = Repo.GetLastPro().Last().Id,
                        restaurantId = restID
                    });
                    Repo.Save();

                    return RedirectToAction(nameof(IngredientsList));
                }
                return View(product);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddIngredient(int id)
        {
            IngredientsInventory libRest = Repo.GetIngredientById(id);
            RestIng resIng = Repo.GetIngredientByIdIngRes(id);
            var webRest = new Models.Ingredient
            {
                name = libRest.Name,
                QtyToStock = resIng.resIngQty,
                Cost = libRest.Cost
            };
            return View(webRest);
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddIngredient(Models.Ingredient ingredient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repo.AddIngredientProduct(new IngPro
                    {
                        ingredientId = ingredient.Id,
                        productId= Repo.GetLastPro().Last().Id,
                        ingProQty = ingredient.QtyToAdd
                    });

                    totalCost = totalCost + ingredient.Cost*ingredient.QtyToAdd;
                    Repo.Save();

                    return RedirectToAction(nameof(IngredientsList));
                }
                return View(ingredient);
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
                Products prod = Repo.GetLastPro().Last();
                prod.Cost = totalCost;
                Repo.UpdateProduct(prod);
                Repo.Save();

                return RedirectToAction(nameof(Index));              
            }
            catch (Exception)
            {
                return View();
            }
        }
        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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

    }
}