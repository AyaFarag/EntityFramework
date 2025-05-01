



using CodeFirstApp.Controller;
using CodeFirstApp.Data;

ApplicationDBContext _context = new ApplicationDBContext();


StudentController student = new StudentController(_context);

//string[] students = new string[] { "Amr" , "Mostafa", "Sara", "Aya", "Mai", "labeba"};


//for (int i = 0; i < students.Length; i++)
//{
//    student.createStudent(students[i]);
//}

//student.deleteStudent(3);

//student.updateStudent(7 , "Aya Farag");

//student.getAllStudent();

student.getstudentbyid(5);

Console.WriteLine();