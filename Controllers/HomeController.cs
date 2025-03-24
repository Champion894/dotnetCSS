using Microsoft.AspNetCore.Mvc;

namespace ResponsiveBootstrapApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is an about page.";
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }
    }
}
