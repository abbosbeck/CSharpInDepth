using Application.Authentication;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Users.Register
{
    public class RegisterCommandHandler(IUserRepository userRepository, PasswordHasher passwordHasher) : IRequestHandler<RegisterCommand, UserResponse>
    {
        public async Task<UserResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                Department = request.Department,
                PasswordHash = User.ValidatePassword(request.Password)
                    ? passwordHasher.Hash(request.Password)
                    : throw new Exception("Password is not valid"),
            };
            await userRepository.AddUserAsync(user);

            return UserResponse.FromUser(user);
        }
    }
}
