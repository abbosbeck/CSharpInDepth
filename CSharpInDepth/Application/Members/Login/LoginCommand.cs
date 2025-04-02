using MediatR;

namespace Application.Members.Login
{
    public record LoginCommand(string Email) : IRequest<string>;
}
