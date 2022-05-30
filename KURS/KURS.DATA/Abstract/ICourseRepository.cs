using KURS.ENTITY;
using KURS.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.DATA.Abstract
{
    public interface ICourseRepository : IRepository<Course>
    {
        Course GetByIdWithCourses(string id);
    }
}
