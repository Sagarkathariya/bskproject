using Microsoft.AspNetCore.Mvc;

namespace bskproject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
