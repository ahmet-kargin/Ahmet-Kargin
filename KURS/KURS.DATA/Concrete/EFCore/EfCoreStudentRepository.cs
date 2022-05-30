using KURS.DATA.Concrete;
using KURS.ENTITY;
using KUSYS_Project.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Data.Concrete.EFCore
{
    public class EfCoreStudentRepository : EfCoreGenericRepository<Student,CourseDbContext>,IStudentRepository
    {

    }
}
