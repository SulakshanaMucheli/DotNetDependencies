

using DotNetDependencies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DotNetDependencies.data
{
    public class dataEntityF :DbContext
    {
        private IConfiguration _config;
        public dataEntityF(IConfiguration config)
        {
            _config=config;
        }
     public DbSet<Users>?Users{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
             optionsBuilder.UseSqlServer(_config.GetConnectionString("connection"),
             optionsBuilder=>optionsBuilder.EnableRetryOnFailure());
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Company");
            modelBuilder.Entity<Users>().HasKey(U=>U.userId);
        }
    }
}