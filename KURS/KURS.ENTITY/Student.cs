namespace KURS.ENTITY
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
