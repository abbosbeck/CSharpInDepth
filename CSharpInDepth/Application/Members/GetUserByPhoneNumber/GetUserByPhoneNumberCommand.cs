using MediatR;

namespace Application.Members.GetUserByPhoneNumber
{
    public sealed record GetUserByPhoneNumberCommand(string phoneNumber) : IRequest<UserResponse>;
}
