using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURS.ENTITY
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public string? CourseFakeId { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
