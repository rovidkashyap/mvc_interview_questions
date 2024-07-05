using Microsoft.AspNetCore.Mvc;

namespace output_caching.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 60)]  // Output is cached for 60 seconds
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 60, VaryByHeader = "User-Agent")]
        public IActionResult Details(int id)
        {
            //var model = GetModelById(id);
            //return View(model);
            return View();
        }

        [ResponseCache(CacheProfileName = "Default")]
        public IActionResult Data()
        {
            return View();
        }

        [ResponseCache(CacheProfileName = "NoCache")]
        public IActionResult MyData()
        {
            return View();
        }
    }
}
