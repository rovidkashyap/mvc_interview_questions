using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace return_json_response.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetProducts()
        {
            var products = new[]
            {
                new { Id = 1, Name = "Product1", Price = 10.0 },
                new { Id = 2, Name = "Product2", Price = 20.0 }
            };

            return Ok(products);    // Ok() method returns JSON response
        }
    }
}
