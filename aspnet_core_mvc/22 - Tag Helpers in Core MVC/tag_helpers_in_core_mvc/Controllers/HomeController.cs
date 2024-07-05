using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace tag_helpers_in_core_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    // Custom Tag Helper
    [HtmlTargetElement("email-link")]
    public class EmailTagHelper : TagHelper
    {
        public string Address { get; set; }
        public string DisplayText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";   // Replaces <email-link> with <a> tag
            output.Attributes.SetAttribute("href", $"mailto:(Address)");
            output.Content.SetContent(DisplayText);
        }
    }
}
