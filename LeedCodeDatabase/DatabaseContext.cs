using LeedCodeDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace LeedCodeDatabase
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.EnsureCreated();
            Database.Migrate();
        }

        public DbSet<Beer> Beers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            //var connectionStringBuilder = new
            //    SqliteConnectionStringBuilder {DataSource = "beer.db"}.ToString();

            //var connection = new SqliteConnection(connectionStringBuilder);
            //optionsBuilder.UseSqlite(connection);
        }
    }
}