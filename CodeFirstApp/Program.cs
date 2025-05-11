



using CodeFirstApp;
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




TestController tt = new TestController(_context);
//tt.createGradeStudent();

//tt.createUserCourse();


// Create - with relation - Grade one 2 many student
// create - with relation - User many 2 many course [ pivot ] | student current class course  

// loading relations : Eager loading - Lazy loading - Explicit loading


// Recap LINQ
// Row SQL
// Stored proc



RelationController rr = new RelationController(_context);
//rr.createGradeStudent();
//rr.createStudentWithGradeId(1);
//rr.assignGradeStudent(2, 9);

//rr.createUserCourse();

//tt.createStudentCourse();


tt.getGradeWithStudents();
//Console.WriteLine("hello world");

Console.ReadLine();


Console.WriteLine();