using Domain.Entities;
using Domain.Entities.Home;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
    }
}
