using MediatR;

namespace Application.Users.GetUserByPhoneNumber
{
    public sealed record GetUserByPhoneNumberCommand(string phoneNumber) : IRequest<UserResponse>;
}
