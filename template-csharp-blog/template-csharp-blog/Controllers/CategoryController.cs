using Microsoft.AspNetCore.Mvc;

namespace template_csharp_blog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
