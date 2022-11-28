using Microsoft.EntityFrameworkCore;

namespace ShopAPI.Models.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<SampleModel> Samples { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
