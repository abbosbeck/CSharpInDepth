using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByPhoneNumberAsync(string phoneNumber);
        Task<User> AddUserAsync(User user);
    }
}
