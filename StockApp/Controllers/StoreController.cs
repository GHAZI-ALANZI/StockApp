using Microsoft.AspNetCore.Mvc;

namespace StockApp.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
