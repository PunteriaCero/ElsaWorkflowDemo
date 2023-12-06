using Microsoft.AspNetCore.Mvc;

namespace ElsaDemoV01.Controllers
{
    public class ElsaDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
