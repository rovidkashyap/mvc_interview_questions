using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace return_json_response.Controllers
{
    public class HomeController : Controller
    {
        // Using the Json Method
        public IActionResult GetUser()
        {
            var user = new
            {
                Id = 1,
                Name = "Rovid Kashyap",
                Email = "rvd.kashyap@gmail.com"
            };

            return Json(user);  // Returns using Json Method
        }

        // Using JsonResult Directly
        public JsonResult GetProduct()
        {
            var product = new
            {
                Id = 101,
                Name = "Laptop",
                Price = 1200.00
            };

            return new JsonResult(product); // Returns using `JsonResult` constructor
        }

        // Customizing JSON Serialization
        public JsonResult GetOrder()
        {
            var order = new
            {
                OrderId = 1001,
                Product = "SmartPhone",
                Quantity = 2,
                TotalPrice = 800.00
            };

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            return new JsonResult(order, options);
        }

        // Using IActionResult with JsonResult
        public IActionResult GetCustomer()
        {
            var customer = new
            {
                Id = 501,
                FirstName = "Rovid",
                LastName = "Kashyap"
            };

            return new JsonResult(customer);
        }
    }
}
