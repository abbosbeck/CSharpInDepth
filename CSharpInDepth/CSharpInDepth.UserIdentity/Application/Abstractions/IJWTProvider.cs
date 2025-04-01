using Domain.Entities;

namespace CSharpInDepth.UserIdentity.Application.Abstractions
{
    public interface IJWTProvider
    {
        string Generate(UserEntity user);
    }
}
