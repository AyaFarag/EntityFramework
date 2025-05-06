using CodeFirstApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Controller
{
    public class RelationController
    {
        private readonly ApplicationDBContext context;
        public RelationController(ApplicationDBContext _context) 
        {
            context = _context;
        }

        public void createGradeStudent()
        {
            // 1 exit grade - new students
            // 2 exist grade - exist student - assign
            // 3 new grade + new students
            //var grade = context.grades.Find(1);

            var Students = new List<Student>()
            {
                new Student(){ Name = "Mahmoud"  },
                new Student(){ Name = "Wessam"  },
                new Student(){ Name = "Ahmed"  }
            };


            var grade = new Grade()
            {
                Name = "Grade AAAAAAAAAAAAAAAAAAA",
                Students = Students
            };

            context.grades.Add(grade);
            context.SaveChanges();
            Console.WriteLine("Thanks");
        }

        public void createStudentWithGradeId(int id)
        {
            var garde = context.grades.Find(id);

            var student = new Student();
            student.Name = "Esraa";
            student.Grade = garde;

            context.students.Add(student);
            context.SaveChanges();
            Console.WriteLine("Thanks");
        }

        public void assignGradeStudent(int gradeid , int studentid)
        {
            var grade = context .grades.Find(gradeid);
            var student = context .students.Find(studentid);

            student.Grade = grade;
            context.students.Update(student);
            context.SaveChanges();
            Console.WriteLine("Thanks");
        }

        public void createUserCourse()
        {
            var users = new List<User>()
            {
                new User(){ Name = "User 1" },
                new User(){ Name = "User 2" },
                new User(){ Name = "User 3" },
            };

            var course = new Course()
            {
                Name = "Backend Developers",
                Users = users
            };


            context.courses.Add(course);
            context.SaveChanges();
            Console.WriteLine("Thanks");
        } 
    }
}
