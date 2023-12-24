using Application.PageDetails.PartnerPageDetails.Responses;
using MediatR;

namespace Application.PageDetails.PartnerPageDetails.Commands
{
    public class GetAllPartnersCommand : IRequest<List<GetAllPartnersResponse>>
    {

    }
}
