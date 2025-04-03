using Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class Role : IdentityRole, ISoftDeletable
    {
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
