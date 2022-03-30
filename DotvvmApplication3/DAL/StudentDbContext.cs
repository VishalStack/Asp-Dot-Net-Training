using Microsoft.EntityFrameworkCore;
using DotvvmApplication3.DAL.Entities;

namespace DotvvmApplication3.DAL
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
