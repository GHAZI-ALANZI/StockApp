using Microsoft.AspNetCore.Mvc;

namespace StockApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
