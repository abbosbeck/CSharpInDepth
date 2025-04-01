using Microsoft.AspNetCore.Identity;

namespace CSharpInDepth.UserIdentity.Database.Entities
{
    public class User : IdentityUser, ISoftDeletable
    {
        public string? Intials { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
