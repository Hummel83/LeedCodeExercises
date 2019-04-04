using LeedCodeDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace LeedCodeDatabase
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() :base()         
        {
        }
    

         public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}