using Application.Authentication;
using Application.Common.Interfaces;
using MediatR;

namespace Application.Users.LoginUser
{
    public sealed record LoginUserQuery(string phoneNumber, string password) : IRequest<LoginUserResponse>;
    public sealed record LoginUserResponse(string AccessToken, string RefreshToken);
    class LoginUserCommandHandler(
        TokenProvider tokenProvider,
        IUserRepository userRepository,
        IRefreshTokenRepository refreshTokenRepository,
        PasswordHasher passwordHasher)
        : IRequestHandler<LoginUserQuery, LoginUserResponse>
    {
        public async Task<LoginUserResponse> Handle(LoginUserQuery request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByPhoneNumberAsync(request.phoneNumber);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            bool verified = passwordHasher.Verify(request.password, user.PasswordHash);
            if (!verified)
            {
                throw new Exception("Password is not valid");
            }

            var token = await tokenProvider.Create(user);

            var refreshToken = new Domain.Entities.RefreshToken
            {
                Id = Guid.NewGuid(),
                Token = tokenProvider.GenerateRefreshToken(),
                UserId = user.Id,
                ExpiresOnUtc = DateTime.UtcNow.AddDays(7)
            };

            await refreshTokenRepository.AddRefreshTokenAsync(refreshToken);

            return new LoginUserResponse(token, refreshToken.Token);
        }
    }
}
