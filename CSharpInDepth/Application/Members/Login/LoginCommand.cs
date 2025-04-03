using Domain.Entities;
using MediatR;

namespace Application.Members.Login
{
    public record LoginCommand(string FirstName) : IRequest<User>;
}
