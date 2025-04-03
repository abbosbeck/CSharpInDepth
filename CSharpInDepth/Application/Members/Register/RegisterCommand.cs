using MediatR;

namespace Application.Members.Register
{
    public sealed record RegisterCommand(
        string FirstName, 
        string LastName, 
        string PhoneNumber, 
        string Password) 
        : IRequest<UserResponse>;
}
