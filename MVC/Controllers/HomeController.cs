using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Banner = _context.Banners.FirstOrDefault(),
                Statistics = _context.Statistics.ToList()
            };

            return View(homeVM);
        }
    }
}
