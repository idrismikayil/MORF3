using Application.PageDetails.PartnerPageDetails.Commands;
using Domain.Entities;
using Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;


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
            Console.WriteLine("Home is used");
            HomeVM homeVM = new()
            {
                Partners = _context.Partners.ToList(),
                Banner = _context.Banners.FirstOrDefault(),
                Statistics = _context.Statistics.ToList()
            };
            return View(homeVM);
        }


    }
}
