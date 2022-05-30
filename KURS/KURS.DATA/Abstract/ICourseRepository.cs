using KURS.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Data.Abstract
{
    public interface ICourseRepository : IRepository<Course>
    {
        Course GetByIdWithCourses(string id);
    }
}
