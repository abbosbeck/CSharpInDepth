using Microsoft.AspNetCore.Identity;

namespace CSharpInDepth.UserIdentity.Database
{
    public class User : IdentityUser
    {
        public string? Intials { get; set; }
    }
}
