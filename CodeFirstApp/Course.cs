using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public ICollection<CourseStudent> courseStudents { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<User> Users { get; set; }


    }
}
