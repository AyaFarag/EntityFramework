using CodeFirstApp.Data;
using CodeFirstApp.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Controller
{
    public class TestController
    {
        public ApplicationDBContext context;
        public TestController(ApplicationDBContext _context)
        {
            context = _context;
        }

        public void createGradeStudent()
        {
            var grade = new Grade
            {
                Name = "Grade A",
                Students = new List<Student>
                {
                 new Student { Name = "Ali" },
                 new Student { Name = "Mona" },
                 new Student { Name = "Youssef" }
                }
            };

            context.grades.Add(grade);
            context.SaveChanges();

            Console.WriteLine("success");
        }

        public void createStudentCourse() 
        {
            var user1 = new Student { Name = "Ali" };
            var user2 = new Student { Name = "Mona" };

            var course = new Course { Name = "Entity Framework Core" };
            //var course = context.courses.find(id);
            var userCourses = new List<CourseStudent>
            {
            new CourseStudent { student = user1, Course = course },
            new CourseStudent { student = user2, Course = course }
             };

            context.courseStudents.AddRange(userCourses);
            context.SaveChanges();
            Console.WriteLine("success");

        }

        public void createUserCourse()
        {
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var user1 = new User { Name = "Yasser" };
                var user2 = new User { Name = "Mahmoud" };

                var course = new Course
                {
                    Name = "SQL Server Database",
                    Users = new List<User> { user1, user2 }
                };

                context.courses.Add(course);
                context.SaveChanges();
                transaction.Commit();
                Console.WriteLine("success");
            }
            catch(Exception EX)
            {
                transaction.Rollback(); 
                Console.WriteLine($"Transaction failed: {EX.Message}");
            }
            
        }

        public void getUserCourses()
        {
            // Eager Loading 
            var users = context.users
                        .Include(u => u.Courses) 
                        .ToList();

            foreach (var user1 in users)
            {
                Console.WriteLine($"{user1.Name} is enrolled in: " +
                    $"{string.Join(", ", user1.Courses.Select(c => c.Name))}");
            }
            //-----------------------------------------------------------------
            // Lazy loading
            var user = context.users.First();

            foreach (var course in user.Courses) // Triggers lazy loading here
            {
                Console.WriteLine($"{user.Name} is enrolled in {course.Name}");
            }
            //----------------------------------------------------------------
            // Explicit Loading
            var user2 = context.users.First();

            context.Entry(user)
                   .Collection(u => u.Courses) // or .Reference for single nav props
                   .Load();

            foreach (var course in user.Courses)
            {
                Console.WriteLine($"{user2.Name} enrolled in {course.Name}");
            }
        }
    }
}
