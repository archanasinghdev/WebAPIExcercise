using Domain;
using MediatR;

namespace Application.Features.ProductFeatures.Queries
{
    public class GetUserByIdQuery : IRequest<ApplicationUser>
    {
        public int Id { get; set; }

    }
}
