using Microsoft.EntityFrameworkCore;
using WebApiApplication;

namespace WebApiApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Ekta" },
                new Product { Id = 2, Name = "Aarti" },
                new Product { Id = 3, Name = "Dhwani" },
                new Product { Id = 4, Name = "Shreya" },
                new Product { Id = 5, Name = "Manali" },
                new Product { Id = 6, Name = "Yukta" },
                new Product { Id = 7, Name = "Disha" },
                new Product { Id = 8, Name = "Naxi" },
                new Product { Id = 9, Name = "Vaishali" },
                new Product { Id = 10, Name = "Chetna" }
                );
        }

        public DbSet<Product>? Products { get; set; }
    }
}
