using Microsoft.AspNetCore.Mvc;
using server_side_validation.Models;

namespace server_side_validation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Process the valid model
                // Save to the database, etc.
                return RedirectToAction("Success");
            }

            // If validation fails, return to the view with validation errors
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
