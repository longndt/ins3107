using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult VNU()
        {
            string university = "Vietnam National University";

            //pass data from backend (controller) to frontend (view)
            //method 1: use ViewBag
            ViewBag.VNU = university;
            ViewBag.Year = 2024;

            //method 2: use ViewData
            ViewData["module"] = "Programming Technology";

            //method 3: use TempData (to display message: success, error,....)
            TempData["error"] = "Add new data error !";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
