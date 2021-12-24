using Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
    {
        private readonly IUserRepository _context;
        public UpdateUserCommandHandler(IUserRepository context)
        {
            _context = context;
        }
        public async Task<int> Handle(UpdateUserCommand command, CancellationToken cancellationToken = default)
        {
            var user = await _context.GetByIdAsync(command.Id, cancellationToken);
            user.Name = command.Name;
            user.Email = command.Email;
            user.Age = command.Age;
            user.Address = command.Address;

            return await _context.UpdateAsync(user, cancellationToken);
        }
    }
}
