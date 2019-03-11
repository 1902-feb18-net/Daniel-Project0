using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedRobin.Library.Interfaces;

namespace RedRobin.WebApp.Controllers
{
    public class StatisticsController : Controller
    {
        public static int restID = 0;

        public IRedRobinRepo Repo { get; }

        public StatisticsController(IRedRobinRepo repo)
        {
            Repo = repo;
        }

        // GET: Statistics
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

        // GET: Statistics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Statistics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Statistics/Create
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

        // GET: Statistics/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Statistics/Edit/5
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

        // GET: Statistics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Statistics/Delete/5
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

        public ActionResult Statistics(int id)
        {
            restID = id;


            IEnumerable<Library.Models.Products> libRestIng = Repo.GetAllProducts(restID);
            IEnumerable<Models.Statistics> webRests = libRestIng.Select(x => new Models.Statistics
            {
                Id = x.Id,
                productName = x.Name,
                TotalCost = x.Cost,
                Type = x.Type,
                productCount = Repo.GetCountProducts(x.Id).Count(),
                RevenueCost = Repo.GetProductRevenue(x.Id).Sum(r=>r.Cost)

            }).OrderByDescending(y=>y.RevenueCost);

            return View(webRests);
        }
    }
}