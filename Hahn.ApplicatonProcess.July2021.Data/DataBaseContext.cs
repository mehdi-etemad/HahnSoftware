using Microsoft.EntityFrameworkCore;
using Hahn.ApplicatonProcess.July2021.Data.Entities;
namespace Hahn.ApplicatonProcess.July2021.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase(databaseName: "Hahn");
            optionsBuilder.UseSqlite("Data Source=HahnDataBaseSqlite.db");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    Asset[] Assets = new Asset[] {
        //        new Asset { Id = 1, Symbol = "A", Name = "Aa" },
        //        new Asset { Id = 2, Symbol = "B", Name = "Bb" },
        //        new Asset { Id = 3, Symbol = "C", Name = "Cc" },
        //        new Asset { Id = 4, Symbol = "D", Name = "Dd" },
        //        new Asset { Id = 5, Symbol = "E", Name = "Ee" }
        //    };

        //    modelBuilder.Entity<Asset>().HasData(Assets);

        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<Asset> Asset { get; set; }
        public DbSet<User> User { get; set; }
    }
}