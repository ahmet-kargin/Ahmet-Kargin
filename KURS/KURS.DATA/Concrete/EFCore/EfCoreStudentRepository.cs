using KURS.DATA.Concrete;
using KURS.ENTITY;
using KURS.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.DATA.Concrete.EFCore
{
    public class EfCoreStudentRepository : EfCoreGenericRepository<Student,CourseDbContext>,IStudentRepository
    {

    }
}
