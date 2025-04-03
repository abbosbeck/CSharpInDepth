using MediatR;

namespace Application.Users.RefreshToken
{
    public sealed record RefreshTokenCommand(string RefreshToken) : IRequest<RefreshTokenResponse>;
}
