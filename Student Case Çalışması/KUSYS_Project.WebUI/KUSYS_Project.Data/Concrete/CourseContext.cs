using KUSYS_Project.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Data.Concrete
{
    public class CourseContext : DbContext
    {


        //public CourseContext(DbSet<Student> students, DbSet<Course> courses, DbSet<StudentCourse> studentCourses)
        //{
        //    Students = students;
        //    Courses = courses;
        //    StudentCourses = studentCourses;
        //}

        protected readonly IConfiguration Configuration;

        public CourseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("CourseConnection"));
        }

       

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Name=ConnectionStrings:CourseConnection");
        //    }
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Course>().ToTable("Course");
        //    modelBuilder.Entity<StudentCourse>().ToTable("StudentCourse");
        //    modelBuilder.Entity<Student>().ToTable("Student");
        //}
    }
}
