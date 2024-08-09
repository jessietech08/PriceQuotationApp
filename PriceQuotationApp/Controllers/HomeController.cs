using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;
using System.Diagnostics;

namespace PriceQuotationApp.Controllers
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
            return View(new Calculation());
        }

        [HttpPost]
        public IActionResult Index(Calculation c)
        {
            if (ModelState.IsValid)
            {
                c.Calculate();
                return View(c);
            }
            return View(c);
        }

        public IActionResult Clear()
        {
            // refreshes clearing text boxes 
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
