using Microsoft.AspNetCore.Authorization;

namespace Application.Authentication
{
    public class AllowedFor(string role) : AuthorizeAttribute()
    {
    }
}
