using Application.Features.UserFeatures.Commands;
using MediatR;

namespace Application.Features.ProductFeatures.Commands
{
    public class CreateUserCommand : Common, IRequest<int>
    {

    }
}
