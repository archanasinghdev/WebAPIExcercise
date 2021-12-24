using Application.Interfaces;
using Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Queries
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, ApplicationUser>
    {
        private readonly IUserRepository _context;
        public GetUserByIdQueryHandler(IUserRepository context)
        {
            _context = context;
        }
        public async Task<ApplicationUser> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
        {
            var user = await _context.GetByIdAsync(query.Id, cancellationToken);
            if (user == null)
            {
                return null;
            }

            return user;
        }
    }
}
