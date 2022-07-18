using Faizi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Faizi.Controllers
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

        //Landing Page
        public IActionResult landingpage()
        {
            return View();
        }

        //Products
        public IActionResult products()
        {
            return View();
        }
        //contact form
        public IActionResult contact()
        {
            return View();
        }

        //Map
        public IActionResult map()
        {
            return View();
        }

        //Cart
        public IActionResult cart()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}