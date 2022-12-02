using Microsoft.EntityFrameworkCore;
using ShopAPI.Models.Entity;

namespace ShopAPI.Models.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<SampleModel> Samples { get; set; }
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
