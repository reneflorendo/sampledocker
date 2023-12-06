using Microsoft.EntityFrameworkCore;

namespace webapentityframeworkdocker.Models
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2); // Adjust precision and scale as needed
        }


        public DbSet<Product>? Products { get; set; }
    }
}
