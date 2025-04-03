using MediatR;

namespace Application.Members.Register
{
    public sealed record RegisterCommand(
        string FirstName, 
        string LastName, 
        string Department,
        string PhoneNumber, 
        string Password) 
        : IRequest<UserResponse>;
}
