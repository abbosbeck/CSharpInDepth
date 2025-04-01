using CSharpInDepth.UserIdentity.Application.Abstractions;
using CSharpInDepth.UserIdentity.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CSharpInDepth.UserIdentity.Application.Members.Login
{
    public sealed class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly ApplicationDbContext _applicationDb;
        private readonly IJWTProvider _jWTProvider;
        public LoginCommandHandler(ApplicationDbContext applicationDbContext, IJWTProvider jWTProvider)
        {
            _applicationDb = applicationDbContext;
            _jWTProvider = jWTProvider;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _applicationDb.Users.FirstOrDefaultAsync(x => x.Email == request.Email);

            if (user is null)
                throw new Exception("Not found");

            var token = _jWTProvider.Generate(user);

            return token;
        }
    }
}
