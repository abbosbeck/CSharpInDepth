using Application.Authentication;
using Application.Common.Interfaces;
using MediatR;

namespace Application.Users.LoginUser
{
    public sealed record LoginUserResponse(string AccessToken, string RefreshToken);
    class LoginUserCommandHandler(
        TokenProvider tokenProvider,
        IUserRepository userRepository,
        IRefreshTokenRepository refreshTokenRepository,
        PasswordHasher passwordHasher)
        : IRequestHandler<LoginUserCommand, LoginUserResponse>
    {
        public async Task<LoginUserResponse> Handle(LoginUserCommand request, CancellationToken cancellationToken)
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

            var token = tokenProvider.Create(user);

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
