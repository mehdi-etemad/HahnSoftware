using Hahn.ApplicatonProcess.July2021.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Hahn.ApplicatonProcess.July2021.Data.Data
{
    class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseInMemoryDatabase(databaseName: "Hahn");
        //}
        //public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) {}

        public DbSet<Asset> Assets { get; set; }
        public DbSet<User> User { get; set; }
    }
}