using Application.Abstractions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Members.Login
{
    public sealed class LoginCommandHandler : IRequestHandler<LoginCommand, User>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJWTProvider _jWTProvider;
        public LoginCommandHandler(IUserRepository userRepository, IJWTProvider jWTProvider)
        {
            _userRepository = userRepository;
            _jWTProvider = jWTProvider;
        }

        public async Task<User> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByEmailAsync(request.FirstName);

            if (user is null)
                throw new Exception("Not found");

            //var token = _jWTProvider.Generate(user);

            return user;
        }
    }
}
