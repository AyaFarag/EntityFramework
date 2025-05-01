using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    public class CourseStudent
    {
        public int Id { get; set; }
        public int courseId { get; set; }   // revers prop
       // [ForeignKey("courseId")]
        public virtual Course Course { get; set; }
        public int studentId { get; set; }   // revers prop
        
       // [ForeignKey("studentId")]
        public virtual Student student { get; set; }

    }
}
