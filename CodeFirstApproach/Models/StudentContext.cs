using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDatabase")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}