using Domain.Entities;

namespace Application.Abstractions
{
    public interface IJWTProvider
    {
        string Generate(UserEntity user);
    }
}
