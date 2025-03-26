using AspDotNetInDepth.Models;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetInDepth.DataAccess;

public class PlayersDBContext : DbContext
{
    public PlayersDBContext(DbContextOptions<PlayersDBContext> options)
        : base(options) { }

    public DbSet<Player> Players { get; set; }
}