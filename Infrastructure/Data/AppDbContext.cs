using Domain;
using Domain.Entities;
using Domain.Entities.Home;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data
{
    public class AppDbContext(IConfiguration _configuration, DbContextOptions<AppDbContext> options) : DbContext(options) 
    {
        #region Home
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Partner> Partners { get; set; }
        #endregion
        #region Footer
        public DbSet<Address> Addresses { get; set; }
        #endregion
        public DbSet<User> Users { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            MySqlServerVersion? serverVersion = new(new Version(8, 2, 0));
            optionsBuilder.UseMySql(_configuration.GetConnectionString("DefaultConnection") ?? throw new ConnectionStringNotFound(), serverVersion);
        }
    }
}