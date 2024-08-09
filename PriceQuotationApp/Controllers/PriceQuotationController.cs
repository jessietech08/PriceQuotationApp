using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Controllers
{
    public class PriceQuotationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculation c)
        {
            if (ModelState.IsValid)
            {
                return View(c);
            }
            return View(c);
        }

        public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}
