using Microsoft.EntityFrameworkCore;

namespace demoApi.Data
{
    public class APIEnities : DbContext
    {
        public APIEnities(DbContextOptions options) : base(options) { }
        #region DbSet
        public DbSet<Person> Persons{get; set;}
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(e =>
            {
                e.ToTable("Person");
            }


                );
        }
    }
}
