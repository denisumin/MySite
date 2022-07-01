using Microsoft.AspNetCore.Mvc;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
