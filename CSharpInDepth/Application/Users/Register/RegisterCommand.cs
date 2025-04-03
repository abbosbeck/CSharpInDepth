using MediatR;

namespace Application.Users.Register
{
    public sealed record RegisterCommand(
        string FirstName,
        string LastName,
        string Department,
        string PhoneNumber,
        string Password)
        : IRequest<UserResponse>;
}
