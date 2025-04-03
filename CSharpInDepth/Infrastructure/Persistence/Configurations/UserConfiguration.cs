using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.Property(u => u.Intials)
                .HasMaxLength(5);

            builder.HasQueryFilter(u => !u.IsDeleted);

            builder.Ignore(u => u.Email);
            builder.Ignore(u => u.NormalizedEmail);
            builder.Ignore(u => u.EmailConfirmed);
            builder.Ignore(u => u.LockoutEnabled);
            builder.Ignore(u => u.LockoutEnd);
            builder.Ignore(u => u.UserName);
            builder.Ignore(u => u.NormalizedUserName);
            builder.Ignore(u => u.AccessFailedCount);
            builder.Ignore(u => u.TwoFactorEnabled);
            builder.Ignore(u => u.PhoneNumberConfirmed);
        }
    }
}
