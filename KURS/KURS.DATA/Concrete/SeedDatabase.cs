using KURS.DATA.Concrete;
using KURS.ENTITY;
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
            var context = new CourseDbContext();
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
            new Course() {CourseFakeId="CSI101",Name="Introduction to Computer Science"},
            new Course() {CourseFakeId="CSI102",Name="Algorithms"},
            new Course() {CourseFakeId="MAT101",Name="Calculus"},
            new Course() {CourseFakeId="PHY101",Name="Physics"}
        };
    }
}
