using KURS.DATA.Abstract;
using KURS.DATA.Concrete.EFCore;
using KURS.ENTITY;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.DATA.Concrete.EFCore
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
