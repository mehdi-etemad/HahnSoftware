using Microsoft.EntityFrameworkCore;
using Hahn.ApplicatonProcess.July2021.Data.Models;
namespace Hahn.ApplicatonProcess.July2021.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "Hahn");
        }
        /*  For Migration   */
        public DbSet<Asset> Asset { get; set; }
        public DbSet<User> User { get; set; }
    }
}