using Microsoft.AspNetCore.Mvc;

namespace SuperMarketProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
