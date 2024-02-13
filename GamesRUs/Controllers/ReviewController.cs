using Microsoft.AspNetCore.Mvc;

namespace GamingStore.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            //customer product review
            return View();
        }
    }
}
