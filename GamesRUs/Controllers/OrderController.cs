using Microsoft.AspNetCore.Mvc;

namespace GamingStore.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            //admin sees customer order
            return View();
        }
    }
}
