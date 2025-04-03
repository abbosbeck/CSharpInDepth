using MediatR;

namespace Application.Users.RevokeRefreshToken
{
    public sealed record RevokeRefreshTokenCommand(Guid userId) : IRequest<bool>;
}
