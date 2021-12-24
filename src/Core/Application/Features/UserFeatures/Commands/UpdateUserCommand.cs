using Application.Features.UserFeatures.Commands;
using MediatR;

namespace Application.Features.ProductFeatures.Commands
{
    public class UpdateUserCommand : Common, IRequest<int>
    {
        public int Id { get; set; }
    }
}
