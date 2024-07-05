using Microsoft.AspNetCore.Mvc;

namespace iactionresult_vs_actionresult.Controllers
{
    // In ASP.Net Core MVC, `IActionResult` and `ActionResult` are used to represent the result of an
    // action method in a controller.

    // `IActionResult` - 

    //  It is typically used when you want to return different types of results from the same action
    //  method.

    // `ActionResult` -

    //  It is often used when action method returns a derived from `ActionResult` types such as
    //  `ViewResult`, `JsonResult`, `RedirectResult`, etc.

    //  `ActionResult<T> -

    //  is a new feature introduced in ASP.Net Core 2.1. It allows an action method to return either
    //  a result derived from `ActionResult` or a specific type `T`.

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int x = 4;

            if (x == 4)
            {
                return View(x);     // Returns a view result
            }
            else if (x == 5)
            {
                return Json(new { message = "Value of x is 5" });   // Returns a JSON result
            }
            else
            {
                return NotFound();      // Returns a 404 result
            }

            // here `IActionResult` returns 3 different types of result based on condition.
        }

        public ActionResult MyAction()
        {
            return View();      // Returns a ViewResult
        }

        public ActionResult<string> MyNewAction()
        {
            int x = 2;
            if(x == 2)
            {
                return "Yes, Value of x is 2";      // Returns a string
            }
            else
            {
                return NotFound();                  // Returns a 404 result
            }
        }
    }
}
