using Domain;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAsync(CancellationToken cancellationToken = default);
        Task<ApplicationUser> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<int> AddAsync(ApplicationUser user, CancellationToken cancellationToken = default);
        Task<int> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken = default);

    }
}
