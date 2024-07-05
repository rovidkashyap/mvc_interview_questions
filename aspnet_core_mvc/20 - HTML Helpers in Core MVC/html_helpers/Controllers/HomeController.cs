using Microsoft.AspNetCore.Mvc;

namespace html_helpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public class UserViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
    }
}
