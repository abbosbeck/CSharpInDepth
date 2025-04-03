using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence.Repositories
{
    class UserRepository(ApplicationDbContext context) : IUserRepository
    {
        public async Task<User> GetUserByFirstNameAsync(string firstName)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.FirstName == firstName);

            return user;
        }
    }
}
