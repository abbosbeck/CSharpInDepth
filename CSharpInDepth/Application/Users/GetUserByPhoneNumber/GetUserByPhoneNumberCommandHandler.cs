using Application.Common.Interfaces;
using MediatR;

namespace Application.Users.GetUserByPhoneNumber;

public sealed record GetUserByPhoneNumberQuery(string phoneNumber) : IRequest<UserResponse>;
public sealed class GetUserByPhoneNumberQueryHandler(
    IUserRepository userRepository)
    : IRequestHandler<GetUserByPhoneNumberQuery, UserResponse>
{
    public async Task<UserResponse> Handle(
        GetUserByPhoneNumberQuery request,
        CancellationToken cancellationToken)
    {
        var user = await userRepository.GetUserByPhoneNumberAsync(
            request.phoneNumber);

        return UserResponse.FromUser(user);
    }
}
