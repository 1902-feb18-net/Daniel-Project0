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
    public class IngredientController : Controller
    {

        public IRedRobinRepo Repo { get; }

        public IngredientController(IRedRobinRepo repo)
        {
            Repo = repo;
        }

        // GET: Ingredient
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

        // GET: Ingredient/Details/5
        public ActionResult Details(int id)
        {
            IEnumerable<RestIng> libRestIng = Repo.GetAllIngredientsDB(id);
            IEnumerable<Restaurant> libRest = Repo.GetRestaurantById(id);
            IEnumerable<Models.Ingredient> webRests = libRestIng.Select(x => new Models.Ingredient
            {
                Id = x.ingredientId,
                name = Repo.GetIngredientById(x.ingredientId).Name,
                Qty = x.resIngQty,
                Cost = Repo.GetAllIngredients(id).ToList()[0].Cost,
                Restaurant = libRest.ToList()[0].Location
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
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