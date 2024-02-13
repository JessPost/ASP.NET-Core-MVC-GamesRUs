using Microsoft.AspNetCore.Mvc;

namespace GamingStore.Controllers
{
    public class OrderDetailController : Controller
    {
        public IActionResult Index()
        {
            //customer reviews their order
            return View();
        }
    }
}
