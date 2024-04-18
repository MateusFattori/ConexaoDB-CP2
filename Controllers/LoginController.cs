using cp2.Data;
using Microsoft.AspNetCore.Mvc;

namespace cp2.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly DataContext _dataContext;

        public LoginController(ILogger<LoginController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(User resquest)
        {
            var user = _dataContext.MVC_Users.FirstOrDefault(x => x.UserEmail == resquest.UserEmail);
            if (user != null) {
                return BadRequest("Usuário já existe");
            }

            return View();
        }

    }
}
