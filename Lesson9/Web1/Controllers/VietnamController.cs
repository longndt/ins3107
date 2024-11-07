using Microsoft.AspNetCore.Mvc;

namespace Web1.Controllers
{
    public class VietnamController : Controller
    {
        //URL: localhost:PORT/Vietnam/Index
        //URL: localhost:PORT/Vietnam
        public IActionResult Index()
        {
            //View: Views/Vietnam/Index.cshtml
            return View();
        }

        public IActionResult Hanoi()
        {
            return View();
        }

        public IActionResult Danang()
        {
            return View();
        }

        public IActionResult HCMCity()
        {
            return View();
        }
    }
}
