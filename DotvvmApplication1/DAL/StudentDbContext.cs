using Microsoft.EntityFrameworkCore;
using DotvvmApplication1.DAL.Entities;

namespace DotvvmApplication1.DAL
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; }
    }
}
