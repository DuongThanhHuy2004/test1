using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
