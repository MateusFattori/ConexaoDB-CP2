using Microsoft.AspNetCore.Mvc;

namespace cp2.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
