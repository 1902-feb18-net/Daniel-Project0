using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RedRobin.Library.Interfaces;
using RedRobin.Library.Models;

namespace RedRobin.WebApp.Controllers
{
    public class RestaurantController : Controller
    {
        public IRedRobinRepo Repo { get; }

        public RestaurantController(IRedRobinRepo repo)
        {
            Repo = repo;
        }

        // GET: Restaurant
        public ActionResult Index([FromQuery]string search = "")
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

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Restaurant restaurant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repo.AddRestaurant(new Restaurant
                    {
                        Location = restaurant.Location,
                        Phone = restaurant.Phone,
                    });
                    Repo.Save();

                    return RedirectToAction(nameof(Index));
                }
                return View(restaurant);
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            Restaurant libRest = Repo.GetRestaurantById(id);
            var webRest = new Models.Restaurant
            {
                Id = libRest.Id,
                Location = libRest.Location,
                Phone = libRest.Phone
            };
            return View(webRest);
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromRoute]int id, Models.Restaurant restaurant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Restaurant libRest = Repo.GetRestaurantById(id);
                    libRest.Location = restaurant.Location;
                    libRest.Phone = restaurant.Phone;
                    Repo.UpdateRestaurant(libRest);
                    Repo.Save();

                    return RedirectToAction(nameof(Index));
                }
                return View(restaurant);
            }
            catch (Exception)
            {
                return View(restaurant);
            }
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            Restaurant libRest = Repo.GetRestaurantById(id);
            var webRest = new Models.Restaurant
            {
                Id = libRest.Id,
                Location = libRest.Location
            };
            return View(webRest);
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, [BindNever]IFormCollection collection)
        {
            try
            {
                Repo.DeleteRestaurant(id);
                Repo.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}