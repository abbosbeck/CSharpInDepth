using Microsoft.AspNetCore.Identity;

namespace CSharpInDepth.UserIdentity.Database.Entities
{
    public class Role : IdentityRole, ISoftDeletable
    {
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
