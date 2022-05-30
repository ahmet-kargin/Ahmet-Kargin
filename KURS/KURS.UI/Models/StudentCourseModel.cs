using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KURS.UI.Models
{
    public class StudentCourseModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public int CourseId { get; set; }
    }
}
