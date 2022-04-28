using Example.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Example.Core.Persistence
{
    public class ExampleDbContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        public ExampleDbContext(DbContextOptions<ExampleDbContext> dbContextOptions) 
            : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Scans a given assembly for all types that implement IEntityTypeConfiguration, and registers each one automatically
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
