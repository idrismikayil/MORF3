using Domain.Entities;
using MediatR;

namespace Application.PageDetails.PartnerPageDetails.Queries
{
    public class GetAllPartnersQuery : IRequest<IEnumerable<Partner>>
    {

    }
}
