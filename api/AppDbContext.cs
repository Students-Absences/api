using api.Models;
using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppSettings> AppSettings => Set<AppSettings>();
}