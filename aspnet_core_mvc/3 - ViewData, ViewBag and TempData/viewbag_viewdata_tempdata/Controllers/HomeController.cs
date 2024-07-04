using Microsoft.AspNetCore.Mvc;

namespace viewbag_viewdata_tempdata.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Setting data in the controller
            ViewBag.Message = "Hello, ViewBag!";

            // Retrieving data in the view
            string message = ViewBag.Message;

            return View(message);
        }

        public IActionResult Data()
        {
            // Setting data in the controller
            ViewData["Message"] = "Hello, ViewData!";

            // Retrieving data in the view
            string message = ViewData["Message"] as string;

            return View(message);
        }

        public IActionResult SetMessage()
        {
            TempData["Message"] = "This is a TempData Message";
            return RedirectToAction("ShowMessage");
        }

        public IActionResult ShowMessage()
        {
            string message = TempData["Message"] as string;
            return View(model: message);
        }
    }
}
