using Application.PageDetails.PartnerPageDetails.Commands;
using Application.PageDetails.PartnerPageDetails.Responses;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.PageDetails.PartnerPageDetails.Handlers
{
    public class GetAllPartnersHandler(AppDbContext context) : IRequestHandler<GetAllPartnersCommand, List<GetAllPartnersResponse>>
    {
        async Task<List<GetAllPartnersResponse>> IRequestHandler<GetAllPartnersCommand, List<GetAllPartnersResponse>>.Handle(GetAllPartnersCommand request, CancellationToken cancellationToken)
        {
            return await context.Partners.Select(x => new GetAllPartnersResponse
            {
                Link = x.Link,
                ImageLink = x.ImageTitle
            }).ToListAsync(cancellationToken);
        }
    }
}