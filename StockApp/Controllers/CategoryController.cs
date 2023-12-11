using Microsoft.AspNetCore.Mvc;

namespace StockApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
