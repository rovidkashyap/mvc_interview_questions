using Microsoft.AspNetCore.Mvc;

namespace passing_data.Controllers
{
    public class HomeController : Controller
    {
        // In ASP.NET Core MVC, you can pass data between controllers and views using various
        // mechanisms such as ViewData, ViewBag, strongly-typed models, and TempData.
        // Here's how you can pass data in both directions

        // Passing Data from Controller to View

        // 1. Using ViewData    (Check the index.cshtml file for accessing ViewData data)
        // 2. Using ViewBag     (Check the index.cshtml file for accessing ViewBag data)

        public IActionResult Index()
        {
            ViewData["Message"] = "Hello, ViewData!";
            ViewBag.Message = "Hello, ViewBag!";

            return View();
        }

        // 3. Using Strongly-Typed Models   (Check stronglyTyped.cshtml file for accessing data)
        public class MyViewModel
        {
            public string Message { get; set; }
        }
        public IActionResult stronglyTyped()
        {
            var model = new MyViewModel
            {
                Message = "Hello, Strongly-Typed Model!"
            };

            return View(model);
        }

        // 4. Passing Data from View to Controller (Check index.cshtml file for accessing)

        // Using Form Submission
        public IActionResult ProcessData(string inputData)
        {
            // Process inputData
            return RedirectToAction("Result");
        }

        // TempData for Redirect Scenarios
        public IActionResult Data()
        {
            TempData["Message"] = "Hello, TempData!";
            return RedirectToAction("ShowMessage");
        }
        public IActionResult ShowMessage()
        {
            string message = TempData["Message"] as string;
            return View(model: message);
        }
    }
}
