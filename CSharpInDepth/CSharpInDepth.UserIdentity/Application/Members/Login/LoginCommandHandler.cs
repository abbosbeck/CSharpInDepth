using CSharpInDepth.UserIdentity.Application.Abstractions;
using CSharpInDepth.UserIdentity.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CSharpInDepth.UserIdentity.Application.Members.Login
{
    public sealed class LoginCommandHandler(ApplicationDbContext applicationDbContext, IJWTProvider jWTProvider) : IRequestHandler<LoginCommand, string>
    {
        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await applicationDbContext.Users.FirstOrDefaultAsync(x => x.Email == request.Email);

            if (user is null)
                throw new Exception("Not found");

            var token = jWTProvider.Generate(user);

            return token;
        }
    }
}
