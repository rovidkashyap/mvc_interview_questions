using Microsoft.AspNetCore.Mvc;
using System;

namespace returntypes_in_core_mvc.Controllers
{
    public class HomeController : Controller
    {
        // In ASP.NET Core MVC, action methods can return various types to control the response sent
        // to the client. The choice of return type depends on the desired outcome, such as rendering
        // a view, returning data in different formats, or redirecting to another action. Here are
        // the different types of return types in ASP.NET Core MVC:

        // 1.   `IActionResult` -

        //      IActionResult is the most common return type for action methods.It is an interface
        //      that allows for returning various types of results.Using IActionResult provides
        //      flexibility, as you can return different result types based on the logic in your
        //      action method.
        public IActionResult MyIActionResult()
        {
            int x = 8;
            if(x == 8)
            {
                return View();  // Retuns a view result
            }
            else if(x == 3)
            {
                return Json(new { message = "Value of x is 8" });   // Returns a JSON result
            }
            else
            {
                return NotFound();      // Returns a 404 result
            }
        }

        // 2.   `ActionResult` -

        //      `ActionResult` is an abstract class that implements IActionResult. It serves as a
        //      base class for many return types, including ViewResult, JsonResult, RedirectResult,
        //      etc.
        public ActionResult MyActionResult()
        {
            return View();      // Returns a ViewResult
        }

        // 3.   `ActionResult<T> -

        //      `ActionResult<T>` is a generic return type introduced in ASP.NET Core 2.1. It allows
        //      an action method to return either a result derived from ActionResult or a specific
        //      type T.
        public ActionResult<string> MyActionResultAction()
        {
            int x = 6;
            if(x == 6)
            {
                return "Value of x is 6";   // Returns a string
            }
            else
            {
                return NotFound();          // Returns a 404 result
            }
        }

        // 4.   Specific Return Type -

        //      4.1 `ViewResult` - is used to return a view to the client. It is typically used when
        //                         rendering HTML.
        public ViewResult MyViewResultAction()
        {
            return View("MyView");
        }

        //      4.2 `PartialViewResult` -  is used to return a partial view to the client.
        public PartialViewResult MyPartialViewResultAction()
        {
            return PartialView("MyPartialView");
        }

        //      4.3 `JsonResult` - is used to return JSON data to the client. It is commonly used in
        //                         API responses or AJAX requests.
        public JsonResult MyJsonResultAction()
        {
            return Json(new { message = "Hello" });
        }

        //      4.4 `ContentResult` - is used to return plain text content to the client.
        public ContentResult MyContentResultAction()
        {
            return Content("Hello, World!");
        }

        //      4.5 `FileResult` - and its derived classes (FileContentResult, FileStreamResult, and
        //                         VirtualFileResult) are used to return files to the client for
        //                         download.
        public FileResult MyFileResultAction()
        {
            var fileBytes = System.IO.File.ReadAllBytes("path/to/file");
            return File(fileBytes, "application/pdf", "myfile.pdf");
        }

        //      4.6 `RedirectResult` - is used to redirect the client to another URL.
        public RedirectResult MyRedirectResultAction()
        {
            return Redirect("https://www.example.com");
        }

        //      4.7 `RedirectToActionResult` - is used to redirect the client to another action.
        public RedirectToActionResult MyRedirectToActionResultAction()
        {
            return RedirectToAction("Index", "Home");
        }

        //      4.8 `RedirectToRouteResult` - is used to redirect the client to a route.
        public RedirectToRouteResult MyRedirectToRouteResultAction()
        {
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        //      4.9 `StatusCodeResult` -  is used to return a specific HTTP status code.
        public StatusCodeResult MyStatusCodeAction()
        {
            return StatusCode(404);
        }

        //      5.0 Custom Result Types - You can create custom result types by implementing the
        //                                IActionResult interface.
        public class CustomResult : IActionResult
        {
            public async Task ExecuteResultAsync(ActionContext context)
            {
                var response = context.HttpContext.Response;
                response.ContentType = "text/plain";
                await response.WriteAsync("This is a custom result.");
            }
        }

        public IActionResult MyCustomResultAction()
        {
            return new CustomResult();
        }
    }
}
