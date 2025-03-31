using CSharpInDepth.UserIdentity.Database;
using Microsoft.EntityFrameworkCore;

namespace CSharpInDepth.UserIdentity.Extensions
{
    public static class MigratoinExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();
        }
    }
}
