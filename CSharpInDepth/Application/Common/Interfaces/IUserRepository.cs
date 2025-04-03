using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity> GetAsync(string email);
    }
}
