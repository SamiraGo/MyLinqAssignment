using Labb2_Linq.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb2_Linq.Context
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Teacher_Course> Teacher_Courses { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-358RPE4\SQLEXPRESS; 
                                        Initial Catalog = SchoolDb; Integrated Security = True;");
        }

    }
}
