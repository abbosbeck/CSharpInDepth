using MediatR;

namespace CSharpInDepth.UserIdentity.Application.Members.Login
{
    public record LoginCommand(string Email) : IRequest<string>;
}
