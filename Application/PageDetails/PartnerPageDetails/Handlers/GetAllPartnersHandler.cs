using Application.PageDetails.PartnerPageDetails.Queries;
using Domain.Entities;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.PageDetails.PartnerPageDetails.Handlers
{
    public class GetAllPartnersHandle(AppDbContext context) : IRequestHandler<GetAllPartnersQuery, IEnumerable<Partner>>
    {
        public async Task<IEnumerable<Partner>> Handle(GetAllPartnersQuery request, CancellationToken cancellationToken)
        {
            List<Partner> data = await context.Partners.ToListAsync(cancellationToken: cancellationToken);
            return data.AsEnumerable();
        }
    }
}