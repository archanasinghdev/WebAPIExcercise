using Application.DTOs;
using Application.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Queries
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        private readonly IUserRepository _context;
        public GetAllUsersQueryHandler(IUserRepository context)
        {
            _context = context;
        }
        public async Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery query, CancellationToken cancellationToken = default)
        {
            var userList = await _context.GetAsync(cancellationToken);
            if (userList == null)
            {
                return null;
            }
            var usersDto = userList.Select(x => new UserDto { Id = x.Id, Name = x.Name, Email = x.Email, Age = x.Age, Address = x.Address }).ToList();

            return usersDto;

        }
    }
}
