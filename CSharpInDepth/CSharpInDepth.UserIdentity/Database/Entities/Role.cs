using Microsoft.AspNetCore.Identity;

namespace CSharpInDepth.UserIdentity.Database.Entities
{
    public class Role : IdentityRole, ISoftDeletable
    {
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DeletedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
