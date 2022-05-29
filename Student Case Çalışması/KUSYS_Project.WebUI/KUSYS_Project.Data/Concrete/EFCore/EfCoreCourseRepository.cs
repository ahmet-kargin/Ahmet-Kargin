using KUSYS_Project.Data.Abstract;
using KUSYS_Project.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Data.Concrete.EFCore
{
    public class EfCoreCourseRepository : EfCoreGenericRepository<Course, CourseContext>, ICourseRepository
    {
        public Course GetByIdWithCourses(string id)
        {
            using (var context = new CourseContext())
            {
                return context.Courses
                    .Where(i => i.CourseId == id)
                    .Include(i => i.StudentCourse)
                    .ThenInclude(i => i.Course)
                    .FirstOrDefault();
            }
        }
    }
}
