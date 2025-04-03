using Application.Common.Interfaces;
using MediatR;

namespace Application.Users.GetUserByPhoneNumber
{
    public sealed class GetUserByPhoneNumberCommandHandler(
        IUserRepository userRepository) 
        : IRequestHandler<GetUserByPhoneNumberCommand, UserResponse>
    {
        public async Task<UserResponse> Handle(
            GetUserByPhoneNumberCommand request, 
            CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByPhoneNumberAsync(
                request.phoneNumber);

            return UserResponse.FromUser(user);
        }
    }
}
