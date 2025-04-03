using Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class User : IdentityUser, ISoftDeletable
    {
        public string? Intials { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
