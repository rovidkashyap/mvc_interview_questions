using Microsoft.AspNetCore.Mvc;

namespace antiforgery_token.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit()
        {
            return View();
        }
    }
}
