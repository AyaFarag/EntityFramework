using CodeFirstApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Controller
{
    public class StudentController
    {   
        // CRUD opertion student

        public ApplicationDBContext context;

        public StudentController()
        {
                
        }

        public StudentController(ApplicationDBContext _context)
        {
            context = _context;
        }

        
        public void createStudent(string name)
        {
            try
            {
                var student = new Student();
                student.Name = name;


                context.students.Add(student);
                context.SaveChanges();

                Console.WriteLine("true");
                
            }
            catch (Exception ex) 
            {
                Console.WriteLine("false", ex.Message);
            }
 
        }


        public void deleteStudent(int id)
        {
            var student = context.students.Where(a=>a.Id == id).FirstOrDefault();
            if (student != null) 
            {
                context.students.Remove(student);
                context.SaveChanges();
                Console.WriteLine("student deleted successfully");
            }
            else
            {
                Console.WriteLine("student not exist");
            }


        }

        public void updateStudent(int id , string name)
        {
            var student = context.students.Find(id);
            if (student != null) 
            { 
                student.Name = name; // 
                context.students.Update(student);
                context.SaveChanges();
                Console.WriteLine("Student updated");
            }
            else
            {
                Console.WriteLine("Student not exist");
            }

        }


        public void getAllStudent()
        {
            var students = context.students
                .Where(a=>a.Name.Contains("b"))
                .OrderByDescending(a => a.Id)
                .ToList();
            foreach (var person in students)
            {
                Console.WriteLine(person.Name);
            }
        }

        public void getstudentbyid(int id)
        {
            var student = context.students.Find(id);
            if (student != null)
            Console.WriteLine($"Name: {student.Name} id: {student.Id}");
        }
    }
}
