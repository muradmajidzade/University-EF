using Microsoft.EntityFrameworkCore;
using University;
using University.Entities;

var db = new AppDbContext();

//var student1 = new Student
//{
//    Name = "Murad",
//    Email = "muradm@gmail.com",
//    Age = 18
//};

//var student2 = new Student
//{
//    Name = "Ali",
//    Email = "ali@gmail.com",
//    Age = 20
//};

//var student3 = new Student
//{
//    Name = "Javid",
//    Email = "javid@gmail.com",
//    Age = 24
//};

//var student4 = new Student
//{
//    Name = "Leyla",
//    Email = "leyla@gmail.com",
//    Age = 19
//};

//var student5 = new Student
//{
//    Name = "Narine",
//    Email = "narine@gmail.com",
//    Age = 21
//};


//var teacher1 = new Teacher
//{
//    Name = "Musa",
//    Email = "musamahmudov03@gmail.com"
//};

//var teacher2 = new Teacher
//{
//    Name = "Farhad",
//    Email = "farhad@gmail.com"
//};

//var teacher3 = new Teacher
//{
//    Name = "Irina",
//    Email = "irina@gmail.com"
//};


//var course1 = new Course
//{
//    Name = "C#/C++",
//    Description = "Learn fundamentals of C# and C++ programming. Includes OOP, syntax, memory management, and best practices.",
//    TeacherId = 1
//};

//var course2 = new Course
//{
//    Name = "Python",
//    Description = "Introduction to Python programming. Python syntax, libraries, automation, scripting, and data processing.",
//    TeacherId = 2
//};

//var course3 = new Course
//{
//    Name = "Java",
//    Description = "Complete Java course. JVM, multithreading, collections, Spring and Hibernate frameworks.",
//    TeacherId = 3
//};

//var course4 = new Course
//{
//    Name = "JavaScript",
//    Description = "Frontend and Backend JavaScript. Node.js, Express, React, asynchronous programming, and web APIs.",
//    TeacherId = 1
//};

//var course5 = new Course
//{
//    Name = "SQL",
//    Description = "Database management and SQL. Queries, indexes, optimization, normalization, and database design.",
//    TeacherId = 2
//};


//var studentCard1 = new StudentCard
//{
//    CardNumber = "A1BC",
//    IssueDate = new DateOnly(2026, 9, 11),
//    StudentId = 1
//};

//var studentCard2 = new StudentCard
//{
//    CardNumber = "D2EF",
//    IssueDate = new DateOnly(2026, 9, 11),
//    StudentId = 2
//};

//var studentCard3 = new StudentCard
//{
//    CardNumber = "G3HI",
//    IssueDate = new DateOnly(2026, 9, 11),
//    StudentId = 3
//};

//var studentCard4 = new StudentCard
//{
//    CardNumber = "J4KL",
//    IssueDate = new DateOnly(2026, 9, 11),
//    StudentId = 4
//};

//var studentCard5 = new StudentCard
//{
//    CardNumber = "M5NO",
//    IssueDate = new DateOnly(2026, 9, 11),
//    StudentId = 5
//};

//db.Teachers.AddRange(teacher1, teacher2, teacher3);
//db.SaveChanges();
//db.Courses.AddRange(course1, course2, course3, course4, course5);
//db.SaveChanges();
//db.Students.AddRange(student1, student2, student3, student4, student5);
//db.SaveChanges();
//db.StudentCards.AddRange(studentCard1, studentCard2, studentCard3, studentCard4, studentCard5);
//db.SaveChanges();


//var studentCourse1 = new StudentCourse { StudentId = 1, CourseId = 1 };
//var studentCourse2 = new StudentCourse { StudentId = 1, CourseId = 2 };
//var studentCourse3 = new StudentCourse { StudentId = 2, CourseId = 2 };
//var studentCourse4 = new StudentCourse { StudentId = 2, CourseId = 3 };
//var studentCourse5 = new StudentCourse { StudentId = 3, CourseId = 1 };
//var studentCourse6 = new StudentCourse { StudentId = 3, CourseId = 4 };
//var studentCourse7 = new StudentCourse { StudentId = 4, CourseId = 3 };

//db.StudentCourses.AddRange(studentCourse1, studentCourse2, studentCourse3, studentCourse4, studentCourse5, studentCourse6, studentCourse7);

//db.SaveChanges();

// ---------------------------------------------------------
// Task with Methods

//using University;
//var db = new AppDbContext();

//bool isRunning = true;

//while (isRunning)
//{
//    Console.WriteLine("\n=== University Management System ===");
//    Console.WriteLine("1. Student Management");
//    Console.WriteLine("2. Teacher Management");
//    Console.WriteLine("3. Exit");
//    Console.Write("\nChoose option: ");

