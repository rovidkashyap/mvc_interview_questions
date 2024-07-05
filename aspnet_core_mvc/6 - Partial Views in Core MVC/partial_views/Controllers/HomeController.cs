using Microsoft.AspNetCore.Mvc;

namespace partial_views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new MyPartialViewModel { Message = "Hello from the controller!" };
            ViewData["Message"] = "Hello from ViewData!";

            return View(model);
        }
    }

    public class MyPartialViewModel
    {
        public string Message { get; set; }
    }
}
