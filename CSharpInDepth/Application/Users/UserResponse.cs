using Domain.Entities;

namespace Application.Users
{
    public sealed record UserResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string PhoneNumber,
        string Department)
    {
        public static UserResponse FromUser(User user) =>
            new(user.Id,
                user.FirstName,
                user.LastName,
                user.PhoneNumber,
                user.Department);
    }
}