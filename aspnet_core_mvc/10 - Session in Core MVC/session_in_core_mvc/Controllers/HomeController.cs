using Microsoft.AspNetCore.Mvc;

namespace session_in_core_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Set a string value in the session
            HttpContext.Session.SetString("UserName", "Rovid");

            // Set an integer value in the session
            HttpContext.Session.SetInt32("UserAge", 33);

            return View();
        }

        public IActionResult Logout()
        {
            // Remove a specific item from the session
            HttpContext.Session.Remove("UserName");

            // Clear all session data
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
    }
}
