using Application.Abstractions;
using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Members.Login
{
    public sealed class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJWTProvider _jWTProvider;
        public LoginCommandHandler(IUserRepository userRepository, IJWTProvider jWTProvider)
        {
            _userRepository = userRepository;
            _jWTProvider = jWTProvider;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmailAsync(request.Email);

            if (user is null)
                throw new Exception("Not found");

            //var token = _jWTProvider.Generate(user);

            return "token";
        }
    }
}
