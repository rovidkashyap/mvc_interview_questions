using Microsoft.AspNetCore.Mvc;

namespace view_components_in_core_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public interface IArticleService
    {
        Task<int> GetLatestArticlesAsync(int count);
    }

    public class LatestArticlesViewComponent : ViewComponent
    {
        private readonly IArticleService _articleService;
        public LatestArticlesViewComponent(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var articles = await _articleService.GetLatestArticlesAsync(count);
            return View(articles);
        }
    }
}
