using Application.Common.Interfaces;
using Domain.Entities;
using System.Data.Entity;

namespace Infrastructure.Persistence.Repositories
{
    class UserRepository(ApplicationDbContext context) : IUserRepository
    {
        public Task<UserEntity> GetAsync(string email)
        {
            var user = context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);

            return user;
        }
    }
}
