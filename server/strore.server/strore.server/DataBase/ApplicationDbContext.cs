using Microsoft.EntityFrameworkCore;
using strore.server.Models;

namespace strore.server.DataBase;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        new DbInitializer(modelBuilder).Seed();
    }
}
