using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Travel_Locations.Models;

namespace Travel_Locations.Controllers
{
    public class HomeController(LocContext context) : Controller
    {
        private readonly LocContext _context = context;

        public IActionResult Index()
        {
            List<Locations> locations = _context.Locations.ToList();
            return View(locations);
        }

        public IActionResult Suggest()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Suggest(Locations locations)
        {
            if (ModelState.IsValid)
            {
                _context.Locations.Add(locations);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(locations);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
