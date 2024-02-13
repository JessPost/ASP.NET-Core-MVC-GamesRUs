using Microsoft.AspNetCore.Mvc;

namespace GamingStore.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            //login
            return View();
        }
    }
}
