using Microsoft.AspNetCore.Mvc;

namespace StockApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
