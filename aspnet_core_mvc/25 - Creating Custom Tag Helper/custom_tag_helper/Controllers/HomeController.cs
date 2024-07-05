using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace custom_tag_helper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    // Creating Custom Tag Helper
    public static class CustomHtmlHelpers
    {
        public static IHtmlContent CustomLabel(this IHtmlHelper htmlHelper, string text, string cssClass)
        {
            var tagBuilder = new TagBuilder("label");
            tagBuilder.InnerHtml.Append(text);
            tagBuilder.AddCssClass(cssClass);

            return tagBuilder;
        }
    }

    // HTML Helpers in ASP.Net Core MVC generate HTML markup for rendering views.

    // Standard HTML Helpers create basic HTML elements and are not tied to model properties.

    // Strongly-Types HTML Helpers are tied to model properties, providing better compile-time
    // checking and IntelliSense support.

    // Custom HTML Helpers can be created to encapsulate complex HTML generation logic.
}
