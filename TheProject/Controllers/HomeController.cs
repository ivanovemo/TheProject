using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheProject.Core.Models;

namespace TheProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User?.Identity?.Name != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction("All", "Course");
            }

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 405)
            {
                return View("Error400");
            }

            if (statusCode == 404)
            {
                return View("Error404");
            }

            if (statusCode == 400)
            {
                return View("Error400");
            }

            return View();
        }
    }
}