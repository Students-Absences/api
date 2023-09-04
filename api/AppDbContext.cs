using api.Models;
using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppSettings>().HasData(
            new AppSettings {
                Id = 1,
                SchoolName = "5ο Λύκειο Βύρωνα",
                SchoolLogoUrl = "https://5lykeiovyrona.gr/img/logo-mobile.png"
            }
        );
    }

    public DbSet<AppSettings> AppSettings => Set<AppSettings>();
}