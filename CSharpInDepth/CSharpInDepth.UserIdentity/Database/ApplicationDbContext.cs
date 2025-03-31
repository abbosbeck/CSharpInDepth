using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace CSharpInDepth.UserIdentity.Database
{
    public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {

     
    }
}
