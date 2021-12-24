using Application.DTOs;
using MediatR;
using System.Collections.Generic;

namespace Application.Features.ProductFeatures.Queries
{
    public class GetAllUsersQuery : IRequest<IEnumerable<UserDto>>
    {


    }
}
