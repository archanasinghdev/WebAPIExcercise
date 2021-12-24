using Application.Interfaces;
using Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserRepository _context;
        public CreateUserCommandHandler(IUserRepository context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken = default)
        {
            var user = new ApplicationUser
            {
                Name = command.Name,
                Email = command.Email,
                Age = command.Age,
                Address = command.Address
            };

            var newUserId = await _context.AddAsync(user, cancellationToken);

            return newUserId;
        }
    }
}
