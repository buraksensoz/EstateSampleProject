using AppStoreOne.DataAccess.Concrete.EfCore.Map;
using AppStoreOne.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace AppStoreOne.DataAccess.Concrete.EfCore.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbfile = Path.Combine(Directory.GetCurrentDirectory(), @"Data\estate.db");
            optionsBuilder.UseSqlite($"Data Source={dbfile}");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new EstateMap());

        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Estate> estates { get; set; }




    }
}
