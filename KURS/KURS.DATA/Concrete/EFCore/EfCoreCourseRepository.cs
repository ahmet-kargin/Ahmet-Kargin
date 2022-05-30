using KURS.DATA.Concrete;
using KURS.ENTITY;
using KUSYS_Project.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Data.Concrete.EFCore
{
    public class EfCoreCourseRepository : EfCoreGenericRepository<Course, CourseDbContext>, ICourseRepository
    {
        public Course GetByIdWithCourses(string id)
        {
            using (var context = new CourseDbContext())
            {
                return context.Courses
                    .Where(i => i.CourseFakeId == id)
                    .Include(i => i.StudentCourses)
                    .ThenInclude(i => i.Course)
                    .FirstOrDefault();
            }
        }
    }
}
