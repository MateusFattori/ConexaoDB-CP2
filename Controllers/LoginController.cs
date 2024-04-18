using Microsoft.AspNetCore.Mvc;

namespace cp2.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
