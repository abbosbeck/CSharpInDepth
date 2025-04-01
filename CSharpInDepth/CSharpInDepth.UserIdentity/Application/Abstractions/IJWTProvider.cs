using CSharpInDepth.UserIdentity.Database.Entities;

namespace CSharpInDepth.UserIdentity.Application.Abstractions
{
    public interface IJWTProvider
    {
        string Generate(User user);
    }
}
