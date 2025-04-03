using MediatR;

namespace Application.Users.LoginUser
{
    public sealed record LoginUserCommand(string phoneNumber, string password) : IRequest<LoginUserResponse>;
}
