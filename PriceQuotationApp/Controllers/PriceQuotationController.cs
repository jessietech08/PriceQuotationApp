using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Controllers
{
    public class PriceQuotationController : Controller
    {
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
            return RedirectToAction("Index");
        }
    }
}
