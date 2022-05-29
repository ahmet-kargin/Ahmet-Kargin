using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Entity
{
    public class StudentCourse
    {
        public StudentCourse(int studentCourseId, string courseId, Course course, int studentId, Student student)
        {
            StudentCourseId = studentCourseId;
            CourseId = courseId;
            Course = course;
            StudentId = studentId;
            Student = student;
        }

        public int StudentCourseId { get; set; }
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
