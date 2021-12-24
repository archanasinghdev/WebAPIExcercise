using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _userRepository;

        public UserRepository(ApplicationDbContext userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await _userRepository.Users.ToListAsync(cancellationToken);
        }

        public async Task<ApplicationUser> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _userRepository.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<int> AddAsync(ApplicationUser user, CancellationToken cancellationToken = default)
        {
            await _userRepository.AddAsync(user, cancellationToken);
            await _userRepository.SaveChangesAsync(cancellationToken);
            return user.Id;
        }

        public async Task<int> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken = default)
        {
            _userRepository.Update(user);
            await _userRepository.SaveChangesAsync(cancellationToken);
            return user.Id;
        }
    }
}
