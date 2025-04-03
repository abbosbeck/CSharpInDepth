using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence.Repositories
{
    class UserRepository(ApplicationDbContext context) : IUserRepository
    {
        public async Task<User> AddUserAsync(User user)
        {
            var newUser = await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            return newUser.Entity;
        }

        public async Task<User> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);

            return user;
        }
    }
}
