using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Domain.Entities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}
