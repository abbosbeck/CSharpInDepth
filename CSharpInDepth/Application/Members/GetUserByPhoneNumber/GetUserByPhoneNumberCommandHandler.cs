using Application.Abstractions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Members.GetUserByPhoneNumber
{
    public sealed class GetUserByPhoneNumberCommandHandler(IUserRepository userRepository) : IRequestHandler<GetUserByPhoneNumberCommand, UserResponse>
    {
        public async Task<UserResponse> Handle(GetUserByPhoneNumberCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByPhoneNumberAsync(request.phoneNumber);

            return UserResponse.FromUser(user);
        }
    }
}
