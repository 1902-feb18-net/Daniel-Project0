using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedRobin.DataAccess;
using RedRobin.Library.Interfaces;
using RedRobin.Library.Models;

namespace RedRobin.WebApp.Controllers
{
    public class IngredientController : Controller
    {

        public static int restID = 0;

        public IRedRobinRepo Repo { get; }

        public IngredientController(IRedRobinRepo repo)
        {
            Repo = repo;
        }

        // GET: Ingredient
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

        // GET: Ingredient/Details/5
        public ActionResult Details(int id)
        {
            restID = id;
            IEnumerable<RestIng> libRestIng = Repo.GetAllIngredientsDB(restID).ToList();
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

        // GET: Ingredient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingredient/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromRoute]int id, Models.Ingredient ingredient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repo.AddIngredient(new IngredientsInventory
                    {
                        Name = ingredient.name,
                        Cost = ingredient.Cost,
                    });
                    Repo.Save();
                    IngredientsInventory ingTable = Repo.GetLastIng().Last();
                    Repo.AddRestaurantIngredient(new RestIng
                    {
                        resIngQty = ingredient.QtyToStock,
                        restaurantId = restID,
                        ingredientId = ingTable.Id
                    });
                    Repo.Save();

                    return RedirectToAction(nameof(Index));
                }
                return View(ingredient);
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingredient/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ingredient/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromRoute]int id, IFormCollection collection)
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

        // GET: Ingredient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ingredient/Delete/5
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