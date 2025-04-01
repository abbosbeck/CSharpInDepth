using Domain.Common;
using Microsoft.AspNetCore.Identity;
// try to resolve the missing reference by adding the following using statement: using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class UserEntity : IdentityUser, ISoftDeletable
    {
        public string? Intials { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
