using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Project.Entity
{
    [Table("Student")]
    public class Student
    {
        public Student(int studentId, string firstName, string lastName, DateTime birth, int courseId, Course course, List<StudentCourse> studentCourse)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Birth = birth;
            CourseId = courseId;
            Course = course;
            StudentCourse = studentCourse;
        }
    
       
        public int StudentId { get; set; }
    
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<StudentCourse> StudentCourse { get; set; }
    }
}
