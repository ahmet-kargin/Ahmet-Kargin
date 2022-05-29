using KUSYS_Project.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Data.Concrete
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new CourseContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Courses ==null || context.Courses.Count()==0)
                {
                    if (context.Courses != null)
                    {
                        context.Courses.AddRange(Courses);
                    }
                    
                }
            }
            context.SaveChanges();
        }
        private static Course[] Courses =
        {
            new Course() {CourseId="CSI101",CourseName="Introduction to Computer Science"},
            new Course() {CourseId="CSI102",CourseName="Algorithms"},
            new Course() {CourseId="MAT101",CourseName="Calculus"},
            new Course() {CourseId="PHY101",CourseName="Physics"}
        };
    }
}
