
using Application.PageDetails.PartnerPageDetails.Queries;
using Domain.Entities;
using Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;


namespace MVC.Controllers
{
    public class HomeController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;

        public IActionResult Index()
        {
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
