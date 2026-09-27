using System.Drawing;

namespace University.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public StudentCard StudentCard { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public string? PhoneNumber { get; set; } // Task 9
    }
}
