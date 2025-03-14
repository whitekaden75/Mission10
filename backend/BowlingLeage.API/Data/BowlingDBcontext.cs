using Microsoft.EntityFrameworkCore;

namespace BowlingLeage.API.Data;

public class BowlingDBcontext : DbContext
{
    public BowlingDBcontext(DbContextOptions<BowlingDBcontext> options) : base(options)
    {
    }
    public DbSet<Bowlers> Bowlers { get; set; }
    public DbSet<Teams> Teams { get; set; }
}