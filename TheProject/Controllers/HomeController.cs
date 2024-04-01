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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}