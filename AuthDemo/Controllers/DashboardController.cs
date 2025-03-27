using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
