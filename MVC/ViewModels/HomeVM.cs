using Application.PageDetails.PartnerPageDetails.Responses;
using Domain.Entities;
using Domain.Entities.Home;
using MediatR;

namespace MVC.ViewModels
{
    public class HomeVM
    {
        public Banner Banner { get; set; }
        public List<Statistic> Statistics { get; set; }
        public List<Partner> Partners { get; set; }
    }
}
