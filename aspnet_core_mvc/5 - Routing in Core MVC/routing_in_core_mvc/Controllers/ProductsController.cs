using Microsoft.AspNetCore.Mvc;

namespace routing_in_core_mvc.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve and return product details

            return View();
        }

        // In this example, 

        // `[Route("products")]` : Define the base route for the `ProductsController`.

        // `[Route("")]` and `[Route("Index")]` : Defines routes for the `Index` action.

        // `[Route("details/{id?}")]` : Defines a route for the `Details` action with an optional
        //  `id` parameter.
    }
}
