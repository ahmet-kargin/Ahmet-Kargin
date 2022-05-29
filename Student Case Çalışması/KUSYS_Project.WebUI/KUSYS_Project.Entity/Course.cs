using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Entity
{
    public class Course
    {
        public Course()
        {

        }
        //public Course(string courseId, string courseName, List<Student> students, List<StudentCourse> studentCourse)
        //{
        //    CourseId = courseId;
        //    CourseName = courseName;
        //    Students = students;
        //    StudentCourse = studentCourse;
        //}

        public string? CourseId { get; set; }
        public string? CourseName { get; set; }
        public List<Student>? Students { get; set; }
        public List<StudentCourse>? StudentCourse { get; set; }
    }
}
