using Microsoft.AspNetCore.Mvc;

namespace StockApp.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
