using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Users.Register
{
    public class RegisterCommandHandler(IUserRepository userRepository) : IRequestHandler<RegisterCommand, UserResponse>
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
                    ? User.HashPassword(request.Password)
                    : throw new Exception("Password is not valid"),
            };
            await userRepository.AddUserAsync(user);

            return UserResponse.FromUser(user);
        }
    }
}
