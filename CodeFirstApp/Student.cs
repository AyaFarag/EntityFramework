
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace CodeFirstApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // GradeID
        //[InverseProperty("Grade")]
        [AllowNull]
        public int? Grade_id { get; set; }
        
        [ForeignKey("Grade_id")]
        public Grade Grade { get; set; }   // revers property
        public Address Address { get; set; } // navigation prop
        //public ICollection<CourseStudent> courseStudents { get; set; }

        public ICollection<Course> courses { get; set; }


    }
}
