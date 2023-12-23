using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController(ILogger<HomeController> logger, AppDbContext context) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
