using Application.Abstractions;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Members.GetUserByPhoneNumber
{
    public sealed class GetUserByPhoneNumberCommandHandler(IUserRepository userRepository) : IRequestHandler<GetUserByPhoneNumberCommand, User>
    {
        public async Task<User> Handle(GetUserByPhoneNumberCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByFirstNameAsync(request.phoneNumber);

            return user;
        }
    }
}
