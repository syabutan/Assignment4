using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();
            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add(string.Format("#{0}: {1}, Favorite Dish: {2}, Tel: {3}, Address: {4}, Website: {5}", r.RestaurantRanking, r.Name, r.FavoriteDish, r.Phone, r.Address, r.Link));
            }
            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult Suggestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestion(SuggestInfo info)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurantInfo(info);
                return View("Confirmation", info);
            }
            else
            {
                return View();
            }
        }

        public IActionResult List()
        {
            return View(TempStorage.Infos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
