using Domain.Entities;
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
                        PhoneNumber = "1234567890",
                        IsDeleted = false,
                        CreatedOn = DateTime.UtcNow,
                        CreatedBy = "System",
                        LastModifiedOn = DateTime.UtcNow,
                        LastModifiedBy = "System",
                        PasswordHash = "hashedpassword",
                        SecurityStamp = "securitystamp",
                        ConcurrencyStamp = "concurrencystamp"
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

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during seeding: " + ex);
                throw;
            }
        }
    }
}
