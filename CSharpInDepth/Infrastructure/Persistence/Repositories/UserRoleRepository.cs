using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class UserRoleRepository(ApplicationDbContext applicationDbContext) : IUserRoleRepository
    {
        public async Task<List<string>> GetUserRoleAsync(Guid userId)
        {
            var userRole = await applicationDbContext.UserRoles
                .Where(ur => ur.UserId == userId)
                .Select(ur => ur.Role.Name)
                .ToListAsync();

            return userRole;
        }
    }
}
