using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    class RefreshTokenRepository(ApplicationDbContext applicationDbContext) : IRefreshTokenRepository
    {
        public async Task AddRefreshTokenAsync(RefreshToken refreshToken)
        {
           /* await applicationDbContext.RefreshTokens.AddAsync(refreshToken);
            await applicationDbContext.SaveChangesAsync();*/
        }

        public async Task DeleteRefreshToken(Guid userId)
        {
            /*await applicationDbContext.RefreshTokens
                .Where(r => r.UserId == userId)
                .ExecuteDeleteAsync();

            await applicationDbContext.SaveChangesAsync();*/
        }

        public async Task<RefreshToken> GetRefreshTokenAsync(string refreshToken)
        {
            /*var refreshTokenFromDb = await applicationDbContext.RefreshTokens
                .Include(r => r.User)
                .FirstOrDefaultAsync(r => r.Token == refreshToken);
*/
            return null;
        }

        public void UpdateRefreshToken(RefreshToken refreshToken)
        {
            applicationDbContext.Set<RefreshToken>().Update(refreshToken);
        }
    }
}
