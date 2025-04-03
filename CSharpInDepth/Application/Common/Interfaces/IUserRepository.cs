using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByFirstNameAsync(string firstName);
    }
}
