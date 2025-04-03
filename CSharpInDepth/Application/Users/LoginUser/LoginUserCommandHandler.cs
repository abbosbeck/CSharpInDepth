using Application.Authentication;
using Application.Common.Interfaces;
using Domain;
using Domain.Entities;
using MediatR;

namespace Application.Users.LoginUser
{
    class LoginUserCommandHandler(TokenProvider tokenProvider, IUserRepository userRepository, PasswordHasher passwordHasher) : IRequestHandler<LoginUserCommand, string>
    {
        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByPhoneNumberAsync(request.phoneNumber);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            bool verified = passwordHasher.Verify(request.password, user.PasswordHash);
            if (!verified)
            {
                throw new Exception("Password is not valid");
            }


            var token = tokenProvider.Create(user);

            return token;
        }
    }
}
