using Domain.Entities;

namespace Application.Abstractions
{
    public interface IJWTProvider
    {
        string Generate(User user);
    }
}
