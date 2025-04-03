using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IRefreshTokenRepository
    {
        Task AddRefreshTokenAsync(RefreshToken refreshToken);
        Task<RefreshToken> GetRefreshTokenAsync(string refreshToken);
        void UpdateRefreshToken(RefreshToken refreshToken);
    }
}
