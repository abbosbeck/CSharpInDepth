using CSharpInDepth.UserIdentity.Database;

namespace CSharpInDepth.UserIdentity.Application.Abstractions
{
    public interface IJWTProvider
    {
        string Generate(User user);
    }
}
