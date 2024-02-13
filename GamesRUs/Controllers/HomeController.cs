using GamingStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamingStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
