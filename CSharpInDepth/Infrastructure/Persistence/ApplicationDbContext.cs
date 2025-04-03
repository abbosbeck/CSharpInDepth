using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext<User, Role, Guid>(options)
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<IdentityUserRole<Guid>> UserRoles => Set<IdentityUserRole<Guid>>();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            builder.Ignore<IdentityUserClaim<Guid>>();
            builder.Ignore<IdentityRoleClaim<Guid>>();
            builder.Ignore<IdentityUserToken<Guid>>();
            builder.Ignore<IdentityUserLogin<Guid>>();

            //builder.HasDefaultSchema("identityTables");

            builder.Entity<User>().ToTable("users");
            builder.Entity<Role>().ToTable("roles");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("user_roles");
        }
    }
}