//    string choice = Console.ReadLine();
//    bool LocalRunning = true;
//    while (LocalRunning)
//    {
//        switch (choice)
//        {
//            case "1":
//                Console.WriteLine("\n--- Student Management ---");
//                Console.WriteLine("1. View All Students");
//                Console.WriteLine("2. View students with student cards");
//                Console.WriteLine("3. View students and all their subjects");
//                Console.WriteLine("4. Back to Main Menu");

//                Console.WriteLine("Input Your Choice: ");
//                string localChoiceStud;
//                localChoiceStud = Console.ReadLine();

//                var studMethods = new Methods(db);

//                if (localChoiceStud == "1")
//                {
//                    studMethods.ViewAllStudents();
//                }
//                else if (localChoiceStud == "2")
//                {
//                    studMethods.ViewAllStudentsWithCards();
//                }
//                else if (localChoiceStud == "3")
//                {
//                    studMethods.ViewAllStudentsWithSubjects();
//                }
//                else if (localChoiceStud == "4")
//                {
//                    LocalRunning = false;
//                }
//                break;

//            case "2":
//                Console.WriteLine("\n--- Teacher Management ---");
//                Console.WriteLine("1. View All Teachers");
//                Console.WriteLine("2. View Teachers with Subjects");
//                Console.WriteLine("3. Back to Main Menu");

//                Console.WriteLine("Input Your Choice: ");
//                string localChoiceTeach;
//                localChoiceTeach = Console.ReadLine();

//                var TeachMethods = new Methods(db);

//                if (localChoiceTeach == "1")
//                {
//                    TeachMethods.viewAllTeachers();
//                }
//                else if (localChoiceTeach == "2")
//                {
//                    TeachMethods.ViewAllCoursesWithTeachers();
//                }
//                else if (localChoiceTeach == "3")
//                {
//                    LocalRunning = false;
//                }
//                break;

//            case "3":
//                Console.WriteLine("Goodbye!");
//                LocalRunning = false;
//                isRunning = false;
//                break;

//            default:
//                Console.WriteLine("Invalid option!");
//                LocalRunning = false;
//                break;
//        }
//    }
//}


// Task 4
//var course6 = new Course
//{
//    Name = "ASP.NET Core",
//    Description = "Web development with ASP.NET Core",
//    TeacherId = 3
//};

//db.Courses.Add(course6);
//db.SaveChanges();

// Task 5
//var student6 = new Student
//{
//    Name = "Test Student",
//    Age = 20,
//    Email = "test@test.com"
//};

//var studentEntry = db.Entry(student6);
//Console.WriteLine(studentEntry.State);  //Detached

//db.Students.Add(student6);
//Console.WriteLine(studentEntry.State); //Added

//db.SaveChanges();
//Console.WriteLine(studentEntry.State); //Unchanged

// 6
//var student = db.Students.First(s => s.Id == 6);
//var studentEntry = db.Entry(student);
//Console.WriteLine(studentEntry.State); //Unchanged

//student.Name = "New Name";
//var studentEntry2 = db.Entry(student);
//Console.WriteLine(studentEntry2.State); //Modified

//db.SaveChanges();
//Console.WriteLine(studentEntry2.State); //Unchanged

// 7
//var student = db.Students.First(s => s.Id == 6);
//var studentEntry = db.Entry(student);
//Console.WriteLine(studentEntry.State); //Unchanged

//db.Remove(student);
//Console.WriteLine(studentEntry.State); //Deleted

//db.SaveChanges();
//Console.WriteLine(studentEntry.State); //Detached

// 8
//var teacher = db.Teachers.First(t => t.Id == 3);
//teacher.Name = "Nursultan";

//var student = db.Students.First(s => s.Id == 5);
//student.Name = "Stalin";
//Modified, Modified
//foreach (var entry in db.ChangeTracker.Entries())
//{
//    Console.WriteLine($"{entry.Entity.GetType().Name} - {entry.State}");
//} 


// 9
// Added

// 10
//var teachers = db.Teachers.Include(c => c.Courses)
//                         .ThenInclude(sc => sc.StudentCourses)
//                         .ThenInclude(s => s.Student)
//                         .ToList();

//foreach (var teacher in teachers)
//{
//    Console.WriteLine($"Teacher: {teacher.Name}\n");

//    foreach (var course in teacher.Courses)
//    {
//        Console.WriteLine($"Course: {course.Name}");
//        Console.WriteLine("Students:");

//        foreach (var studentCourse in course.StudentCourses)
//        {
//            Console.WriteLine($"    {studentCourse.Student.Name}");
//        }

//        Console.WriteLine();
//    }
//}
