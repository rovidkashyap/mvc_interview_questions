using Microsoft.AspNetCore.Mvc;

namespace nonaction_method_in_core_mvc.Controllers
{
    // In ASP.NET Core MVC, non-action methods are methods within a controller that are not meant to
    // be treated as action methods. These methods are typically utility or helper methods that
    // perform some kind of internal processing or logic that supports the controller's actions
    // but should not be directly accessible via HTTP requests.


    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var message = GetMessage();
            ViewData["Message"] = message;

            return View();
        }

        [NonAction]
        public string GetMessage()
        {
            return "Hello, welcome to the Home page!";
        }
    }
}
