using Microsoft.AspNetCore.Mvc;

namespace route_constraint.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("details/id:int")]
        public IActionResult Details(int id)
        {
            // The `id` parameter must be an integer
            return View();
        }
    }

    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            // Custom constraint logic
            return true; // or false based on logic
        }
    }

    public class CustomRouteConstraint
    {
    }
}
