using Microsoft.AspNetCore.Mvc;

namespace GamingStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            //customers cart
            return View();
        }
    }
}
