using Microsoft.EntityFrameworkCore;
using University.Entities;
namespace University
{
    public class Methods
    {
        private readonly AppDbContext _db;

        public Methods (AppDbContext db)
        {
            _db = db;
        }

        public void ViewAllStudents ()
        {
            var students = _db.Students.ToList();

            foreach(var student in students)
            {
                Console.WriteLine($"Student ID: {student.Id}, Student name: {student.Name}, Student age: {student.Age}, Student Email: {student.Email}");
            }
        }

        public void ViewAllStudentsWithCards()
        {
            var studentsPlusCards = _db.Students.Include(s => s.StudentCard)
                                                .ToList();

            foreach(var student in studentsPlusCards)
            {
                Console.WriteLine($"{student.Name} - Card: {student.StudentCard.CardNumber}");
            }
        }

        public void ViewAllStudentsWithSubjects()
        {
            var students = _db.Students.Include(s => s.StudentCourses)
                                        .ThenInclude(sc => sc.Course)
                                        .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}:");
                foreach (var studentCourse in student.StudentCourses)
                {
                    Console.WriteLine($"  - {studentCourse.Course.Name}");
                }
            }
        }

        public void viewAllTeachers()
        {
            var teachers = _db.Teachers.ToList();

            foreach(var teacher in teachers)
            {
                Console.WriteLine($"Teacher ID: {teacher.Id}, Teacher name: {teacher.Name}, Teacher email: {teacher.Email}");
            }
        }

        public void ViewAllCoursesWithTeachers()
        {
            var courses = _db.Courses.Include(c => c.Teacher)
                                      .ToList();

            foreach (var course in courses)
            {
                Console.WriteLine($"Course: {course.Name} - Teacher: {course.Teacher.Name}");
            }
        }
    }
}
