using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence
{
    public static class InitializerExtensions
    {
        public static async Task InitialiseDatabaseAsync(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();

            var initializer = scope.ServiceProvider.GetRequiredService<AppDbContextInitializer>();

            await initializer.InitialiseAsync();
            await initializer.SeedAsync();
        }
    }
    public class AppDbContextInitializer(ApplicationDbContext dbContext)
    {
        public async Task InitialiseAsync()
        {
            try
            {
                await dbContext.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during database migration: {ex}");
                throw;
            }
        }

        public async Task SeedAsync()
        {
            try
            {
                if (!await dbContext.Set<User>().AnyAsync())
                {
                    dbContext.Set<User>().Add(new User
                    {
                        FirstName = "Admin",
                        LastName = "Admin",
                        Department = "Admin",
                        PhoneNumber = "991112233",
                        IsDeleted = false,
                        CreatedOn = DateTime.UtcNow,
                        CreatedBy = "System",
                        LastModifiedOn = DateTime.UtcNow,
                        LastModifiedBy = "System",
                        PasswordHash = HashPassword("Admin1234!"),
                    });

                    dbContext.Set<User>().Add(new User
                    {
                        FirstName = "John",
                        LastName = "John",
                        Department = "Workers",
                        PhoneNumber = "951112233",
                        IsDeleted = false,
                        CreatedOn = DateTime.UtcNow,
                        CreatedBy = "System",
                        LastModifiedOn = DateTime.UtcNow,
                        LastModifiedBy = "System",
                        PasswordHash = HashPassword("John1234!"),
                    });

                    await dbContext.SaveChangesAsync();
                }

                if (!await dbContext.Set<Role>().AnyAsync())
                {
                    dbContext.Set<Role>().Add(new Role
                    {
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                        Description = "Administrator role",
                        IsDeleted = false,
                        CreatedOn = DateTime.UtcNow,
                        CreatedBy = "System",
                        LastModifiedOn = DateTime.UtcNow,
                        LastModifiedBy = "System"
                    });
                    dbContext.Set<Role>().Add(new Role
                    {
                        Name = "User",
                        NormalizedName = "USER",
                        Description = "User role",
                        IsDeleted = false,
                        CreatedOn = DateTime.UtcNow,
                        CreatedBy = "System",
                        LastModifiedOn = DateTime.UtcNow,
                        LastModifiedBy = "System"
                    });

                    await dbContext.SaveChangesAsync();
                }

                if (!await dbContext.Set<IdentityUserRole<Guid>>().AnyAsync())
                {
                    var adminRole = await dbContext.Set<Role>().FirstOrDefaultAsync(r => r.Name == "Admin");
                    var adminUser = await dbContext.Set<User>().FirstOrDefaultAsync(u => u.FirstName == "Admin");

                    if (adminRole != null && adminUser != null)
                    {
                        dbContext.Set<IdentityUserRole<Guid>>().Add(new IdentityUserRole<Guid>
                        {
                            UserId = adminUser.Id,
                            RoleId = adminRole.Id
                        });
                    }

                    var userRole = await dbContext.Set<Role>().FirstOrDefaultAsync(r => r.Name == "User");
                    var justUser = await dbContext.Set<User>().FirstOrDefaultAsync(u => u.FirstName == "John");
                    if (userRole != null && justUser != null)
                    {
                        dbContext.Set<IdentityUserRole<Guid>>().Add(new IdentityUserRole<Guid>
                        {
                            UserId = justUser.Id,
                            RoleId = userRole.Id
                        });
                    }

                    await dbContext.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during seeding: " + ex);
                throw;
            }
        }

        private static string HashPassword(string password)
        {
            var passwordHasher = new Microsoft.AspNet.Identity.PasswordHasher();
            var hashedPassword = passwordHasher.HashPassword(password);

            return hashedPassword;
        }
    }
}
